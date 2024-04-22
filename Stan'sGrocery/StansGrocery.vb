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
            food(0, i) = temp(0)
            food(1, i) = temp(1)
            food(2, i) = temp(2)
            i = i + 1
        Loop
        ReDim Preserve food(2, i - 1)

        FileClose(1)
    End Sub

    Function SearchByName() As String

        Dim itemName As String
        Dim userInput As String

        For i = 0 To UBound(food, 2)

            itemName = food(0, i)
            '  itemName = Split(itemName, "$$ITM")
            userInput = "$$ITM" & SearchTextBox.Text
            If itemName = userInput Then
                MsgBox("We found your Item")
            Else

            End If
            DisplayListBox.Items.Add(itemName)


        Next


        Return "hello"
    End Function

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchByName()
    End Sub
End Class
