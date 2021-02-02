<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutCheck = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(99, 172)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ItemAmountTextBox.TabIndex = 31
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(73, 38)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 30
        '
        'TakeoutCheck
        '
        Me.TakeoutCheck.AutoSize = True
        Me.TakeoutCheck.Location = New System.Drawing.Point(30, 77)
        Me.TakeoutCheck.Name = "TakeoutCheck"
        Me.TakeoutCheck.Size = New System.Drawing.Size(72, 17)
        Me.TakeoutCheck.TabIndex = 28
        Me.TakeoutCheck.Text = "Takeout?"
        Me.TakeoutCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Item Amount:"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(126, 109)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(86, 46)
        Me.ExitButton.TabIndex = 26
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(24, 109)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(87, 46)
        Me.CalcButton.TabIndex = 25
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Quantity:"
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(33, 26)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.CappuccinoRadioButton.TabIndex = 32
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "Cappuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(33, 50)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.EspressoRadioButton.TabIndex = 33
        Me.EspressoRadioButton.TabStop = True
        Me.EspressoRadioButton.Text = "Espresso"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(33, 74)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.LatteRadioButton.TabIndex = 34
        Me.LatteRadioButton.TabStop = True
        Me.LatteRadioButton.Text = "Latte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(33, 98)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.IcedLatteRadioButton.TabIndex = 35
        Me.IcedLatteRadioButton.TabStop = True
        Me.IcedLatteRadioButton.Text = "Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(33, 123)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.IcedCappuccinoRadioButton.TabIndex = 36
        Me.IcedCappuccinoRadioButton.TabStop = True
        Me.IcedCappuccinoRadioButton.Text = "Iced Cappuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.GroupBox1.Controls.Add(Me.IcedLatteRadioButton)
        Me.GroupBox1.Controls.Add(Me.LatteRadioButton)
        Me.GroupBox1.Controls.Add(Me.EspressoRadioButton)
        Me.GroupBox1.Controls.Add(Me.CappuccinoRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(345, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 188)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coffee variety"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.ItemAmountTextBox)
        Me.GroupBox2.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox2.Controls.Add(Me.TakeoutCheck)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ExitButton)
        Me.GroupBox2.Controls.Add(Me.CalcButton)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(509, 243)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Information"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Coffee Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ItemAmountTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents TakeoutCheck As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalcButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CappuccinoRadioButton As RadioButton
    Friend WithEvents EspressoRadioButton As RadioButton
    Friend WithEvents LatteRadioButton As RadioButton
    Friend WithEvents IcedLatteRadioButton As RadioButton
    Friend WithEvents IcedCappuccinoRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
