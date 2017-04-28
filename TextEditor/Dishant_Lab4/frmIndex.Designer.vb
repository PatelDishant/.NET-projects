<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
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
        Me.lblCopyCutPaste = New System.Windows.Forms.Label()
        Me.lblCopyCutPasteMessage = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCopyCutPaste
        '
        Me.lblCopyCutPaste.AutoSize = True
        Me.lblCopyCutPaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyCutPaste.Location = New System.Drawing.Point(12, 9)
        Me.lblCopyCutPaste.Name = "lblCopyCutPaste"
        Me.lblCopyCutPaste.Size = New System.Drawing.Size(102, 13)
        Me.lblCopyCutPaste.TabIndex = 0
        Me.lblCopyCutPaste.Text = "Copy/Cut/Paste:"
        '
        'lblCopyCutPasteMessage
        '
        Me.lblCopyCutPasteMessage.AutoSize = True
        Me.lblCopyCutPasteMessage.Location = New System.Drawing.Point(12, 38)
        Me.lblCopyCutPasteMessage.Name = "lblCopyCutPasteMessage"
        Me.lblCopyCutPasteMessage.Size = New System.Drawing.Size(293, 52)
        Me.lblCopyCutPasteMessage.TabIndex = 1
        Me.lblCopyCutPasteMessage.Text = "Highlight the text wanted and then click:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Edit, and then select the actio" &
    "n to perform (Cut, Copy)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Alternatively, use the keyboard shortcuts (Ctrl +" &
    " X, Ctrl +C)"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(15, 104)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(341, 32)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 148)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblCopyCutPasteMessage)
        Me.Controls.Add(Me.lblCopyCutPaste)
        Me.Name = "frmIndex"
        Me.Text = "Index "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCopyCutPaste As Label
    Friend WithEvents lblCopyCutPasteMessage As Label
    Friend WithEvents btnOk As Button
End Class
