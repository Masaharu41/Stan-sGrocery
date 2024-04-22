'Owen Fujii
'RCET 2265
'Spring 2024
'Stan's Grocery
'https://github.com/Masaharu41/Stan-sGrocery.git

Option Explicit On
Option Strict On
Option Compare Text


Public Class StansGrocery

    Dim food(2, 500) As String

    Private Sub Loader(sender As Object, e As EventArgs) Handles Me.Load
        'RowIndex()
        CreateFoodArray()
    End Sub

    Function RowIndex() As Integer
        Dim i As Integer = 0
        Try
            FileOpen(1, "..\..\Grocery.txt", OpenMode.Input)
        Catch ex As Exception
            FileOpen(2, "..\..\ErrorLog.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try
        Do Until EOF(1)
            i = i + 1
        Loop
        Return i
    End Function
    Sub CreateFoodArray()
        Dim temp() As String
        Dim groceryItems As String
        ' Dim tempGlobArray(2, 500) As String
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
            food(0, i) = temp(0)
            food(1, i) = temp(1)
            food(2, i) = temp(2)
            'tempGlobArray(0, i) = temp(0)
            'tempGlobArray(1, i) = temp(1)
            'tempGlobArray(2, i) = temp(2)
            i = i + 1
        Loop
        ReDim Preserve food(2, i - 1)
        ' ReDim Preserve tempGlobArray(2, i - 1)
        'food(,) = tempGlobArray(,)
        ' SearchTextBox.Text = food(2, 1)
        FileClose(1)
    End Sub

    Function SearchByName() As String
        ' Dim temp() As String
        ' Dim e As Integer = 0
        Dim itemName$
        'Dim endofArray As Integer

        For i = 0 To UBound(food, 2)

            itemName = food(0, i)
            DisplayListBox.Items.Add(itemName)


        Next


        Return "hello"
    End Function

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchByName()
    End Sub
End Class
