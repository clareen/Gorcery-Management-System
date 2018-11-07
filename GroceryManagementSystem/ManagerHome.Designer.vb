<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerHome))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSupplierDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvetoryStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Indigo
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntryToolStripMenuItem, Me.RegistrationToolStripMenuItem, Me.SuppliersToolStripMenuItem, Me.InvetoryStocksToolStripMenuItem, Me.PaymentsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(845, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterEntryToolStripMenuItem
        '
        Me.MasterEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactsToolStripMenuItem, Me.CompanyInfoToolStripMenuItem})
        Me.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem"
        Me.MasterEntryToolStripMenuItem.Size = New System.Drawing.Size(124, 25)
        Me.MasterEntryToolStripMenuItem.Text = "Master Entry"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'CompanyInfoToolStripMenuItem
        '
        Me.CompanyInfoToolStripMenuItem.Name = "CompanyInfoToolStripMenuItem"
        Me.CompanyInfoToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.CompanyInfoToolStripMenuItem.Text = "Company Info"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(120, 25)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSupplierToolStripMenuItem, Me.RemoveSupplierToolStripMenuItem, Me.ViewSupplierDetailsToolStripMenuItem})
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'AddSupplierToolStripMenuItem
        '
        Me.AddSupplierToolStripMenuItem.Name = "AddSupplierToolStripMenuItem"
        Me.AddSupplierToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.AddSupplierToolStripMenuItem.Text = "Add Supplier"
        '
        'RemoveSupplierToolStripMenuItem
        '
        Me.RemoveSupplierToolStripMenuItem.Name = "RemoveSupplierToolStripMenuItem"
        Me.RemoveSupplierToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.RemoveSupplierToolStripMenuItem.Text = "Delete and Update"
        '
        'ViewSupplierDetailsToolStripMenuItem
        '
        Me.ViewSupplierDetailsToolStripMenuItem.Name = "ViewSupplierDetailsToolStripMenuItem"
        Me.ViewSupplierDetailsToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.ViewSupplierDetailsToolStripMenuItem.Text = "View Supplier Details"
        '
        'InvetoryStocksToolStripMenuItem
        '
        Me.InvetoryStocksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStockToolStripMenuItem, Me.ViewStockToolStripMenuItem})
        Me.InvetoryStocksToolStripMenuItem.Name = "InvetoryStocksToolStripMenuItem"
        Me.InvetoryStocksToolStripMenuItem.Size = New System.Drawing.Size(144, 25)
        Me.InvetoryStocksToolStripMenuItem.Text = "Invetory Stocks"
        '
        'AddStockToolStripMenuItem
        '
        Me.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem"
        Me.AddStockToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.AddStockToolStripMenuItem.Text = "Add Stock"
        '
        'ViewStockToolStripMenuItem
        '
        Me.ViewStockToolStripMenuItem.Name = "ViewStockToolStripMenuItem"
        Me.ViewStockToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ViewStockToolStripMenuItem.Text = "View Stock"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'ManagerHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 457)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ManagerHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerHome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvetoryStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSupplierDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
