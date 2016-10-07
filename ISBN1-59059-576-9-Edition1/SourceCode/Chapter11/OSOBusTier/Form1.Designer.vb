<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnLogin = New System.Windows.Forms.Button
        Me.btnGetProducts = New System.Windows.Forms.Button
        Me.dgvCategories = New System.Windows.Forms.DataGridView
        Me.dgvProducts = New System.Windows.Forms.DataGridView
        Me.bsCategories = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(100, 9)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(100, 48)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(227, 9)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(81, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        '
        'btnGetProducts
        '
        Me.btnGetProducts.Location = New System.Drawing.Point(227, 46)
        Me.btnGetProducts.Name = "btnGetProducts"
        Me.btnGetProducts.Size = New System.Drawing.Size(81, 23)
        Me.btnGetProducts.TabIndex = 5
        Me.btnGetProducts.Text = "Get Products"
        '
        'dgvCategories
        '
        Me.dgvCategories.Location = New System.Drawing.Point(31, 84)
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.Size = New System.Drawing.Size(351, 85)
        Me.dgvCategories.TabIndex = 6
        Me.dgvCategories.Text = "DataGridView1"
        '
        'dgvProducts
        '
        Me.dgvProducts.Location = New System.Drawing.Point(31, 195)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(351, 150)
        Me.dgvProducts.TabIndex = 7
        Me.dgvProducts.Text = "DataGridView1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(325, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 357)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.dgvCategories)
        Me.Controls.Add(Me.btnGetProducts)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnGetProducts As System.Windows.Forms.Button
    Friend WithEvents dgvCategories As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents bsCategories As System.Windows.Forms.BindingSource
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
