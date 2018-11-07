Imports MySql.Data.MySqlClient

Public Class Assistant

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If (txt_id.Text = "" Or txt_name.Text = "" Or txt_tel.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.assistanttable(assistantid,assistantname,contact,starttime,day) values('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_tel.Text & "','" & dtp_start.Text & "','" & dtp_day.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("ASSISTANT ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mycon.Close()
                txt_id.Text = ""
                txt_name.Text = ""
                txt_tel.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If (txt_id.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE ADD AN ID NUMBER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim msgRslt As MsgBoxResult = MessageBox.Show("CHANGE CONTACT DETAILS?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgRslt = MsgBoxResult.Yes Then
                Try
                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update  coinworth.assistanttable set endtime='" & dtp_end.Text & "' where assistantid='" & txt_id.Text & "'", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()
                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show(" DETAILS UPDATED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        End If
    End Sub

End Class