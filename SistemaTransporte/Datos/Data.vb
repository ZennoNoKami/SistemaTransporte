Module Data
    Dim userID As Integer
    Public Sub UserData(ByVal id As Integer)
        userID = id
    End Sub

    Public Function RetData() As Integer
        Return userID
    End Function

End Module
