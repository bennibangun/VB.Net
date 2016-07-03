Public Class Dialog
    Public Sub WarningDialog(ByVal Text As String)
        MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub WarningDialog(ByVal Text As String, ByVal Title As String)
        MessageBox.Show(Text, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub InformationDialog(ByVal Text As String, ByVal Title As String)
        MessageBox.Show(Text, Title, MessageBoxButtons.YesNo)
    End Sub

End Class
