Imports MySql.Data.MySqlClient

Public Class DeleteSupplier

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.supplierstable ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            suppliers_dgv.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DeleteSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_datagrid()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

            Dim msgRslt As MsgBoxResult = MessageBox.Show("CHANGE CONTACT DETAILS?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.supplierstable set name='" & txt_name.Text & "' , location='" & txt_location.Text & "', contact='" & txt_tel.Text & "', address='" & txt_address.Text & "',email='" & txt_email.Text & "' where id='" & txt_id.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader
                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("SUPPLIERS DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()
                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
    End Sub

    Private Sub btn_srch_Click(sender As Object, e As EventArgs) Handles btn_srch.Click
        If (txt_id.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY ID NUMBER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
                Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.supplierstable where ID='" & txt_id.Text & "' ;", conDatabase)
                Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
                sda.SelectCommand = cmdDatabase
                Dim dbDataset As DataTable = New DataTable()
                sda.Fill(dbDataset)
                Dim bSource As BindingSource = New BindingSource()
                bSource.DataSource = dbDataset
                suppliers_dgv.DataSource = bSource
                sda.Update(dbDataset)

                Dim i As Integer
                i = suppliers_dgv.CurrentRow.Index
                Me.txt_name.Text = suppliers_dgv.Item(1, i).Value
                Me.txt_location.Text = suppliers_dgv.Item(2, i).Value
                Me.txt_tel.Text = suppliers_dgv.Item(3, i).Value
                Me.txt_address.Text = suppliers_dgv.Item(4, i).Value
                Me.txt_email.Text = suppliers_dgv.Item(5, i).Value

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
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from coinworth.supplierstable  where id='" & txt_id.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("SUPPLIER DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()

                    mycon.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class