<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGrocery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.StoreLabel = New System.Windows.Forms.Label()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ShowAllRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FilterByItemsRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Liberation Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(166, 175)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(177, 41)
        Me.SearchTextBox.TabIndex = 0
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(166, 232)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(148, 77)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'StoreLabel
        '
        Me.StoreLabel.AutoSize = True
        Me.StoreLabel.Font = New System.Drawing.Font("Liberation Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreLabel.Location = New System.Drawing.Point(160, 119)
        Me.StoreLabel.Name = "StoreLabel"
        Me.StoreLabel.Size = New System.Drawing.Size(199, 36)
        Me.StoreLabel.TabIndex = 2
        Me.StoreLabel.Text = "Stan's Grocery"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 25
        Me.DisplayListBox.Location = New System.Drawing.Point(553, 45)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(679, 804)
        Me.DisplayListBox.TabIndex = 3
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(161, 415)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(0, 25)
        Me.DisplayLabel.TabIndex = 4
        '
        'ShowAllRadioButton
        '
        Me.ShowAllRadioButton.AutoSize = True
        Me.ShowAllRadioButton.Location = New System.Drawing.Point(6, 38)
        Me.ShowAllRadioButton.Name = "ShowAllRadioButton"
        Me.ShowAllRadioButton.Size = New System.Drawing.Size(124, 29)
        Me.ShowAllRadioButton.TabIndex = 5
        Me.ShowAllRadioButton.TabStop = True
        Me.ShowAllRadioButton.Text = "Show all"
        Me.ShowAllRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(6, 138)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(173, 29)
        Me.FilterByAisleRadioButton.TabIndex = 6
        Me.FilterByAisleRadioButton.TabStop = True
        Me.FilterByAisleRadioButton.Text = "Filter by Aisle"
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(6, 183)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(213, 29)
        Me.FilterByCategoryRadioButton.TabIndex = 7
        Me.FilterByCategoryRadioButton.TabStop = True
        Me.FilterByCategoryRadioButton.Text = "Filter by Category"
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FilterByItemsRadioButton)
        Me.GroupBox1.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.GroupBox1.Controls.Add(Me.ShowAllRadioButton)
        Me.GroupBox1.Controls.Add(Me.FilterByAisleRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 581)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 246)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Items by"
        '
        'FilterByItemsRadioButton
        '
        Me.FilterByItemsRadioButton.AutoSize = True
        Me.FilterByItemsRadioButton.Location = New System.Drawing.Point(6, 73)
        Me.FilterByItemsRadioButton.Name = "FilterByItemsRadioButton"
        Me.FilterByItemsRadioButton.Size = New System.Drawing.Size(177, 29)
        Me.FilterByItemsRadioButton.TabIndex = 8
        Me.FilterByItemsRadioButton.TabStop = True
        Me.FilterByItemsRadioButton.Text = "Filter by Items"
        Me.FilterByItemsRadioButton.UseVisualStyleBackColor = True
        '
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 926)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.StoreLabel)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Name = "StansGrocery"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents StoreLabel As Label
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ShowAllRadioButton As RadioButton
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FilterByItemsRadioButton As RadioButton
End Class
