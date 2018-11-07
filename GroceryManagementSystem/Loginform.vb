Imports MySql.Data.MySqlClient
Public Class Loginform


    Private Sub admin_exit_Click(sender As Object, e As EventArgs) Handles admin_exit.Click

        Dim msgRslt As MsgBoxResult = MessageBox.Show("Do you want to exit the program?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgRslt = MsgBoxResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub mn_exit_Click(sender As Object, e As EventArgs) Handles mn_exit.Click
        Dim msgRslt As MsgBoxResult = MessageBox.Show("Do you want to exit the program?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgRslt = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub csh_exit_Click(sender As Object, e As EventArgs) Handles csh_exit.Click
        Dim msgRslt As MsgBoxResult = MessageBox.Show("Do you want to exit the program?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgRslt = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub admin_login_Click(sender As Object, e As EventArgs) Handles admin_login.Click
        Try
            Dim myConnection As String = "datasource=localhost;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  coinworth.tableadmin where username='" & admin_username.Text & "' and password='" & admin_password.Text & "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1
            End If
            If (count = 1) Then
                MessageBox.Show("USERNAME AND PASSWORD ARE CORRECT", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                admin_password.Text = ""
                admin_username.Text = ""
                AdminHome.Show()
                Me.Hide()
            Else
                MessageBox.Show("The username or password you entered is incorrect", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub mn_login_Click(sender As Object, e As EventArgs) Handles mn_login.Click
        Try
            Dim myConnection As String = "datasource=localhost;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  coinworth.managertable where managerid='" & mn_username.Text & "' and managerpassword='" & mn_password.Text & "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1
            End If
            If (count = 1) Then
                MessageBox.Show("USERNAME AND PASSWORD ARE CORRECT", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mn_password.Text = ""
                mn_username.Text = ""
                ManagerHome.Show()
                Me.Hide()
            Else
                MessageBox.Show("The username or password you entered is incorrect", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cashiertab_Click(sender As Object, e As EventArgs) Handles cashiertab.Click

    End Sub

    Private Sub csh_login_Click(sender As Object, e As EventArgs) Handles csh_login.Click

        If (txt_token.Text = "" Or csh_userid.Text = "" Or csh_password.Text = "") Then
            'validating empty fields
            MessageBox.Show("EMPTY FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim myConnection As String = "datasource=localhost;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  coinworth.stafftable where staffid='" & csh_userid.Text & "' and password='" & csh_password.Text & "';", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                Dim count As Integer = 0
                If (myReader.HasRows()) Then
                    count = count + 1
                End If
                If (count = 1) Then
                    MessageBox.Show("USERNAME AND PASSWORD ARE CORRECT", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'setting login details for working hours
                    Try
                        Dim myConnection2 As String = "datasource=localhost;port=3306;username=root;"
                        Dim mycon2 As MySqlConnection = New MySqlConnection(myConnection2)
                        Dim SelectCommand2 As MySqlCommand = New MySqlCommand("insert into coinworth.LOGINTABLE(token,userid,logintime) values('" & txt_token.Text & "','" & csh_userid.Text & "','" & csh_dtp.Text & "') ", mycon2)
                        Dim myReader2 As MySqlDataReader
                        mycon2.Open()
                        myReader2 = SelectCommand2.ExecuteReader()
                        mycon2.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                    Dim biller As New Billing
                    biller.cashiersid = csh_userid.Text
                    biller.Show()
                    Me.Hide()
                    csh_userid.Text = ""
                    csh_password.Text = ""
                Else
                    MessageBox.Show("The username or password you entered is incorrect", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                End If
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class