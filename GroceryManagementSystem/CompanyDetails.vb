Imports MySql.Data.MySqlClient

Public Class CompanyDetails

    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.companydetails ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            cmp_dgv.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pic_logo.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (txt_name.Text = "" Or txt_cin.Text = "" Or txt_contact.Text = "" Or txt_location.Text = "" Or txt_tin.Text = "") Then
            'validating empty fields
            MessageBox.Show("EMPTY VALUES", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.companydetails(name,location,tin,cin,contact) values('" & txt_name.Text & "','" & txt_location.Text & "','" & txt_tin.Text & "','" & txt_cin.Text & "','" & txt_contact.Text & "') ", mycon)
                Dim SelectCommand2 As MySqlCommand = New MySqlCommand("insert into coinworth.companyimage(name,image) values('" & txt_name.Text & "','" & pic_logo.ImageLocation & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("DETAILS ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fill_datagrid()
                mycon.Close()
                mycon.Open()
                myReader = SelectCommand2.ExecuteReader()
                MessageBox.Show("IMAGE ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click

        If (txt_name.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY NAME", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("CHANGE DETAILS?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.companydetails set location='" & txt_location.Text & "', tin='" & txt_tin.Text & "', cin='" & txt_cin.Text & "',contact='" & txt_contact.Text & "' where name='" & txt_name.Text & "' ", mycon)
                    Dim SelectCommand2 As MySqlCommand = New MySqlCommand("update  coinworth.companyimage set image='" & pic_logo.ImageLocation & "' where name='" & txt_name.Text & "'", mycon)
                    Dim myReader As MySqlDataReader
                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show(" DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()
                    mycon.Close()

                    mycon.Open()
                    myReader = SelectCommand2.ExecuteReader()
                    MessageBox.Show(" DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        End If
    End Sub

    Private Sub CompanyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_datagrid()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If (txt_name.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY NAME", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("DELETE RECORD?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from coinworth.companydetails  where name='" & txt_name.Text & "' ", mycon)
                    Dim SelectCommand2 As MySqlCommand = New MySqlCommand("delete from coinworth.companyimage  where name='" & txt_name.Text & "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("RECORD DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fill_datagrid()

                    mycon.Close()

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("RECORD DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mycon.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click



        If (txt_name.Text = "") Then
            'validating empty fields
            MessageBox.Show("SEARCH BY NAME", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
                Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.companydetails where NAME='" & txt_name.Text & "' ;", conDatabase)
                Dim cmdDatabase2 As MySqlCommand = New MySqlCommand("Select image from  coinworth.companyimage where NAME='" & txt_name.Text & "' ;", conDatabase)
                Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
                sda.SelectCommand = cmdDatabase
                Dim dbDataset As DataTable = New DataTable()
                sda.Fill(dbDataset)
                Dim bSource As BindingSource = New BindingSource()
                bSource.DataSource = dbDataset
                cmp_dgv.DataSource = bSource
                sda.Update(dbDataset)

                Dim i As Integer
                i = cmp_dgv.CurrentRow.Index
                Me.txt_name.Text = cmp_dgv.Item(0, i).Value
                Me.txt_location.Text = cmp_dgv.Item(1, i).Value
                Me.txt_tin.Text = cmp_dgv.Item(2, i).Value
                Me.txt_cin.Text = cmp_dgv.Item(3, i).Value
                Me.txt_contact.Text = cmp_dgv.Item(4, i).Value

                sda.SelectCommand = cmdDatabase2
                Dim dbDataset2 As New DataTable("coinworth.companyimage")
                sda.Fill(dbDataset2)

                If dbDataset2.Rows.Count > 0 Then
                    pic_logo.ImageLocation = "image" 'What is displayed
                End If

                conDatabase.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
End Class