Imports MySql.Data.MySqlClient

Public Class AddSupplier


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (txt_id.Text = "" Or txt_name.Text = "" Or txt_location.Text = "" Or txt_tel.Text = "" Or txt_address.Text = "" Or txt_email.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.supplierstable(id,name,location,contact,address,email) values('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_location.Text & "','" & txt_tel.Text & "','" & txt_address.Text & "','" & txt_email.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("SUPPLIER ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


End Class