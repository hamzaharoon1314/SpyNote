Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace SN.SpyNote.Stores
    Public Module ContextGriedView
        Public _ContextMenuContextGriedView As ContextMenuStrip
        Public Property ContextMenuContextGriedView As ContextMenuStrip
            <CompilerGenerated()>
            Get
                Return ContextGriedView._ContextMenuContextGriedView
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ContextMenuStrip)
                Dim value2 As CancelEventHandler = AddressOf ContextGriedView.ContextMenuContextGriedView_Opening
                Dim contextMenuContextGriedView As ContextMenuStrip = ContextGriedView._ContextMenuContextGriedView
                If contextMenuContextGriedView IsNot Nothing Then
                    RemoveHandler contextMenuContextGriedView.Opening, value2
                End If
                ContextGriedView._ContextMenuContextGriedView = value
                contextMenuContextGriedView = ContextGriedView._ContextMenuContextGriedView
                If contextMenuContextGriedView IsNot Nothing Then
                    AddHandler contextMenuContextGriedView.Opening, value2
                End If
            End Set
        End Property
        Public _Copy_0 As ToolStripMenuItem
        Public Property Copy_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextGriedView._Copy_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextGriedView.Copy_0_Click
                Dim copy_ As ToolStripMenuItem = ContextGriedView._Copy_0
                If copy_ IsNot Nothing Then
                    RemoveHandler copy_.Click, value2
                End If
                ContextGriedView._Copy_0 = value
                copy_ = ContextGriedView._Copy_0
                If copy_ IsNot Nothing Then
                    AddHandler copy_.Click, value2
                End If
            End Set
        End Property
        Public _Select_All_0 As ToolStripMenuItem
        Public Property Select_All_0 As ToolStripMenuItem
            <CompilerGenerated()>
            Get
                Return ContextGriedView._Select_All_0
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolStripMenuItem)
                Dim value2 As EventHandler = AddressOf ContextGriedView.Select_all_0_Click
                Dim select_All_ As ToolStripMenuItem = ContextGriedView._Select_All_0
                If select_All_ IsNot Nothing Then
                    RemoveHandler select_All_.Click, value2
                End If
                ContextGriedView._Select_All_0 = value
                select_All_ = ContextGriedView._Select_All_0
                If select_All_ IsNot Nothing Then
                    AddHandler select_All_.Click, value2
                End If
            End Set
        End Property

        Public Sub Menu_Items()
            ContextGriedView.Copy_0 = New ToolStripMenuItem()
            ContextGriedView.Select_All_0 = New ToolStripMenuItem()
            ContextGriedView.Copy_0.ImageScaling = ToolStripItemImageScaling.None
            ContextGriedView.Select_All_0.ImageScaling = ToolStripItemImageScaling.None
            ContextGriedView.Copy_0.Text = "Copy"
            ContextGriedView.Select_All_0.Text = "Select All"
            ContextGriedView.ContextMenuContextGriedView = New ContextMenuStrip()
            ContextGriedView.ContextMenuContextGriedView.ShowImageMargin = False
            ContextGriedView.ContextMenuContextGriedView.Items.Add(ContextGriedView.Copy_0)
            ContextGriedView.ContextMenuContextGriedView.Items.Add(ContextGriedView.Select_All_0)
            ContextGriedView.ContextMenuContextGriedView.RenderMode = ToolStripRenderMode.System
            ContextGriedView.ContextMenuContextGriedView.Renderer = New ThemeToolStrip()
        End Sub

        Private Sub ContextMenuContextGriedView_Opening(sender As Object, e As CancelEventArgs)
            Dim flag As Boolean = ContextGriedView.ContextMenuContextGriedView IsNot Nothing
            If flag Then
                Dim contextMenuContextGriedView As ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
                Dim dataGridView As DataGridView = CType(contextMenuContextGriedView.SourceControl, DataGridView)
                Dim flag2 As Boolean = Not dataGridView.MultiSelect
                If flag2 Then
                    ContextGriedView.Select_All_0.Enabled = False
                Else
                    ContextGriedView.Select_All_0.Enabled = True
                End If
            End If
        End Sub

        Private Sub Copy_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim dataGridView As DataGridView = CType(contextMenuStrip.SourceControl, DataGridView)
            Dim flag As Boolean = dataGridView.SelectedRows.Count > 0
            If flag Then
                Dim num As Integer = dataGridView.SelectedRows.Count - 1
                For i As Integer = num To 0 Step -1
                    dataGridView.Rows(dataGridView.SelectedRows(i).Index).Clone()
                    Clipboard.SetDataObject(dataGridView.GetClipboardContent())
                Next
            End If
        End Sub

        Private Sub Select_all_0_Click(sender As Object, e As EventArgs)
            Dim contextMenuStrip As ContextMenuStrip = CType(CType(sender, ToolStripItem).Owner, ContextMenuStrip)
            Dim dataGridView As DataGridView = CType(contextMenuStrip.SourceControl, DataGridView)
            dataGridView.SelectAll()
        End Sub
    End Module
End Namespace
