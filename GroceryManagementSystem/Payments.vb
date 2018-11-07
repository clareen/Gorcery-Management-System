Imports MySql.Data.MySqlClient

Public Class Payments

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.paymenttable ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            dgv_payments.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If (txt_id.Text = "") Then
            MessageBox.Show("INPUT WORKER ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim wkhrs As Integer
            Dim perhr As Integer
            Dim paid As Integer

            wkhrs = Val(txt_hours.Text)
            perhr = Val(txt_payperhour.Text)

            paid = wkhrs * perhr

            txt_paid.Text = paid.ToString

            Dim msgRslt As MsgBoxResult = MessageBox.Show("CHANGE PRODUCT DETAILS FOR THIS ID?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.paymenttable set pay_per_hour='" & txt_payperhour.Text & "' , workedhours='" & txt_hours.Text & "', amountpaid='" & txt_paid.Text & "' where workerid='" & txt_id.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader
                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()
                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        End If
    End Sub

    Private Sub Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_datagrid()
    End Sub

    Private Sub btn_srch_Click(sender As Object, e As EventArgs) Handles btn_srch.Click
        If (txt_id.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY ID NUMBER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
                Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.paymenttable where workerid='" + txt_id.Text + "' ;", conDatabase)
                Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
                sda.SelectCommand = cmdDatabase
                Dim dbDataset As DataTable = New DataTable()
                sda.Fill(dbDataset)
                Dim bSource As BindingSource = New BindingSource()
                bSource.DataSource = dbDataset
                dgv_payments.DataSource = bSource
                sda.Update(dbDataset)

                Dim i As Integer
                i = dgv_payments.CurrentRow.Index
                Me.txt_payperhour.Text = dgv_payments.Item(1, i).Value
                Me.txt_hours.Text = dgv_payments.Item(2, i).Value
                Me.txt_paid.Text = dgv_payments.Item(3, i).Value

                conDatabase.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If (txt_id.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY ID NUMBER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("DELETE RECORD?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from coinworth.paymenttable  where workerid='" & txt_id.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("RECORD DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()

                    mycon.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click

        

        If (txt_hours.Text = "" Or txt_id.Text = "" Or txt_payperhour.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim wkhrs As Integer
            Dim perhr As Integer
            Dim paid As Integer

            wkhrs = Val(txt_hours.Text)
            perhr = Val(txt_payperhour.Text)

            paid = wkhrs * perhr

            txt_paid.Text = paid.ToString

            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.paymenttable(workerid,pay_per_hour,workedhours,amountpaid) values('" & txt_id.Text & "','" & txt_payperhour.Text & "','" & txt_hours.Text & "','" & txt_paid.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("RECORD ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fill_datagrid()
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
End Class