Imports System
Imports System.Drawing

Namespace spy673
    Friend Structure Bloom55546
        Public ReadOnly Property Name As String
            Get
                Return Me._Name
            End Get
        End Property

        Public Property Value As Color
            Get
                Return Me._Value
            End Get
            Set(value As Color)
                Me._Value = value
            End Set
        End Property

        Public Property ValueHex As String
            Get
                Return "#" + Me._Value.R.ToString("X2", Nothing) + Me._Value.G.ToString("X2", Nothing) + Me._Value.B.ToString("X2", Nothing)
            End Get
            Set(value As String)
                Try
                    Me._Value = ColorTranslator.FromHtml(value)
                Catch ex As Exception
                End Try
            End Set
        End Property

        Public Sub New(name As String, value As Color)
            Me._Name = name
            Me._Value = value
        End Sub

        Public _Name As String

        Private _Value As Color
    End Structure
End Namespace

