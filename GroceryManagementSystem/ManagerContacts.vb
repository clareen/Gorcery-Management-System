Imports MySql.Data.MySqlClient

Public Class ManagerContacts

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.contacttable ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            contact_dgv.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ManagerContacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_datagrid()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (txt_dep.Text = "" Or txt_name.Text = "" Or txt_tel.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.contacttable(name,number,department) values('" & txt_name.Text & "','" & txt_tel.Text & "','" & txt_dep.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("NEW CONTACT CREATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fill_datagrid()
                mycon.Close()
                txt_dep.Text = ""
                txt_name.Text = ""
                txt_tel.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If (txt_dep.Text = "" Or txt_name.Text = "" Or txt_tel.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("CHANGE CONTACT DETAILS?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.contacttable set name='" & txt_name.Text & "' , number='" & txt_tel.Text & "', department='" & txt_dep.Text & "' where name='" & txt_name.Text & "' or number='" & txt_tel.Text & "' or department='" & txt_dep.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("CONTACT DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()
                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        End If



    End Sub

    Private Sub btn_srch_Click(sender As Object, e As EventArgs) Handles btn_srch.Click

        If (txt_name_srch.Text = "") Then
            'validating empty fields
            MessageBox.Show("NO EMPTY FIELDS IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
                Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.contacttable where name='" + txt_name_srch.Text + "' ;", conDatabase)
                Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
                sda.SelectCommand = cmdDatabase
                Dim dbDataset As DataTable = New DataTable()
                sda.Fill(dbDataset)
                Dim bSource As BindingSource = New BindingSource()
                bSource.DataSource = dbDataset
                contact_dgv.DataSource = bSource
                sda.Update(dbDataset)

                Dim i As Integer
                i = contact_dgv.CurrentRow.Index
                Me.txt_name.Text = contact_dgv.Item(0, i).Value
                Me.txt_tel.Text = contact_dgv.Item(1, i).Value
                Me.txt_dep.Text = contact_dgv.Item(2, i).Value

                conDatabase.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If (txt_dep.Text = "" Or txt_name.Text = "" Or txt_tel.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("DELETE RECORD?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from coinworth.contacttable  where number='" & txt_tel.Text & "' ", mycon)
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
End Class