Public Class AdminHome

    Private Sub REGISTEREMPLOYEEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTEREMPLOYEEToolStripMenuItem.Click
        RegisterWorker.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim msgRslt As MsgBoxResult = MessageBox.Show("CONFIRM LOG OUT?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgRslt = MsgBoxResult.Yes Then
            Me.Hide()
            Loginform.Show()
        End If
    End Sub

    Private Sub REGISTERMANGERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTERMANGERToolStripMenuItem.Click
        ManagerRegistration.Show()
    End Sub

    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class