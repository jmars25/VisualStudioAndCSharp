'Joseph Marsico
'Feb 27, 2019

Public Class Form1
    'constant for coffee and sales tax
    Const CAPPUCCINO As Decimal = 3.5
    Const ESPRESSO As Decimal = 3
    Const LATTE As Decimal = 2.25
    Const ICED As Decimal = 2.75
    Const SALES_TAX As Decimal = 0.0725

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        'variable declerations
        Dim QuantityInteger As Integer
        Dim TotalPrice As Decimal

        Try
            'converts string to integer

            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            'Makes sure User entered a number
        Catch Exception As FormatException
            MessageBox.Show("You must enter a number.",
                "Data Entry Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)

            QuantityTextBox.Focus()
            QuantityTextBox.SelectAll()

        End Try

        'makes sure you are putting a number greater then 0
        If QuantityInteger < 1 Then
            MessageBox.Show("you must enter number greater then zero")



        Else
            'sees which radio button if any you selected then multiplys the price of selected times the number you put for the quantity
            If CappuccinoRadioButton.Checked Or EspressoRadioButton.Checked Or LatteRadioButton.Checked Or IcedCappuccinoRadioButton.Checked Or IcedLatteRadioButton.Checked Then

                If CappuccinoRadioButton.Checked = True Then

                    TotalPrice = CAPPUCCINO * QuantityInteger

                ElseIf EspressoRadioButton.Checked = True Then
                    TotalPrice = ESPRESSO * QuantityInteger

                ElseIf LatteRadioButton.Checked = True Then
                    TotalPrice = LATTE * QuantityInteger

                ElseIf IcedCappuccinoRadioButton.Checked = True Then
                    TotalPrice = ICED * QuantityInteger

                ElseIf IcedLatteRadioButton.Checked = True Then
                    TotalPrice = ICED * QuantityInteger




                End If

            Else
                ' no coffee selected
                MessageBox.Show("please select at least one service")

            End If
            'calculates the sales tax if takeout is selected
            If TakeoutCheck.Checked = True Then
                TotalPrice = TotalPrice + (TotalPrice * SALES_TAX)
            End If
            'displays the cost of coffee
            ItemAmountTextBox.Text = TotalPrice.ToString("C")
        End If
    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged

    End Sub

    Private Sub CappuccinoCheck_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes the application
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ItemAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles ItemAmountTextBox.TextChanged

    End Sub
End Class
