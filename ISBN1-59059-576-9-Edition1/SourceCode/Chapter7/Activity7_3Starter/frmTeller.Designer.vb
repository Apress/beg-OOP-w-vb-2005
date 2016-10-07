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
        Me.btnAccountInfo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAccountInfo
        '
        Me.btnAccountInfo.Location = New System.Drawing.Point(73, 39)
        Me.btnAccountInfo.Name = "btnAccountInfo"
        Me.btnAccountInfo.Size = New System.Drawing.Size(88, 32)
        Me.btnAccountInfo.TabIndex = 1
        Me.btnAccountInfo.Text = "Account Info"
        '
        'frmTeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 111)
        Me.Controls.Add(Me.btnAccountInfo)
        Me.Name = "frmTeller"
        Me.Text = "frmTeller"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAccountInfo As System.Windows.Forms.Button
End Class
