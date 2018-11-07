Imports MySql.Data.MySqlClient

Public Class RegisterWorker

    Dim rand As New Random()
    Public Sub fill_datagrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.stafftable ", conDatabase)
            Dim dtgv As MySqlDataAdapter = New MySqlDataAdapter()
            dtgv.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            dtgv.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            staff_dgv.DataSource = bSource
            dtgv.Update(dbDataset)
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub RegisterWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_datagrid()
        txt_staffid.Text = rand.Next(12345, 98765).ToString
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (txt_staffid.Text = "" Or txt_staffname.Text = "" Or txt_stafftel.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (txt_staffpassword.TextLength < 5) Then
            MessageBox.Show("SHORT PASSWORD", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.stafftable(staffid,name,gender,contact,hiredate,password) values('" & txt_staffid.Text & "','" & txt_staffname.Text & "','" & cmb_gender.SelectedItem & "','" & txt_stafftel.Text & "','" & dtp_staffhiredate.Text & "','" & txt_staffpassword.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("REGISTRATION SUCCESSFULL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fill_datagrid()
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If (txt_staffpassword.TextLength < 5) Then
            MessageBox.Show("SHORT PASSWORD", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("CHANGE CONTACT DETAILS?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.stafftable set name='" & txt_staffname.Text & "' , gender='" & cmb_gender.SelectedItem & "', contact='" & txt_stafftel.Text & "', enddate='" & dtp_staffenddate.Text & "' where staffid='" & txt_staffid.Text & "' ", mycon)
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

    Private Sub staff_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles staff_dgv.CellContentClick
        Dim i As Integer
        i = staff_dgv.CurrentRow.Index
        txt_staffid.Text = staff_dgv.Item(0, i).Value
        txt_staffname.Text = staff_dgv.Item(1, i).Value
        cmb_gender.Text = staff_dgv.Item(2, i).Value
        txt_stafftel.Text = staff_dgv.Item(3, i).Value

    End Sub

    Private Sub btn_srch_Click(sender As Object, e As EventArgs) Handles btn_srch.Click
        If (txt_staffid.Text = "") Then
            'validating empty fields
            MessageBox.Show("NO EMPTY FIELDS IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
                Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.stafftable where staffid='" + txt_staffid.Text + "' ;", conDatabase)
                Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
                sda.SelectCommand = cmdDatabase
                Dim dbDataset As DataTable = New DataTable()
                sda.Fill(dbDataset)
                Dim bSource As BindingSource = New BindingSource()
                bSource.DataSource = dbDataset
                staff_dgv.DataSource = bSource
                sda.Update(dbDataset)

                Dim i As Integer
                i = staff_dgv.CurrentRow.Index
                txt_staffid.Text = staff_dgv.Item(0, i).Value
                txt_staffname.Text = staff_dgv.Item(1, i).Value
                cmb_gender.Text = staff_dgv.Item(2, i).Value
                txt_stafftel.Text = staff_dgv.Item(3, i).Value

                conDatabase.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If (txt_staffid.Text = "" Or txt_staffname.Text = "" Or txt_stafftel.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("DELETE RECORD?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from coinworth.stafftable  where staffid='" & txt_staffid.Text & "' ", mycon)
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