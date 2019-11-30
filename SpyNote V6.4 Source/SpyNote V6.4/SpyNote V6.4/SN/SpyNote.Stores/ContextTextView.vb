Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace SN.SpyNote.Stores
    Public Module ContextTextView
        Public _ContextMenuContextTextView As ContextMenuStrip
        Public Property ContextMenuContextTextView As ContextMenuStrip
            <CompilerGenerated()>
            Get
                Return ContextTextView._ContextMenuContextTextView
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ContextMenuStrip)
                Dim value2 As CancelEventHandler = AddressOf ContextTextView.ContextMenuContextTextView_Opening
                Dim contextMenuContextTextView As ContextMenuStrip = ContextTextView._ContextMenuContextTextView
                If contextMenuContextTextView IsNot Nothing Then
                    RemoveHandler contextMenuContextTextView.Opening, value2
                End If
                ContextTextView._ContextMenuContextTextView = value
                contextMenuContextTextView = ContextTextView._ContextMenuContextTextView
                If contextMenuContextTextView IsNot Nothing Then
                    AddHandler contextMenuContextTextView.Opening, value2
                End If
            End Set
        End Property
        Public _Caut_0 As ToolStripMenuItem
        Public Property Caut_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextTextView._Caut_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextTextView.Caut_0_Click
                Dim caut_ As ToolStripMenuItem = ContextTextView._Caut_0
                If caut_ IsNot Nothing Then
                    RemoveHandler caut_.Click, value2
                End If
                ContextTextView._Caut_0 = value
                caut_ = ContextTextView._Caut_0
                If caut_ IsNot Nothing Then
                    AddHandler caut_.Click, value2
                End If
            End Set
        End Property
        Public _Copy_0 As ToolStripMenuItem
        Public Property Copy_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextTextView._Copy_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextTextView.Copy_0_Click
                Dim copy_ As ToolStripMenuItem = ContextTextView._Copy_0
                If copy_ IsNot Nothing Then
                    RemoveHandler copy_.Click, value2
                End If
                ContextTextView._Copy_0 = value
                copy_ = ContextTextView._Copy_0
                If copy_ IsNot Nothing Then
                    AddHandler copy_.Click, value2
                End If
            End Set
        End Property
        Public _Paste_0 As ToolStripMenuItem
        Public Property Paste_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextTextView._Paste_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextTextView.Paste_0_Click
                Dim paste_ As ToolStripMenuItem = ContextTextView._Paste_0
                If paste_ IsNot Nothing Then
                    RemoveHandler paste_.Click, value2
                End If
                ContextTextView._Paste_0 = value
                paste_ = ContextTextView._Paste_0
                If paste_ IsNot Nothing Then
                    AddHandler paste_.Click, value2
                End If
            End Set
        End Property
        Public _Select_All_0 As ToolStripMenuItem
        Public Property Select_All_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextTextView._Select_All_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextTextView.Select_all_0_Click
                Dim select_All_ As ToolStripMenuItem = ContextTextView._Select_All_0
                If select_All_ IsNot Nothing Then
                    RemoveHandler select_All_.Click, value2
                End If
                ContextTextView._Select_All_0 = value
                select_All_ = ContextTextView._Select_All_0
                If select_All_ IsNot Nothing Then
                    AddHandler select_All_.Click, value2
                End If
            End Set
        End Property

        Public Sub Menu_Items()
            ContextTextView.Caut_0 = New ToolStripMenuItem()
            ContextTextView.Copy_0 = New ToolStripMenuItem()
            ContextTextView.Paste_0 = New ToolStripMenuItem()
            ContextTextView.Select_All_0 = New ToolStripMenuItem()
            ContextTextView.Caut_0.ImageScaling = ToolStripItemImageScaling.None
            ContextTextView.Copy_0.ImageScaling = ToolStripItemImageScaling.None
            ContextTextView.Paste_0.ImageScaling = ToolStripItemImageScaling.None
            ContextTextView.Select_All_0.ImageScaling = ToolStripItemImageScaling.None
            ContextTextView.Caut_0.Text = "Cut"
            ContextTextView.Copy_0.Text = "Copy"
            ContextTextView.Paste_0.Text = "Paste"
            ContextTextView.Select_All_0.Text = "Select All"
            ContextTextView.ContextMenuContextTextView = New ContextMenuStrip()
            ContextTextView.ContextMenuContextTextView.ShowImageMargin = False
            ContextTextView.ContextMenuContextTextView.Items.Add(ContextTextView.Caut_0)
            ContextTextView.ContextMenuContextTextView.Items.Add(ContextTextView.Copy_0)
            ContextTextView.ContextMenuContextTextView.Items.Add(ContextTextView.Paste_0)
            ContextTextView.ContextMenuContextTextView.Items.Add(ContextTextView.Select_All_0)
            ContextTextView.ContextMenuContextTextView.RenderMode = ToolStripRenderMode.System
            ContextTextView.ContextMenuContextTextView.Renderer = New ThemeToolStrip()
        End Sub

        Private Sub ContextMenuContextTextView_Opening(sender As Object, e As CancelEventArgs)
            Dim flag As Boolean = ContextTextView.ContextMenuContextTextView IsNot Nothing
            If flag Then
                Dim contextMenuContextTextView As ContextMenuStrip = ContextTextView.ContextMenuContextTextView
                Dim textBox As TextBox = CType(contextMenuContextTextView.SourceControl, TextBox)
                Dim [readOnly] As Boolean = textBox.[ReadOnly]
                If [readOnly] Then
                    ContextTextView.Paste_0.Enabled = False
                    ContextTextView.Caut_0.Enabled = False
                Else
                    ContextTextView.Paste_0.Enabled = True
                    ContextTextView.Caut_0.Enabled = True
                End If
            End If
        End Sub

        Private Sub Caut_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim textBox As TextBox = CType(contextMenuStrip.SourceControl, TextBox)
            textBox.Cut()
        End Sub

        Private Sub Copy_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim textBox As TextBox = CType(contextMenuStrip.SourceControl, TextBox)
            textBox.Copy()
        End Sub

        Private Sub Paste_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim textBox As TextBox = CType(contextMenuStrip.SourceControl, TextBox)
            textBox.Paste()
        End Sub

        Private Sub Select_all_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim textBox As TextBox = CType(contextMenuStrip.SourceControl, TextBox)
            textBox.SelectAll()
        End Sub
    End Module
End Namespace
