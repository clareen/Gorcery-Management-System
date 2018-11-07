Imports MySql.Data.MySqlClient

Public Class InvetoryView

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.productstable ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            products_dgv.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub InvetoryView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_datagrid()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If (txt_prdctid.Text = "") Then
            MessageBox.Show("INPUT PRODUCT ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("CHANGE PRODUCT DETAILS FOR THIS ID?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.productstable set productname='" & txt_pname.Text & "' , productprice='" & txt_pprice.Text & "' where productid='" & txt_prdctid.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader
                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("PRODUCT DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()
                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        End If
    End Sub

    Private Sub btn_srch_Click(sender As Object, e As EventArgs) Handles btn_srch.Click
        If (txt_prdctid.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY ID NUMBER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
                Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.productstable where productid='" + txt_prdctid.Text + "' ;", conDatabase)
                Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
                sda.SelectCommand = cmdDatabase
                Dim dbDataset As DataTable = New DataTable()
                sda.Fill(dbDataset)
                Dim bSource As BindingSource = New BindingSource()
                bSource.DataSource = dbDataset
                products_dgv.DataSource = bSource
                sda.Update(dbDataset)

                Dim i As Integer
                i = products_dgv.CurrentRow.Index
                Me.txt_pname.Text = products_dgv.Item(1, i).Value
                Me.txt_pprice.Text = products_dgv.Item(2, i).Value

                conDatabase.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If (txt_prdctid.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY ID NUMBER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("DELETE RECORD?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from coinworth.productstable  where productid='" & txt_prdctid.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("PRODUCT DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()

                    mycon.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class