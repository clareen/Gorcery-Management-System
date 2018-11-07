Imports MySql.Data.MySqlClient

Public Class InvetoryAdd

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (txt_prdctid.Text = "" Or txt_pname.Text = "" Or txt_pprice.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.productstable(productid,productname,productprice) values('" & txt_prdctid.Text & "','" & txt_pname.Text & "','" & txt_pprice.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("PRODUCT ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class