Public Class Calories
    Public Property Fat As Integer
    Public Property Protein As Integer
    Public Property Carbs As Integer
    Public Property TotalCalories As Integer
    Public Sub New()

    End Sub
    Public Sub New(InProtein As Integer,
                   InFat As Integer,
                   InCarbs As Integer)
        'overloaded constructor
        'set properties
        Fat = InFat
        Protein = InProtein
        Carbs = InCarbs
        'compute our calories
        TotalCalories = (Fat * 9) + (Carbs * 4) + (Protein * 4)




    End Sub





End Class
