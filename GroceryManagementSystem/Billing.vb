Imports MySql.Data.MySqlClient
Imports System.Data.DataTable

Public Class Billing
    Public Property cashiersid As String

    Dim tablebill As New DataTable("tablebill")
    Dim rand As New Random()

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loading datagridview with columns
        tablebill.Columns.Add("PRODUCT", Type.GetType("System.String"))
        tablebill.Columns.Add("QUANTITY", Type.GetType("System.Int32"))
        tablebill.Columns.Add("PRICE", Type.GetType("System.Int32"))
        tablebill.Columns.Add("SUB TOTAL", Type.GetType("System.Int32"))
        tablebill.Columns.Add("DISCOUNT", Type.GetType("System.Int32"))
        tablebill.Columns.Add("PRODUCT TOTAL", Type.GetType("System.Int32"))
        tablebill.Columns.Add("TAX", Type.GetType("System.Int32"))
        bill_dgv.DataSource = tablebill

        txt_cashier.Text = cashiersid
        cmb_discount.Text = "0"
        cmb_tax.Text = "5.00"
        cmb_paytype.Text = "CASH"
        txt_payeeamount.Text = "0"
        txt_payeebalance.Text = "0"
        txt_totalpay.Text = "0"
        txt_totaltax.Text = "0"
        txt_totqnty.Text = "0"

        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select productname from  coinworth.productstable;", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As New DataTable("coinworth.productstable")
            sda.Fill(dbDataset)

            If dbDataset.Rows.Count > 0 Then
                cmb_prdctname.DataSource = dbDataset
                cmb_prdctname.DisplayMember = "productname" 'What is displayed
            End If
            conDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'creating random reciept number
        txt_recieptno.Text = rand.Next(12345, 98765).ToString

    End Sub

    Private Sub cmb_prdctname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prdctname.SelectedIndexChanged
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from  coinworth.productstable where productname='" & cmb_prdctname.Text & "' ;", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            pd_dgv.DataSource = bSource
            sda.Update(dbDataset)

            Dim i As Integer
            i = pd_dgv.CurrentRow.Index
            Me.txt_priceforeach.Text = pd_dgv.Item(2, i).Value

            conDatabase.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_items_TextChanged(sender As Object, e As EventArgs) Handles txt_items.TextChanged
        Dim subtotal As Integer
        Dim itemcount As Integer
        Dim price As Integer

        itemcount = Val(txt_items.Text)
        price = Val(txt_priceforeach.Text)

        subtotal = itemcount * price

        txt_itemstotalprice.Text = subtotal.ToString
        txt_prdctcount.Text = subtotal.ToString
    End Sub

    Private Sub cmb_discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_discount.SelectedIndexChanged
        Dim subtotal As Integer
        subtotal = Val(txt_itemstotalprice.Text)
        Dim dis As Integer
        dis = Val(cmb_discount.SelectedItem)
        Dim prdctcnt As Integer
        Dim actual As Integer
        actual = ((dis / 100) * subtotal)
        prdctcnt = subtotal - actual
        txt_prdctcount.Text = prdctcnt.ToString


        If dis = 0 Then
            cmb_tax.Text = "5.0"
        ElseIf dis <= 5 Then
            cmb_tax.Text = "10.0"
        ElseIf dis <= 15 Then
            cmb_tax.Text = "20.0"
        End If
    End Sub

    Private Sub btn_addproduct_Click(sender As Object, e As EventArgs) Handles btn_addproduct.Click
        Dim name As String
        Dim qnty As Integer
        Dim price As Integer
        Dim sbtl As Integer
        Dim disct As Integer
        Dim total As Integer
        Dim tax As Integer

        name = cmb_prdctname.Text
        qnty = Val(txt_items.Text)
        price = Val(txt_priceforeach.Text)
        sbtl = Val(txt_itemstotalprice.Text)
        disct = Val(cmb_discount.Text)
        total = Val(txt_prdctcount.Text)
        tax = Val(cmb_tax.Text)

        tablebill.Rows.Add(name, qnty, price, sbtl, disct, total, tax)
        bill_dgv.DataSource = tablebill
    End Sub


    Private Sub btn_total_Click(sender As Object, e As EventArgs) Handles btn_total.Click
        If bill_dgv.RowCount > 1 Then
            Dim tot As Integer = 0
            Dim tx As Integer = 0
            Dim gds As Integer

            For index As Integer = 0 To bill_dgv.RowCount - 1
                tot += Convert.ToInt32(bill_dgv.Rows(index).Cells(5).Value)
                tx += Convert.ToInt32(bill_dgv.Rows(index).Cells(6).Value)
                gds += Convert.ToInt32(bill_dgv.Rows(index).Cells(1).Value)
            Next
            txt_totalpay.Text = tot.ToString
            txt_totaltax.Text = tx.ToString
            txt_totqnty.Text = gds.ToString
        End If
    End Sub

    Private Sub txt_payeeamount_TextChanged(sender As Object, e As EventArgs) Handles txt_payeeamount.TextChanged
        Dim cash As Integer
        Dim total As Integer
        Dim bal As Integer

        cash = Val(txt_payeeamount.Text)
        total = Val(txt_totalpay.Text)

        bal = cash - total

        txt_payeebalance.Text = bal.ToString
    End Sub

    Private Sub ViewStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStockToolStripMenuItem.Click
        InvetoryView.Show()
    End Sub

    Private Sub ContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsToolStripMenuItem.Click
        ManagerContacts.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Assistant.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Logoutform.Show()
    End Sub

    Private Sub btn_newbill_Click(sender As Object, e As EventArgs) Handles btn_newbill.Click
        Me.Hide()
        Me.Show()
        tablebill.Rows.Clear()
        txt_recieptno.Text = rand.Next(12345, 98765).ToString

        cmb_discount.Text = "0"
        cmb_tax.Text = "0.00"
        cmb_paytype.Text = "CASH"
        txt_payeeamount.Text = "0"
        txt_payeebalance.Text = "0"
        txt_totalpay.Text = "0"
        txt_totaltax.Text = "0"
        txt_totqnty.Text = "0"
        txt_items.Text = "0"
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If bill_dgv.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            bill_dgv.Rows.Remove(bill_dgv.SelectedRows(0))
        Else
            MessageBox.Show("Select a row before you hit Delete")
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim prnt As New Printing
        prnt.receiptno = txt_recieptno.Text
        prnt.recieptdate = dtp_reciept.Text

        'getting product details one
        prnt.product1 = bill_dgv.Rows(0).Cells(0).Value
        prnt.qnty1 = bill_dgv.Rows(0).Cells(1).Value
        prnt.price1 = bill_dgv.Rows(0).Cells(5).Value
        prnt.unit1 = bill_dgv.Rows(0).Cells(2).Value

        'getting product details two
        prnt.product2 = bill_dgv.Rows(1).Cells(0).Value
        prnt.qnty2 = bill_dgv.Rows(1).Cells(1).Value
        prnt.price2 = bill_dgv.Rows(1).Cells(5).Value
        prnt.unit2 = bill_dgv.Rows(1).Cells(2).Value

        'getting product details three
        prnt.product3 = bill_dgv.Rows(2).Cells(0).Value
        prnt.qnty3 = bill_dgv.Rows(2).Cells(1).Value
        prnt.price3 = bill_dgv.Rows(2).Cells(5).Value
        prnt.unit3 = bill_dgv.Rows(2).Cells(2).Value

        'getting product details four
        prnt.product4 = bill_dgv.Rows(3).Cells(0).Value
        prnt.qnty4 = bill_dgv.Rows(3).Cells(1).Value
        prnt.price4 = bill_dgv.Rows(3).Cells(5).Value
        prnt.unit4 = bill_dgv.Rows(3).Cells(2).Value

        'getting product details five
        prnt.product5 = bill_dgv.Rows(4).Cells(0).Value
        prnt.qnty5 = bill_dgv.Rows(4).Cells(1).Value
        prnt.price5 = bill_dgv.Rows(4).Cells(5).Value
        prnt.unit5 = bill_dgv.Rows(4).Cells(2).Value

        'geting total money paid
        prnt.cashierid = txt_cashier.Text
        prnt.totalqnty = txt_totqnty.Text
        prnt.amountpaid = txt_payeeamount.Text
        prnt.balance = txt_payeebalance.Text
        prnt.taxes = txt_totaltax.Text
        prnt.amounttopay = txt_totalpay.Text






        prnt.Show()
    End Sub

    'Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
    '    Try
    '        Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
    '        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
    '        Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into coinworth.billingtable(recieptNumber,producttotal,totalprice,amountpaid,date) values('" & txt_recieptno.Text & "','" & txt_totqnty.Text & "','" & txt_totalpay.Text & "','" & txt_payeeamount.Text & "','" & dtp_reciept.Text & "',) ", mycon)
    '        Dim myReader As MySqlDataReader
    '        mycon.Open()
    '        myReader = SelectCommand.ExecuteReader()
    '        MessageBox.Show("RECIEPT ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        mycon.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub txt_recieptno_TextChanged(sender As Object, e As EventArgs) Handles txt_recieptno.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class