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
        Dim itmName() As String
        Dim aisleNum() As String
        Dim itmCat() As String
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
            itmName = Split(temp(0), "$$ITM")
            aisleNum = Split(temp(1), "##LOC")
            itmCat = Split(temp(2), "%%CAT")
            itmName = Split(itmName(1), "")
            aisleNum = Split(aisleNum(1), "")
            itmCat = Split(itmCat(1), "")
            food(0, i) = itmName(0).Replace("""", "")
            food(1, i) = aisleNum(0).Replace("""", "")
            food(2, i) = itmCat(0).Replace("""", "")
            i = i + 1
        Loop
        ReDim Preserve food(2, i - 1)

        FileClose(1)
    End Sub

    Function SearchByName() As String

        Dim itemName As String
        Dim userInput As String
        If String.IsNullOrEmpty(SearchTextBox.Text) Then
            Return "Sorry, Please enter an item name"
        Else

            For i = 0 To UBound(food, 2)

                itemName = food(0, i)
                '  itemName = Split(itemName, "$$ITM")
                userInput = SearchTextBox.Text
                If itemName = userInput Then
                    MsgBox("We found your Item")
                    Return $"You will find {food(0, i)} in aisle {food(1, i)} with the {food(2, i)}"
                Else

                End If
                DisplayListBox.Items.Add(itemName)


            Next


            Return "Sorry we could not find your item"
        End If
    End Function

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DisplayLabel.Text = SearchByName()
    End Sub
End Class
