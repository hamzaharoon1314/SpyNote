Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace SN.SpyNote.Stores
    Public Module ContextRicBox
        Public _ContextMenuContextRicBox As ContextMenuStrip
        Public Property ContextMenuContextRicBox As ContextMenuStrip
            <CompilerGenerated()>
            Get
                Return ContextRicBox._ContextMenuContextRicBox
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ContextMenuStrip)
                Dim value2 As CancelEventHandler = AddressOf ContextRicBox.ContextMenuContextRicBox_Opening
                Dim contextMenuContextRicBox As ContextMenuStrip = ContextRicBox._ContextMenuContextRicBox
                If contextMenuContextRicBox IsNot Nothing Then
                    RemoveHandler contextMenuContextRicBox.Opening, value2
                End If
                ContextRicBox._ContextMenuContextRicBox = value
                contextMenuContextRicBox = ContextRicBox._ContextMenuContextRicBox
                If contextMenuContextRicBox IsNot Nothing Then
                    AddHandler contextMenuContextRicBox.Opening, value2
                End If
            End Set
        End Property
        Public _Caut_0 As ToolStripMenuItem
        Public Property Caut_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextRicBox._Caut_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextRicBox.Caut_0_Click
                Dim caut_ As ToolStripMenuItem = ContextRicBox._Caut_0
                If caut_ IsNot Nothing Then
                    RemoveHandler caut_.Click, value2
                End If
                ContextRicBox._Caut_0 = value
                caut_ = ContextRicBox._Caut_0
                If caut_ IsNot Nothing Then
                    AddHandler caut_.Click, value2
                End If
            End Set
        End Property
        Public _Copy_0 As ToolStripMenuItem
        Public Property Copy_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextRicBox._Copy_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextRicBox.Copy_0_Click
                Dim copy_ As ToolStripMenuItem = ContextRicBox._Copy_0
                If copy_ IsNot Nothing Then
                    RemoveHandler copy_.Click, value2
                End If
                ContextRicBox._Copy_0 = value
                copy_ = ContextRicBox._Copy_0
                If copy_ IsNot Nothing Then
                    AddHandler copy_.Click, value2
                End If
            End Set
        End Property
        Public _Paste_0 As ToolStripMenuItem
        Public Property Paste_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextRicBox._Paste_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextRicBox.Paste_0_Click
                Dim paste_ As ToolStripMenuItem = ContextRicBox._Paste_0
                If paste_ IsNot Nothing Then
                    RemoveHandler paste_.Click, value2
                End If
                ContextRicBox._Paste_0 = value
                paste_ = ContextRicBox._Paste_0
                If paste_ IsNot Nothing Then
                    AddHandler paste_.Click, value2
                End If
            End Set
        End Property
        Public _Select_All_0 As ToolStripMenuItem
        Public Property Select_All_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextRicBox._Select_All_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextRicBox.Select_all_0_Click
                Dim select_All_ As ToolStripMenuItem = ContextRicBox._Select_All_0
                If select_All_ IsNot Nothing Then
                    RemoveHandler select_All_.Click, value2
                End If
                ContextRicBox._Select_All_0 = value
                select_All_ = ContextRicBox._Select_All_0
                If select_All_ IsNot Nothing Then
                    AddHandler select_All_.Click, value2
                End If
            End Set
        End Property

        Public Sub Menu_Items()
            ContextRicBox.Caut_0 = New ToolStripMenuItem()
            ContextRicBox.Copy_0 = New ToolStripMenuItem()
            ContextRicBox.Paste_0 = New ToolStripMenuItem()
            ContextRicBox.Select_All_0 = New ToolStripMenuItem()
            ContextRicBox.Caut_0.ImageScaling = ToolStripItemImageScaling.None
            ContextRicBox.Copy_0.ImageScaling = ToolStripItemImageScaling.None
            ContextRicBox.Paste_0.ImageScaling = ToolStripItemImageScaling.None
            ContextRicBox.Select_All_0.ImageScaling = ToolStripItemImageScaling.None
            ContextRicBox.Caut_0.Text = "Cut"
            ContextRicBox.Copy_0.Text = "Copy"
            ContextRicBox.Paste_0.Text = "Paste"
            ContextRicBox.Select_All_0.Text = "Select All"
            ContextRicBox.ContextMenuContextRicBox = New ContextMenuStrip()
            ContextRicBox.ContextMenuContextRicBox.ShowImageMargin = False
            ContextRicBox.ContextMenuContextRicBox.Items.Add(ContextRicBox.Caut_0)
            ContextRicBox.ContextMenuContextRicBox.Items.Add(ContextRicBox.Copy_0)
            ContextRicBox.ContextMenuContextRicBox.Items.Add(ContextRicBox.Paste_0)
            ContextRicBox.ContextMenuContextRicBox.Items.Add(ContextRicBox.Select_All_0)
            ContextRicBox.ContextMenuContextRicBox.RenderMode = ToolStripRenderMode.System
            ContextRicBox.ContextMenuContextRicBox.Renderer = New ThemeToolStrip()
        End Sub

        Private Sub ContextMenuContextRicBox_Opening(sender As Object, e As CancelEventArgs)
            Dim flag As Boolean = ContextTextView.ContextMenuContextTextView IsNot Nothing
            If flag Then
                Dim contextMenuContextRicBox As ContextMenuStrip = ContextRicBox.ContextMenuContextRicBox
                Dim richTextBox As RichTextBox = CType(contextMenuContextRicBox.SourceControl, RichTextBox)
                Dim [readOnly] As Boolean = richTextBox.[ReadOnly]
                If [readOnly] Then
                    ContextRicBox.Paste_0.Enabled = False
                    ContextRicBox.Caut_0.Enabled = False
                Else
                    ContextRicBox.Paste_0.Enabled = True
                    ContextRicBox.Caut_0.Enabled = True
                End If
            End If
        End Sub

        Private Sub Caut_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim richTextBox As RichTextBox = CType(contextMenuStrip.SourceControl, RichTextBox)
            richTextBox.Cut()
        End Sub

        Private Sub Copy_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim richTextBox As RichTextBox = CType(contextMenuStrip.SourceControl, RichTextBox)
            richTextBox.Copy()
        End Sub

        Private Sub Paste_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim richTextBox As RichTextBox = CType(contextMenuStrip.SourceControl, RichTextBox)
            richTextBox.Paste()
        End Sub

        Private Sub Select_all_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim richTextBox As RichTextBox = CType(contextMenuStrip.SourceControl, RichTextBox)
            richTextBox.SelectAll()
        End Sub
    End Module
End Namespace
