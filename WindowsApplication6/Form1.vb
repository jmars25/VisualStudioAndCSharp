Public Class Form1
    'constants and class level variables declared
    Const BALCONY_CONST As Decimal = 15
    Const ORCHESTRA_CONST As Decimal = 75
    Const GENERAL_CONST As Decimal = 25
    Const MEZZANINE_CONST As Decimal = 50
    Dim TicketPricesArray As Decimal() = New Decimal(3) {ORCHESTRA_CONST, MEZZANINE_CONST, GENERAL_CONST, BALCONY_CONST}
    Dim TotalInteger(3) As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SalesAmount As Integer
        Dim SalePrice As Decimal
        Dim TicketPrice As Decimal

        Try

            'convert sale amount to int
            SalesAmount = Convert.ToInt32(NumberTextBox.Text)

            'checks that valid number is entered
        Catch ex As FormatException
            MessageBox.Show("you must enter a valid amount.",
                        "Data Enty Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation)


        End Try
        'makes sure your number entered is above zero
        If SalesAmount < 1 Then
            MessageBox.Show("you must enter a number greater then zero.",
                        "Data Enty Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation)

        Else
            'if radio button is checked adds sale amount to total integer array 
            If Balcony.Checked Or Orchestra.Checked Or Mezzanine.Checked Or General.Checked Then



                If Orchestra.Checked Then
                    TicketPrice = TicketPricesArray(0)
                    TotalInteger(0) = TotalInteger(0) + SalesAmount
                ElseIf Mezzanine.Checked Then
                    TicketPrice = TicketPricesArray(1)
                    TotalInteger(1) = TotalInteger(1) + SalesAmount
                ElseIf General.Checked Then
                    TicketPrice = TicketPricesArray(2)
                    TotalInteger(2) = TotalInteger(2) + SalesAmount
                ElseIf Balcony.Checked Then
                    TicketPrice = TicketPricesArray(3)
                    TotalInteger(3) = TotalInteger(3) + SalesAmount

                End If
                'if no items are selected sends an error message
            Else
                MessageBox.Show("please enter a section",
                        "selection error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation)

            End If



        End If
        'computes sale price
        SalePrice = SalesAmount * TicketPrice
        'converts to currency
        AmountDue.Text = SalePrice.ToString("C")
        'displays info on sale label
        Labelsale.Text = "purchased  " + SalesAmount.ToString() + " ticket(s) at " + ControlChars.NewLine + TicketPrice.ToString() + "$ per ticket  "

        'runs subroutine
        UpdateValues()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NumberTextBox.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Sub UpdateValues()
        'declare section array
        Dim sections(3) As String
        sections(0) = "Orchestra"
        sections(1) = "Mezzanine"
        sections(2) = "General"
        sections(3) = "Balcony"


        'runs loop to output the summary of what was purchased
        Dim Results As String = "Section:" & vbTab & vbTab & "#Tickets" & vbTab & vbTab & "Total"

        For counter As Integer = 0 To TotalInteger.Length - 1
            Results = Results + vbCrLf & sections(counter) & vbTab & vbTab & TotalInteger(counter) & vbTab & vbTab & "$" & TotalInteger(counter) * TicketPricesArray(counter)
        Next
        Summary.Text = Results


    End Sub

    Private Sub Summary_TextChanged(sender As Object, e As EventArgs) Handles Summary.TextChanged

    End Sub
End Class
