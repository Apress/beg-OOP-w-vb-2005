Public Class Form1

    Private Sub btnLoadList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadList.Click
        Dim objList As List = New List()
        Dim NumberList As System.Collections.ArrayList = New System.Collections.ArrayList()
        Dim Item As Integer
        lstNumbers.Items.Clear()
        NumberList = objList.ListNumbers
        For Each Item In NumberList
            Debug.WriteLine(lstNumbers.Items.Count)
            lstNumbers.Items.Add(Item)
        Next
    End Sub

End Class