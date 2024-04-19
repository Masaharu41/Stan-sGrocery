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
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 926)
        Me.Controls.Add(Me.StoreLabel)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Name = "StansGrocery"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents StoreLabel As Label
End Class
