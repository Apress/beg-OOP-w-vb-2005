<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTeller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rdbInterestChecking = New System.Windows.Forms.RadioButton
        Me.btnWithdraw = New System.Windows.Forms.Button
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdbSavings = New System.Windows.Forms.RadioButton
        Me.rdbChecking = New System.Windows.Forms.RadioButton
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtAccountNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGetBalance = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'rdbInterestChecking
        '
        Me.rdbInterestChecking.Location = New System.Drawing.Point(34, 212)
        Me.rdbInterestChecking.Name = "rdbInterestChecking"
        Me.rdbInterestChecking.Size = New System.Drawing.Size(112, 16)
        Me.rdbInterestChecking.TabIndex = 20
        Me.rdbInterestChecking.Text = "InterestChecking"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(186, 196)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(88, 24)
        Me.btnWithdraw.TabIndex = 19
        Me.btnWithdraw.Text = "Withdraw"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(146, 92)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(96, 20)
        Me.txtAmount.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Amount:"
        '
        'rdbSavings
        '
        Me.rdbSavings.Location = New System.Drawing.Point(34, 188)
        Me.rdbSavings.Name = "rdbSavings"
        Me.rdbSavings.Size = New System.Drawing.Size(80, 16)
        Me.rdbSavings.TabIndex = 16
        Me.rdbSavings.Text = "Savings"
        '
        'rdbChecking
        '
        Me.rdbChecking.Location = New System.Drawing.Point(34, 164)
        Me.rdbChecking.Name = "rdbChecking"
        Me.rdbChecking.Size = New System.Drawing.Size(80, 16)
        Me.rdbChecking.TabIndex = 15
        Me.rdbChecking.Text = "Checking"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(146, 68)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(96, 20)
        Me.txtBalance.TabIndex = 14
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(146, 44)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(96, 20)
        Me.txtAccountNumber.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Balance:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Account Number:"
        '
        'btnGetBalance
        '
        Me.btnGetBalance.Location = New System.Drawing.Point(186, 164)
        Me.btnGetBalance.Name = "btnGetBalance"
        Me.btnGetBalance.Size = New System.Drawing.Size(88, 24)
        Me.btnGetBalance.TabIndex = 10
        Me.btnGetBalance.Text = "Get Balance"
        '
        'frmTeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.rdbInterestChecking)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdbSavings)
        Me.Controls.Add(Me.rdbChecking)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGetBalance)
        Me.Name = "frmTeller"
        Me.Text = "frmTeller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbInterestChecking As System.Windows.Forms.RadioButton
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdbSavings As System.Windows.Forms.RadioButton
    Friend WithEvents rdbChecking As System.Windows.Forms.RadioButton
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGetBalance As System.Windows.Forms.Button
End Class
