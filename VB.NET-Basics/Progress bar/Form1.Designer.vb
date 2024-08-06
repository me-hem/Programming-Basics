<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pr = New System.Windows.Forms.ProgressBar()
        Me.submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pr
        '
        Me.pr.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pr.Location = New System.Drawing.Point(171, 100)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(397, 34)
        Me.pr.TabIndex = 0
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(320, 230)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(112, 34)
        Me.submit.TabIndex = 1
        Me.submit.Text = "Download"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 349)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.pr)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pr As ProgressBar
    Friend WithEvents submit As Button
End Class
