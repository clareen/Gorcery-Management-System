Imports MySql.Data.MySqlClient

Public Class Logoutform

    Private Sub btn_cncl_Click(sender As Object, e As EventArgs) Handles btn_cncl.Click
        Me.Hide()
    End Sub

    Private Sub btn_prcd_Click(sender As Object, e As EventArgs) Handles btn_prcd.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.logintable set logouttime='" & dtp_end.Text & "' where token='" & txt_tk.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            ' MessageBox.Show("DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mycon.Close()
            Me.Hide()
            Billing.Hide()
            Loginform.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

End Class