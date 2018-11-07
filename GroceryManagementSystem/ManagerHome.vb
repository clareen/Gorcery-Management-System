Imports MySql.Data.MySqlClient

Public Class ManagerHome

    Private Sub ContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsToolStripMenuItem.Click
        ManagerContacts.Show()

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        RegisterWorker.Show()

    End Sub

    Private Sub AddSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSupplierToolStripMenuItem.Click
        AddSupplier.Show()

    End Sub

    Private Sub RemoveSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSupplierToolStripMenuItem.Click
        DeleteSupplier.Show()
    End Sub

    Private Sub ViewSupplierDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSupplierDetailsToolStripMenuItem.Click
        DeleteSupplier.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim msgRslt As MsgBoxResult = MessageBox.Show("CONFIRM LOG OUT?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgRslt = MsgBoxResult.Yes Then
            Loginform.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ViewStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStockToolStripMenuItem.Click
        InvetoryView.Show()
    End Sub

    Private Sub AddStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStockToolStripMenuItem.Click
        InvetoryAdd.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click
        Payments.Show()
    End Sub

    Private Sub CompanyInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyInfoToolStripMenuItem.Click
        CompanyDetails.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Try

        '    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
        '    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        '    Dim myDataAdapter As MySqlDataAdapter = New MySqlDataAdapter()
        '    myDataAdapter.SelectCommand = New MySqlCommand("Select * from  trialsinvb.register;", mycon)
        '    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(myDataAdapter)
        '    mycon.Open()
        '    Dim ds As DataSet = New DataSet()
        '    myDataAdapter.Fill(ds)
        '    Dim crp As CrystalReport1 = New CrystalReport1()
        '    crp.SetDataSource(ds)
        '    CrystalReportViewer1.ReportSource = crp
        '    CrystalReportViewer1.Show()
        '    CrystalReportViewer1.Refresh()
        '    mycon.Close()

        'Catch ex As Exception

        '    MessageBox.Show(ex.Message)

        'End Try

    End Sub

    Private Sub MasterEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterEntryToolStripMenuItem.Click

    End Sub

    Private Sub ManagerHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class