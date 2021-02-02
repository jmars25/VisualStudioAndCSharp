'Joseph Marsico
'4/25/2019
Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim TotalCalories As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ErrorLabel.Text = ""

        TotalCalories = Convert.ToInt64(TotalHiddenField.Value)

    End Sub




    Protected Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim TheCalories As Calories
        Try
            'create new object using overloaded constructor
            TheCalories = New Calories(Integer.Parse(FatTextBox.Text),
                                       Integer.Parse(CarbsTextBox.Text),
                                       Convert.ToInt32(ProteinTextBox.Text))

            'output the results
            CaloriesTextBox.Text = TheCalories.TotalCalories.ToString()

            TotalCalories += TheCalories.TotalCalories


            'store new total
            TotalHiddenField.Value = TotalCalories.ToString




        Catch ex As Exception
            ErrorLabel.Text = "you must enter a valid numeric Price"
        End Try
        'display Total
        TotalLabel.Text = "total Calories" & TotalCalories.ToString()


    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear the forms
        FatTextBox.Text = ""
        ProteinTextBox.Text = ""
        CarbsTextBox.Text = ""
        CaloriesTextBox.Text = ""

    End Sub


End Class