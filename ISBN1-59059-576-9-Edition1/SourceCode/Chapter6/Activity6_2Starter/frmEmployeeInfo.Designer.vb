<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmEmployeeInfo
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
        Me.btnReset = New System.Windows.Forms.Button
        Me.gbHRInfo = New System.Windows.Forms.GroupBox
        Me.btnUpdateHR = New System.Windows.Forms.Button
        Me.txtSSN = New System.Windows.Forms.TextBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.lblSSN = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblEmpID = New System.Windows.Forms.Label
        Me.btnExistingEmp = New System.Windows.Forms.Button
        Me.btnNewEmp = New System.Windows.Forms.Button
        Me.gbSecurityInfo = New System.Windows.Forms.GroupBox
        Me.btnUpdateSI = New System.Windows.Forms.Button
        Me.txtLoginName = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblLoginName = New System.Windows.Forms.Label
        Me.txtEmpID = New System.Windows.Forms.TextBox
        Me.gbHRInfo.SuspendLayout()
        Me.gbSecurityInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(432, 27)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(72, 24)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset"
        '
        'gbHRInfo
        '
        Me.gbHRInfo.Controls.Add(Me.btnUpdateHR)
        Me.gbHRInfo.Controls.Add(Me.txtSSN)
        Me.gbHRInfo.Controls.Add(Me.lblDepartment)
        Me.gbHRInfo.Controls.Add(Me.txtDepartment)
        Me.gbHRInfo.Controls.Add(Me.lblSSN)
        Me.gbHRInfo.Location = New System.Drawing.Point(50, 201)
        Me.gbHRInfo.Name = "gbHRInfo"
        Me.gbHRInfo.Size = New System.Drawing.Size(384, 80)
        Me.gbHRInfo.TabIndex = 20
        Me.gbHRInfo.TabStop = False
        Me.gbHRInfo.Text = "HRInfo"
        '
        'btnUpdateHR
        '
        Me.btnUpdateHR.Location = New System.Drawing.Point(280, 32)
        Me.btnUpdateHR.Name = "btnUpdateHR"
        Me.btnUpdateHR.Size = New System.Drawing.Size(88, 24)
        Me.btnUpdateHR.TabIndex = 5
        Me.btnUpdateHR.Text = "Update"
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(80, 18)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(168, 20)
        Me.txtSSN.TabIndex = 0
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(9, 53)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(61, 13)
        Me.lblDepartment.TabIndex = 4
        Me.lblDepartment.Text = "Department:"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(80, 50)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(168, 20)
        Me.txtDepartment.TabIndex = 1
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(35, 19)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(28, 13)
        Me.lblSSN.TabIndex = 2
        Me.lblSSN.Text = "SSN:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(336, 27)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        '
        'lblEmpID
        '
        Me.lblEmpID.Location = New System.Drawing.Point(40, 43)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(72, 16)
        Me.lblEmpID.TabIndex = 17
        Me.lblEmpID.Text = "Employee ID:"
        '
        'btnExistingEmp
        '
        Me.btnExistingEmp.Location = New System.Drawing.Point(200, 75)
        Me.btnExistingEmp.Name = "btnExistingEmp"
        Me.btnExistingEmp.Size = New System.Drawing.Size(112, 23)
        Me.btnExistingEmp.TabIndex = 21
        Me.btnExistingEmp.Text = "Existing Employee"
        '
        'btnNewEmp
        '
        Me.btnNewEmp.Location = New System.Drawing.Point(88, 75)
        Me.btnNewEmp.Name = "btnNewEmp"
        Me.btnNewEmp.Size = New System.Drawing.Size(96, 23)
        Me.btnNewEmp.TabIndex = 15
        Me.btnNewEmp.Text = "New Employee"
        '
        'gbSecurityInfo
        '
        Me.gbSecurityInfo.Controls.Add(Me.btnUpdateSI)
        Me.gbSecurityInfo.Controls.Add(Me.txtLoginName)
        Me.gbSecurityInfo.Controls.Add(Me.lblPassword)
        Me.gbSecurityInfo.Controls.Add(Me.txtPassword)
        Me.gbSecurityInfo.Controls.Add(Me.lblLoginName)
        Me.gbSecurityInfo.Location = New System.Drawing.Point(48, 107)
        Me.gbSecurityInfo.Name = "gbSecurityInfo"
        Me.gbSecurityInfo.Size = New System.Drawing.Size(384, 80)
        Me.gbSecurityInfo.TabIndex = 19
        Me.gbSecurityInfo.TabStop = False
        Me.gbSecurityInfo.Text = "SecurityInfo"
        '
        'btnUpdateSI
        '
        Me.btnUpdateSI.Location = New System.Drawing.Point(280, 32)
        Me.btnUpdateSI.Name = "btnUpdateSI"
        Me.btnUpdateSI.Size = New System.Drawing.Size(88, 24)
        Me.btnUpdateSI.TabIndex = 5
        Me.btnUpdateSI.Text = "Update"
        '
        'txtLoginName
        '
        Me.txtLoginName.Location = New System.Drawing.Point(80, 18)
        Me.txtLoginName.Name = "txtLoginName"
        Me.txtLoginName.Size = New System.Drawing.Size(168, 20)
        Me.txtLoginName.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(19, 53)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(52, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(80, 50)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(168, 20)
        Me.txtPassword.TabIndex = 1
        '
        'lblLoginName
        '
        Me.lblLoginName.AutoSize = True
        Me.lblLoginName.Location = New System.Drawing.Point(8, 18)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(63, 13)
        Me.lblLoginName.TabIndex = 2
        Me.lblLoginName.Text = "Login Name:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(120, 43)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(168, 20)
        Me.txtEmpID.TabIndex = 18
        '
        'frmEmployeeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 308)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbHRInfo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.btnExistingEmp)
        Me.Controls.Add(Me.btnNewEmp)
        Me.Controls.Add(Me.gbSecurityInfo)
        Me.Controls.Add(Me.txtEmpID)
        Me.Name = "frmEmployeeInfo"
        Me.Text = "frmEmployeeInfo"
        Me.gbHRInfo.ResumeLayout(False)
        Me.gbHRInfo.PerformLayout()
        Me.gbSecurityInfo.ResumeLayout(False)
        Me.gbSecurityInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents gbHRInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateHR As System.Windows.Forms.Button
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents btnExistingEmp As System.Windows.Forms.Button
    Friend WithEvents btnNewEmp As System.Windows.Forms.Button
    Friend WithEvents gbSecurityInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateSI As System.Windows.Forms.Button
    Friend WithEvents txtLoginName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblLoginName As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
End Class
