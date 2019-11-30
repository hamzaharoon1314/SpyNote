Namespace SN
    Friend Structure Bloom55546
        Public _Name As String

        Private _Value As Color

        Public ReadOnly Property Name As String
            Get
                Return Me._Name
            End Get
        End Property

        Public Property Value As Color
            Get
                Return Me._Value
            End Get
            Set(ByVal value As Color)
                Me._Value = value
            End Set
        End Property

        Public Property ValueHex As String
            Get
                Dim r As Byte = Me._Value.R
                Dim str As String = r.ToString("X2", Nothing)
                r = Me._Value.G
                Dim str1 As String = r.ToString("X2", Nothing)
                r = Me._Value.B
                Dim str2 As String = String.Concat("#", str, str1, r.ToString("X2", Nothing))
                Return str2
            End Get
            Set(ByVal value As String)
                Try
                    Me._Value = ColorTranslator.FromHtml(value)
                Catch exception As System.Exception
                    Return
                End Try
            End Set
        End Property

        Public Sub New(ByVal name As String, ByVal value As Color)
            Dim dz As New Bloom55546()
            dz._Name = name
            dz._Value = value
        End Sub
    End Structure
End Namespace