﻿'Owen Fujii
'RCET 2265
'Spring 2024
'Stan's Grocery
'https://github.com/Masaharu41/Stan-sGrocery.git

Option Explicit On
Option Strict On
Option Compare Text


Public Class StansGrocery
    Dim foodItems(500, 2) As String


    Private Sub Loader(sender As Object, e As EventArgs) Handles Me.Load
        CreateFoodArray()
    End Sub
    'Function items() As Array

    'End Function
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
            Me.foodItems(i, 0) = temp(0)
            Me.foodItems(i, 1) = temp(1)
            Me.foodItems(i, 2) = temp(2)
            i = i + 1
        Loop
        'ReDim Preserve Me.foodItems(2, i)

        FileClose(1)
    End Sub

    Function SearchByName() As String
        Dim temp() As String
        Dim itemName$

        For Each i In foodItems
            temp(0) = foodItems(CInt(i), 0)

        Next


        Return "hello"
    End Function

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchByName()
    End Sub
End Class
