Public Class List
    Public Function ListNumbers() As System.Collections.ArrayList
        Dim i As Integer
        Dim NumberList As System.Collections.ArrayList = New System.Collections.ArrayList()
        For i = 1 To 10
            NumberList.Add(i)
        Next
        Return NumberList
    End Function
End Class
