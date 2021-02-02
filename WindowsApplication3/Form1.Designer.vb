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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OdometerText = New System.Windows.Forms.TextBox()
        Me.EndOdomterText = New System.Windows.Forms.TextBox()
        Me.DaysText = New System.Windows.Forms.TextBox()
        Me.MilesText = New System.Windows.Forms.TextBox()
        Me.ChargeText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Beginning Odometer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ending Odometer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number of Days:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Enter Rental Information"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(265, 207)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(346, 207)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(427, 207)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Totals"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Miles Driven:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Charge:"
        '
        'OdometerText
        '
        Me.OdometerText.Location = New System.Drawing.Point(107, 47)
        Me.OdometerText.Name = "OdometerText"
        Me.OdometerText.Size = New System.Drawing.Size(100, 20)
        Me.OdometerText.TabIndex = 10
        '
        'EndOdomterText
        '
        Me.EndOdomterText.Location = New System.Drawing.Point(107, 87)
        Me.EndOdomterText.Name = "EndOdomterText"
        Me.EndOdomterText.Size = New System.Drawing.Size(100, 20)
        Me.EndOdomterText.TabIndex = 11
        '
        'DaysText
        '
        Me.DaysText.Location = New System.Drawing.Point(107, 128)
        Me.DaysText.Name = "DaysText"
        Me.DaysText.Size = New System.Drawing.Size(100, 20)
        Me.DaysText.TabIndex = 12
        '
        'MilesText
        '
        Me.MilesText.Location = New System.Drawing.Point(346, 74)
        Me.MilesText.Name = "MilesText"
        Me.MilesText.Size = New System.Drawing.Size(100, 20)
        Me.MilesText.TabIndex = 13
        '
        'ChargeText
        '
        Me.ChargeText.Location = New System.Drawing.Point(349, 152)
        Me.ChargeText.Name = "ChargeText"
        Me.ChargeText.Size = New System.Drawing.Size(100, 20)
        Me.ChargeText.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 261)
        Me.Controls.Add(Me.ChargeText)
        Me.Controls.Add(Me.MilesText)
        Me.Controls.Add(Me.DaysText)
        Me.Controls.Add(Me.EndOdomterText)
        Me.Controls.Add(Me.OdometerText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "Form1"
        Me.Text = "Rental Charges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents OdometerText As TextBox
    Friend WithEvents EndOdomterText As TextBox
    Friend WithEvents DaysText As TextBox
    Friend WithEvents MilesText As TextBox
    Friend WithEvents ChargeText As TextBox
End Class
