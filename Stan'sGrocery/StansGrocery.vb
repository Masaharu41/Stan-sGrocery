'Owen Fujii
'RCET 2265
'Spring 2024
'Stan's Grocery
'https://github.com/Masaharu41/Stan-sGrocery.git

Option Explicit On
Option Strict On
Option Compare Text


Public Class StansGrocery
    Dim foodItems As New List(Of String())

    Private Sub Loader(sender As Object, e As EventArgs) Handles Me.Load
        CreateFoodArray()
    End Sub

    Sub CreateFoodArray()
        Dim temp() As String
        Dim groceryItems As String
        Dim i As Integer = 0
        Try
            FileOpen(1, "..\..\Grocery.txt", OpenMode.Input)
        Catch ex As Exception
            FileOpen(2, "..\..\ErrorLog.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try
        Do Until EOF(1)
            groceryItems = LineInput(1)
            temp = Split(groceryItems, ",")
            Me.foodItems.Add(temp)
        Loop
        FileOpen(3, "..\..\TempOut.txt", OpenMode.Append)
        Write(3, foodItems)
        FileClose(3)
        FileClose(1)
    End Sub

End Class
