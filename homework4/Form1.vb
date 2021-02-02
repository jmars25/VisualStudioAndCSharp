
Public Class Form1
    'class level variables
    Public Sales As Decimal
    Dim AmountPaid
    Private SalesPerson As New SalesPerson()
    Dim SaleAmount
    Dim nametxt


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'about button dialog
        MessageBox.Show("Programmer: Joseph Marsico.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)



    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'clears text box and focuses on name
        NameBox.Clear()
        SalesBox.Clear()

        NameBox.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes app
        Close()
    End Sub

    Private Sub PauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauToolStripMenuItem.Click

        'checks if names box is empty (when i tried to add icons the programm would crash i dont know why)  
        If NameBox.Text = "" Then
            MessageBox.Show("Empty TextBox", "No entry")


        Else
            'if namebox wasnt empty then moved on to try catch to see if sales was a valid number
            Try


                SaleAmount = Convert.ToDecimal(SalesBox.Text)



                ' passes salesbox to constructor for use in salesperson class
                If SalesBox.Text = "" Then
                    Dim ob As New SalesPerson
                Else

                    Dim ob As New SalesPerson(SalesBox.Text)
                End If



            Catch ex As FormatException
                MessageBox.Show("You must enter a valid amount!")
            End Try

            'displays sales and pay
            CommisionBox.Text = SalesPerson.Commisionagain
            PaidBox.Text = SalesPerson.payagain

        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        'gives a summary of total sales, commision, and pay
        MessageBox.Show("Total Sales:" & SalesPerson.SalesCount & vbNewLine & "Total Commisions:" & SalesPerson.CommisionCount & vbNewLine & "Total Pay:" & SalesPerson.PayCount)
    End Sub


End Class
