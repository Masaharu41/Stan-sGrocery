<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.BackColor = System.Drawing.Color.LightGray
        Me.AboutLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AboutLabel.Location = New System.Drawing.Point(28, 55)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(466, 150)
        Me.AboutLabel.TabIndex = 0
        Me.AboutLabel.Text = resources.GetString("AboutLabel.Text")
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(326, 243)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(152, 61)
        Me.AboutButton.TabIndex = 1
        Me.AboutButton.Text = "Ok"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(577, 343)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.AboutLabel)
        Me.Name = "AboutForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutLabel As Label
    Friend WithEvents AboutButton As Button
End Class
