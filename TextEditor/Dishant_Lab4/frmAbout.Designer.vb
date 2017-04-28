<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.lblNetD = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNetD
        '
        Me.lblNetD.AutoSize = True
        Me.lblNetD.Location = New System.Drawing.Point(12, 29)
        Me.lblNetD.Name = "lblNetD"
        Me.lblNetD.Size = New System.Drawing.Size(40, 13)
        Me.lblNetD.TabIndex = 0
        Me.lblNetD.Text = "NETD "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(34, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Lab 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dishant's Sample Executable"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 165)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(188, 31)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 208)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblNetD)
        Me.Name = "frmAbout"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNetD As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOk As Button
End Class
