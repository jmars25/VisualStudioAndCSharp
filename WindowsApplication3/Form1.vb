'Project: Homework 1 
' Author: Joseph Marsico


Public Class Form1
    'Declare global variables
    Const Per_day_charge As Decimal = 49D
    Const Per_mile_charge As Decimal = 0.2D
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim BegOdomoter, EndOdomoter, MilesDriven, DaysAmount As Integer
        Dim TotalCharge, MilesCharge, DaysCharge As Decimal

        Try
            'Convert Odomoters to numeric variables
            BegOdomoter = Integer.Parse(OdometerText.Text)
            EndOdomoter = Integer.Parse(EndOdomterText.Text)
            DaysAmount = Integer.Parse(DaysText.Text)

            'Calculate miles driven
            MilesDriven = EndOdomoter - BegOdomoter

            'format and display Miles Driven
            MilesText.Text = MilesDriven.ToString

            'calculate the total charge for the rent

            MilesCharge = MilesDriven * Per_mile_charge
            DaysCharge = DaysAmount * Per_day_charge
            TotalCharge = MilesCharge + DaysCharge


            'format and display total charge
            ChargeText.Text = TotalCharge.ToString("C")


        Catch ex As FormatException
            'makes sure fields have numbers entered
            MessageBox.Show("Fields must be numeric", "data entry error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With OdometerText
                .Focus()
                .SelectAll()
            End With

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'exit program
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear previous amounts from the form
        EndOdomterText.Clear()
        DaysText.Clear()
        MilesText.Clear()
        ChargeText.Clear()
        With OdometerText
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub OdometerText_TextChanged(sender As Object, e As EventArgs) Handles OdometerText.TextChanged

    End Sub

    Private Sub EndOdomterText_TextChanged(sender As Object, e As EventArgs) Handles EndOdomterText.TextChanged

    End Sub

    Private Sub DaysText_TextChanged(sender As Object, e As EventArgs) Handles DaysText.TextChanged

    End Sub

    Private Sub MilesText_TextChanged(sender As Object, e As EventArgs) Handles MilesText.TextChanged

    End Sub

    Private Sub ChargeText_TextChanged(sender As Object, e As EventArgs) Handles ChargeText.TextChanged

    End Sub
End Class
