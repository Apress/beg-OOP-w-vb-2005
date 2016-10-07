Public Class frmEmployeeInfo
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNewEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewEmp.Click



    End Sub

    Private Sub btnExistingEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExistingEmp.Click
        Try


        Catch eException As Exception
            MsgBox(eException.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtEmpID.Text = ""
        txtEmpID.Enabled = True
        txtLoginName.Text = ""
        txtPassword.Text = ""
        txtSSN.Text = ""
        txtDepartment.Text = ""
    End Sub

    Private Sub btnUpdateSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateSI.Click

    End Sub

    Private Sub btnUpdateHR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateHR.Click

    End Sub
End Class