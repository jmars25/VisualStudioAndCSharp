Public Class SalesPerson
    'class variables and const
    Public Const COMMISION_RATE = 0.15
    Public Const BASE_SALARY = 250
    Public Const QUOTA = 1000

    Private Shared Pay As Decimal
    Private Shared Commision As Decimal
    Public Names As String
    Private Sales As Decimal
    Private Shared TotalSales As Decimal
    Private Shared TotalCommision As Decimal
    Private Shared TotalPay As Decimal

    'defualt constructor
    Public Sub New()

    End Sub
    'overloaded constructor
    Public Sub New(ByVal sell As Decimal)



        Sales = sell

        AddTotals()
    End Sub


    'func calcs commision
    Function CalcCommision()
        If Sales > QUOTA Then
            Commision = Sales * COMMISION_RATE
        Else Commision = 0


        End If
        Return Commision
    End Function

    'func calcs pay
    Function ReturnPay()
        Pay = BASE_SALARY + CalcCommision()
        Return Pay
    End Function

    'method to find totals of sales, commision, pay
    Sub AddTotals()
        TotalSales = TotalSales + Sales
        TotalCommision = TotalCommision + CalcCommision()
        TotalPay = TotalPay + ReturnPay()
    End Sub

    'read only variables
    Shared ReadOnly Property SalesCount() As Decimal
        Get
            Return TotalSales
        End Get
    End Property

    Shared ReadOnly Property CommisionCount() As Decimal
        Get
            Return TotalCommision
        End Get
    End Property

    Shared ReadOnly Property PayCount() As Decimal
        Get
            Return TotalPay
        End Get
    End Property

    Shared ReadOnly Property Commisionagain() As Decimal
        Get
            Return Commision
        End Get
    End Property

    Shared ReadOnly Property payagain() As Decimal
        Get
            Return Pay
        End Get
    End Property
End Class
