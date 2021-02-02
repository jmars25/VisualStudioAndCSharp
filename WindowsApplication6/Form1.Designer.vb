<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Balcony = New System.Windows.Forms.RadioButton()
        Me.General = New System.Windows.Forms.RadioButton()
        Me.Mezzanine = New System.Windows.Forms.RadioButton()
        Me.Orchestra = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AmountDue = New System.Windows.Forms.TextBox()
        Me.Summary = New System.Windows.Forms.TextBox()
        Me.Labelsale = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concert Ticket Sales"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Balcony)
        Me.GroupBox1.Controls.Add(Me.General)
        Me.GroupBox1.Controls.Add(Me.Mezzanine)
        Me.GroupBox1.Controls.Add(Me.Orchestra)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 153)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select section and Number of tickets"
        '
        'Balcony
        '
        Me.Balcony.AutoSize = True
        Me.Balcony.Location = New System.Drawing.Point(0, 107)
        Me.Balcony.Name = "Balcony"
        Me.Balcony.Size = New System.Drawing.Size(63, 17)
        Me.Balcony.TabIndex = 9
        Me.Balcony.TabStop = True
        Me.Balcony.Text = "Balcony"
        Me.Balcony.UseVisualStyleBackColor = True
        '
        'General
        '
        Me.General.AutoSize = True
        Me.General.Location = New System.Drawing.Point(0, 84)
        Me.General.Name = "General"
        Me.General.Size = New System.Drawing.Size(62, 17)
        Me.General.TabIndex = 8
        Me.General.TabStop = True
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'Mezzanine
        '
        Me.Mezzanine.AutoSize = True
        Me.Mezzanine.Location = New System.Drawing.Point(0, 61)
        Me.Mezzanine.Name = "Mezzanine"
        Me.Mezzanine.Size = New System.Drawing.Size(76, 17)
        Me.Mezzanine.TabIndex = 7
        Me.Mezzanine.TabStop = True
        Me.Mezzanine.Text = "Mezzanine"
        Me.Mezzanine.UseVisualStyleBackColor = True
        '
        'Orchestra
        '
        Me.Orchestra.AutoSize = True
        Me.Orchestra.Location = New System.Drawing.Point(0, 41)
        Me.Orchestra.Name = "Orchestra"
        Me.Orchestra.Size = New System.Drawing.Size(71, 17)
        Me.Orchestra.TabIndex = 6
        Me.Orchestra.TabStop = True
        Me.Orchestra.Text = "Orchestra"
        Me.Orchestra.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Section:"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(111, 81)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(77, 20)
        Me.NumberTextBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(223, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 38)
        Me.Label5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Amount Due:"
        '
        'AmountDue
        '
        Me.AmountDue.Location = New System.Drawing.Point(218, 167)
        Me.AmountDue.Name = "AmountDue"
        Me.AmountDue.ReadOnly = True
        Me.AmountDue.Size = New System.Drawing.Size(139, 20)
        Me.AmountDue.TabIndex = 6
        '
        'Summary
        '
        Me.Summary.Location = New System.Drawing.Point(1, 210)
        Me.Summary.Multiline = True
        Me.Summary.Name = "Summary"
        Me.Summary.ReadOnly = True
        Me.Summary.Size = New System.Drawing.Size(356, 102)
        Me.Summary.TabIndex = 7
        '
        'Labelsale
        '
        Me.Labelsale.AutoSize = True
        Me.Labelsale.Location = New System.Drawing.Point(226, 70)
        Me.Labelsale.Name = "Labelsale"
        Me.Labelsale.Size = New System.Drawing.Size(0, 13)
        Me.Labelsale.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 312)
        Me.Controls.Add(Me.Labelsale)
        Me.Controls.Add(Me.Summary)
        Me.Controls.Add(Me.AmountDue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Ticket sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Balcony As RadioButton
    Friend WithEvents General As RadioButton
    Friend WithEvents Mezzanine As RadioButton
    Friend WithEvents Orchestra As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AmountDue As TextBox
    Friend WithEvents Summary As TextBox
    Friend WithEvents Labelsale As Label
End Class
