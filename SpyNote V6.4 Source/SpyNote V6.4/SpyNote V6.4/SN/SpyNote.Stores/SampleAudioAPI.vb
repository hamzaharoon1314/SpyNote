Imports System.ComponentModel
Imports CoreAudioApi

Namespace SN.SpyNote.Stores
    <Description("Inherits simple functions provided by CoreAudioAPI.dll")>
    <Browsable(True)>
    Public Class SampleAudioAPI
        Public Sub New()
            Me.Smooth_OUT_MASTER = New SampleAudioAPI.AudioSmoother()
            Me.Smooth_OUT_LEFT = New SampleAudioAPI.AudioSmoother()
            Me.Smooth_OUT_RIGHT = New SampleAudioAPI.AudioSmoother()
            If Environment.OSVersion.Version.Major < 6 Then
                Throw New InvalidEnumArgumentException("Minimum Windows Vista requiered.")
            End If
            Me.devEnum = New MMDeviceEnumerator()
            Me.deviceRender = Me.devEnum.GetDefaultAudioEndpoint(0, 1)
        End Sub

        <Description("Returns the value of the associated audio channel.")>
        <Browsable(True)>
        Public Function Value(channel As SampleAudioAPI.Channels, Optional smooth As Boolean = False) As Single
            Dim result As Single
            Try
                Dim num As Integer = Me.deviceRender.State
                Select Case channel
                    Case SampleAudioAPI.Channels.OUT_LeftPeak
                        If num = 1 AndAlso Me.deviceRender.AudioMeterInformation.PeakValues.Count >= 1 Then
                            Dim num2 As Single = Me.deviceRender.AudioMeterInformation.PeakValues(0)
                            Me.Smooth_OUT_LEFT.Input = SampleAudioAPI.SingleToIntPercentage(num2)
                            Return If(smooth, SampleAudioAPI.IntToSinglePercentage(Me.Smooth_OUT_LEFT.SmoothedValue), num2)
                        End If
                    Case SampleAudioAPI.Channels.OUT_RightPeak
                        If num = 1 AndAlso Me.deviceRender.AudioMeterInformation.PeakValues.Count >= 2 Then
                            Dim num3 As Single = Me.deviceRender.AudioMeterInformation.PeakValues(1)
                            Me.Smooth_OUT_RIGHT.Input = SampleAudioAPI.SingleToIntPercentage(num3)
                            Return If(smooth, SampleAudioAPI.IntToSinglePercentage(Me.Smooth_OUT_RIGHT.SmoothedValue), num3)
                        End If
                    Case SampleAudioAPI.Channels.OUT_Master
                        If num = 1 AndAlso Me.deviceRender.AudioMeterInformation.PeakValues.Count <> 0 Then
                            Dim masterPeakValue As Single = Me.deviceRender.AudioMeterInformation.MasterPeakValue
                            Me.Smooth_OUT_MASTER.Input = SampleAudioAPI.SingleToIntPercentage(masterPeakValue)
                            Return If(smooth, SampleAudioAPI.IntToSinglePercentage(Me.Smooth_OUT_MASTER.SmoothedValue), masterPeakValue)
                        End If
                End Select
                result = 0F
            Catch ex As Exception
                result = 0F
            End Try
            Return result
        End Function

        Public Property OUT_MasterScalar As Single
            Get
                Return Me.deviceRender.AudioEndpointVolume.MasterVolumeLevelScalar
            End Get
            Set(value As Single)
                Me.deviceRender.AudioEndpointVolume.MasterVolumeLevelScalar = value
            End Set
        End Property

        Public Property OUT_MUTE As Boolean
            Get
                Return Me.deviceRender.AudioEndpointVolume.Mute
            End Get
            Set(value As Boolean)
                Me.deviceRender.AudioEndpointVolume.Mute = value
            End Set
        End Property

        Public Shared Function SingleToIntPercentage(value As Single) As Integer
            Dim num As UInteger = CUInt(Math.Round(CDbl((Math.Min(1.0F, value) * 100.0F))))
            Return CInt(num)
        End Function

        Public Shared Function IntToSinglePercentage(value As Integer) As Single
            Return CSng((CDbl(Math.Min(100, value)) / 100.0))
        End Function

        Friend deviceRender As MMDevice

        Friend devEnum As MMDeviceEnumerator

        Private Smooth_OUT_MASTER As SampleAudioAPI.AudioSmoother

        Private Smooth_OUT_LEFT As SampleAudioAPI.AudioSmoother

        Private Smooth_OUT_RIGHT As SampleAudioAPI.AudioSmoother

        <Description("Audio Channels.")>
        <Browsable(True)>
        Public Enum Channels
            OUT_LeftPeak = 4
            OUT_RightPeak
            OUT_Master
        End Enum

        Private Class AudioSmoother
            Public WriteOnly Property Input As Integer
                Set(value As Integer)
                    Me.Value = value
                End Set
            End Property

            Public ReadOnly Property SmoothedValue As Integer
                Get
                    Return Me.Fader()
                End Get
            End Property

            Private Function Fader() As Integer
                Dim result As Integer
                If Me.Value = 0 Then
                    result = 0
                Else
                    Dim val As Integer = Math.Min((Me.Value + Me.SmoothValue) / 2, 100)
                    Me.SmoothValue = Math.Max(Math.Max(val, Me.SmoothValue - 2), 0)
                    result = Me.SmoothValue
                End If
                Return result
            End Function

            Private Value As Integer

            Protected SmoothValue As Integer

            Private Const Decrement As Integer = 2
        End Class
    End Class
End Namespace
