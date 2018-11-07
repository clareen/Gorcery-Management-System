Public Class Printing

    Public Property receiptno As String
    Public Property recieptdate As String
    'getting products
    Public Property product1 As String
    Public Property product2 As String
    Public Property product3 As String
    Public Property product4 As String
    Public Property product5 As String
    'getting prices
    Public Property price1 As String
    Public Property price2 As String
    Public Property price3 As String
    Public Property price4 As String
    Public Property price5 As String
    'getting quantity
    Public Property qnty1 As String
    Public Property qnty2 As String
    Public Property qnty3 As String
    Public Property qnty4 As String
    Public Property qnty5 As String
    'getting unit price
    Public Property unit1 As String
    Public Property unit2 As String
    Public Property unit3 As String
    Public Property unit4 As String
    Public Property unit5 As String

    'getting money details
    Public Property cashierid As String
    Public Property totalqnty As String
    Public Property taxes As String
    Public Property amounttopay As String
    Public Property amountpaid As String
    Public Property balance As String

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintDocument1.Print()
    End Sub

    Private Sub btn_preview_Click(sender As Object, e As EventArgs) Handles btn_preview.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Courier New", 16, FontStyle.Regular)
        e.Graphics.DrawString(txt_reciept.Text, font, Brushes.Black, 100, 100)
    End Sub

    Private Sub Printing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_reciept.Text = "            COIN WORTH GROCERY STORE" & _
                           "" & Environment.NewLine & "" & _
                           "                QUALITY MATTERS" & _
                           "" & Environment.NewLine & "" & _
                           "" & Environment.NewLine & "" & _
                           "      Reciept No:               " & receiptno & "" & _
                           "" & Environment.NewLine & "" & _
                           "" & Environment.NewLine & "" & _
                            "      Date:                     " & recieptdate & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & Environment.NewLine & "" & _
                            "      CASHIER ID:              " & cashierid & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & Environment.NewLine & "" & _
                            "ITEM" & " -- " & "QUANTITY" & " -- " & "UNIT PRICE" & " -- " & "TOTAL AMOUNT" & _
                            "" & Environment.NewLine & "" & _
                            "" & product1 & "  ...   " & qnty1 & "   ...    " & unit1 & "    ...   " & price1 & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & product2 & "  ...   " & qnty2 & "   ...    " & unit2 & "    ...   " & price2 & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & product3 & "  ...   " & qnty3 & "   ...    " & unit3 & "    ...   " & price3 & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & product4 & "  ...   " & qnty4 & "   ...    " & unit4 & "    ...   " & price4 & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & product5 & "  ...   " & qnty5 & "   ...    " & unit5 & "    ...   " & price5 & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & Environment.NewLine & "" & _
                            "TOTAL ITEMS BOUGHT:                    " & totalqnty & "" & _
                            "" & Environment.NewLine & "" & _
                            "TOTAL TAXES:                           " & taxes & "" & _
                            "" & Environment.NewLine & "" & _
                            "TOTAL AMOUNT TO PAY:                   " & amounttopay & "" & _
                            "" & Environment.NewLine & "" & _
                            "AMOUNT PAID:                           " & amountpaid & "" & _
                            "" & Environment.NewLine & "" & _
                            "BALANCE:                               " & balance & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & Environment.NewLine & "" & _
                            "" & Environment.NewLine & "" & _
                            "        WE ARE THANKFULL FOR YOUR SUPPORT" & _
                            "" & Environment.NewLine & "" & _
                            "                PLEASE COME AGAIN"
    End Sub
End Class