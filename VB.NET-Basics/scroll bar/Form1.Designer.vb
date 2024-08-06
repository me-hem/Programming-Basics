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
        Me.hb = New System.Windows.Forms.HScrollBar()
        Me.vb = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'hb
        '
        Me.hb.Location = New System.Drawing.Point(9, 399)
        Me.hb.Name = "hb"
        Me.hb.Size = New System.Drawing.Size(782, 42)
        Me.hb.TabIndex = 0
        '
        'vb
        '
        Me.vb.Location = New System.Drawing.Point(752, 9)
        Me.vb.Name = "vb"
        Me.vb.Size = New System.Drawing.Size(39, 432)
        Me.vb.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.vb)
        Me.Controls.Add(Me.hb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents hb As HScrollBar
    Friend WithEvents vb As VScrollBar
End Class
