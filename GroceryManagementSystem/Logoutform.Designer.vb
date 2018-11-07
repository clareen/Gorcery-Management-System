<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logoutform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_prcd = New System.Windows.Forms.Button()
        Me.btn_cncl = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tk = New System.Windows.Forms.TextBox()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "END"
        '
        'btn_prcd
        '
        Me.btn_prcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prcd.Location = New System.Drawing.Point(14, 134)
        Me.btn_prcd.Name = "btn_prcd"
        Me.btn_prcd.Size = New System.Drawing.Size(91, 23)
        Me.btn_prcd.TabIndex = 6
        Me.btn_prcd.Text = "PROCEED"
        Me.btn_prcd.UseVisualStyleBackColor = True
        '
        'btn_cncl
        '
        Me.btn_cncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cncl.Location = New System.Drawing.Point(111, 134)
        Me.btn_cncl.Name = "btn_cncl"
        Me.btn_cncl.Size = New System.Drawing.Size(95, 23)
        Me.btn_cncl.TabIndex = 7
        Me.btn_cncl.Text = "CANCEL"
        Me.btn_cncl.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "TOKEN"
        '
        'txt_tk
        '
        Me.txt_tk.Location = New System.Drawing.Point(89, 26)
        Me.txt_tk.Name = "txt_tk"
        Me.txt_tk.Size = New System.Drawing.Size(103, 20)
        Me.txt_tk.TabIndex = 9
        '
        'dtp_end
        '
        Me.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_end.Location = New System.Drawing.Point(89, 78)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(103, 20)
        Me.dtp_end.TabIndex = 1
        '
        'Logoutform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(223, 181)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_tk)
        Me.Controls.Add(Me.btn_cncl)
        Me.Controls.Add(Me.btn_prcd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_end)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Logoutform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logoutform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_prcd As System.Windows.Forms.Button
    Friend WithEvents btn_cncl As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_tk As System.Windows.Forms.TextBox
    Friend WithEvents dtp_end As System.Windows.Forms.DateTimePicker
End Class
