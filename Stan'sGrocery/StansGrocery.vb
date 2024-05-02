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
        ShowAllRadioButton.Checked = True
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
        Dim userInputAisle As Integer
        DisplayListBox.Items.Clear()

        If String.IsNullOrEmpty(SearchTextBox.Text) Then
            Return "Sorry, Please enter an item name"
        ElseIf SearchTextBox.Text = "zzz" Then
            Me.Close()
        Else

            For i = 0 To UBound(food, 2)
                itemName = food(0, i)
                userInput = SearchTextBox.Text
                If itemName Like userInput Then
                    MsgBox("We found your Item")
                    DisplayListBox.Items.Add(itemName)
                    If String.IsNullOrEmpty(food(0, i)) And String.IsNullOrEmpty(CStr(food(1, i))) And String.IsNullOrEmpty(food(2, i)) Then
                        Return "Sorry, your item does not have known data"
                    Else

                        Return $"You will find {food(0, i)} in aisle {food(1, i)} with the {food(2, i)}"
                    End If
                Else
                End If

            Next

            Try
                For e = 0 To UBound(food, 2)
                    userInputAisle = CInt(SearchTextBox.Text)
                    If String.IsNullOrEmpty(CStr(food(1, e))) Then
                    ElseIf userInputAisle = CInt(food(1, e)) Then
                        DisplayListBox.Items.Add(food(0, e))
                    End If
                Next
                Return "Here are the Aisles"
            Catch ex As Exception

            End Try
        End If
        Return $"Sorry we could not find {SearchTextBox.Text}"

    End Function

    Sub DisplayItems()
        DisplayListBox.Items.Clear()

        For i = 0 To UBound(food, 2)
            If DisplayListBox.Items.Contains(food(0, i)) Then
            Else
                If String.IsNullOrEmpty(food(0, i)) Then
                Else
                    DisplayListBox.Items.Add(food(0, i))
                End If
            End If
        Next
    End Sub

    Sub DisplayAisle()
        DisplayListBox.Items.Clear()

        For i = 0 To UBound(food, 2)
            If DisplayListBox.Items.Contains(food(1, i)) Then
            Else
                If String.IsNullOrEmpty(food(1, i)) Then
                Else
                    DisplayListBox.Items.Add(food(1, i))
                End If

            End If
        Next
    End Sub

    Sub DisplayCat()
        DisplayListBox.Items.Clear()

        For i = 0 To UBound(food, 2)

            If DisplayListBox.Items.Contains(food(2, i)) Then
            Else
                If String.IsNullOrEmpty(food(2, i)) Then
                Else
                    DisplayListBox.Items.Add(food(2, i))
                End If
            End If

        Next

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DisplayLabel.Text = SearchByName()
    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        DisplayAisle()
    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        DisplayCat()
    End Sub

    Private Sub ShowAllRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ShowAllRadioButton.CheckedChanged
        DisplayItems()
    End Sub

End Class
