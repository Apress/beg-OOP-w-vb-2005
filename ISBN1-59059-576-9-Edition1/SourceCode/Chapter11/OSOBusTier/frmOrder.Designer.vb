<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmOrder
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnLogin = New System.Windows.Forms.Button
        Me.cboProductCategories = New System.Windows.Forms.ComboBox
        Me.ssOSO = New System.Windows.Forms.StatusStrip
        Me.ssMsg = New System.Windows.Forms.ToolStripStatusLabel
        Me.dgvProducts = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPlaceOrder = New System.Windows.Forms.Button
        Me.btnRemoveItem = New System.Windows.Forms.Button
        Me.pnlOrder = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgvOrders = New System.Windows.Forms.DataGridView
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.ssOSO.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrder.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Categories:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(365, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 24)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(271, 12)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 24)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        '
        'cboProductCategories
        '
        Me.cboProductCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductCategories.FormattingEnabled = True
        Me.cboProductCategories.Location = New System.Drawing.Point(133, 12)
        Me.cboProductCategories.Name = "cboProductCategories"
        Me.cboProductCategories.Size = New System.Drawing.Size(121, 21)
        Me.cboProductCategories.TabIndex = 8
        '
        'ssOSO
        '
        Me.ssOSO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssMsg})
        Me.ssOSO.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.ssOSO.Location = New System.Drawing.Point(0, 329)
        Me.ssOSO.Name = "ssOSO"
        Me.ssOSO.Size = New System.Drawing.Size(503, 23)
        Me.ssOSO.TabIndex = 12
        '
        'ssMsg
        '
        Me.ssMsg.Name = "ssMsg"
        Me.ssMsg.Text = "You must log in to place an order."
        '
        'dgvProducts
        '
        Me.dgvProducts.Location = New System.Drawing.Point(23, 55)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(456, 83)
        Me.dgvProducts.TabIndex = 13
        Me.dgvProducts.Text = "DataGridView1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Products"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(240, 125)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(80, 24)
        Me.btnPlaceOrder.TabIndex = 2
        Me.btnPlaceOrder.Text = "Place Order"
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(154, 125)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(80, 24)
        Me.btnRemoveItem.TabIndex = 1
        Me.btnRemoveItem.Text = "Remove Item"
        '
        'pnlOrder
        '
        Me.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrder.Controls.Add(Me.Label3)
        Me.pnlOrder.Controls.Add(Me.dgvOrders)
        Me.pnlOrder.Controls.Add(Me.btnPlaceOrder)
        Me.pnlOrder.Controls.Add(Me.btnRemoveItem)
        Me.pnlOrder.Controls.Add(Me.btnAddItem)
        Me.pnlOrder.Enabled = False
        Me.pnlOrder.Location = New System.Drawing.Point(23, 157)
        Me.pnlOrder.Name = "pnlOrder"
        Me.pnlOrder.Size = New System.Drawing.Size(456, 157)
        Me.pnlOrder.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Order Items:"
        '
        'dgvOrders
        '
        Me.dgvOrders.Location = New System.Drawing.Point(40, 16)
        Me.dgvOrders.MultiSelect = False
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrders.Size = New System.Drawing.Size(365, 103)
        Me.dgvOrders.TabIndex = 6
        Me.dgvOrders.Text = "DataGridView1"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(76, 125)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(72, 24)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "Add Item"
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 352)
        Me.Controls.Add(Me.pnlOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cboProductCategories)
        Me.Controls.Add(Me.ssOSO)
        Me.Name = "frmOrder"
        Me.Text = "Office Supply Ordering"
        Me.ssOSO.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrder.ResumeLayout(False)
        Me.pnlOrder.PerformLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents cboProductCategories As System.Windows.Forms.ComboBox
    Friend WithEvents ssOSO As System.Windows.Forms.StatusStrip
    Friend WithEvents ssMsg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents pnlOrder As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvOrders As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
End Class
