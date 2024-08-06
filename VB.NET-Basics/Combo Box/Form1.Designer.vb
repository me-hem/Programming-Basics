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
        Me.Add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Sort = New System.Windows.Forms.Button()
        Me.remove = New System.Windows.Forms.Button()
        Me.count = New System.Windows.Forms.Button()
        Me._exit = New System.Windows.Forms.Button()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(628, 45)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(112, 48)
        Me.Add.TabIndex = 0
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(55, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter book name: "
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(248, 48)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(310, 31)
        Me.input.TabIndex = 2
        '
        'Sort
        '
        Me.Sort.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sort.Location = New System.Drawing.Point(628, 122)
        Me.Sort.Name = "Sort"
        Me.Sort.Size = New System.Drawing.Size(112, 48)
        Me.Sort.TabIndex = 3
        Me.Sort.Text = "Sort"
        Me.Sort.UseVisualStyleBackColor = True
        '
        'remove
        '
        Me.remove.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.remove.Location = New System.Drawing.Point(628, 203)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(112, 48)
        Me.remove.TabIndex = 4
        Me.remove.Text = "Remove"
        Me.remove.UseVisualStyleBackColor = True
        '
        'count
        '
        Me.count.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.count.Location = New System.Drawing.Point(628, 283)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(112, 48)
        Me.count.TabIndex = 5
        Me.count.Text = "Count"
        Me.count.UseVisualStyleBackColor = True
        '
        '_exit
        '
        Me._exit.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me._exit.Location = New System.Drawing.Point(628, 361)
        Me._exit.Name = "_exit"
        Me._exit.Size = New System.Drawing.Size(112, 48)
        Me._exit.TabIndex = 6
        Me._exit.Text = "Exit"
        Me._exit.UseVisualStyleBackColor = True
        '
        'ComboBox
        '
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(55, 122)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(182, 33)
        Me.ComboBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(471, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Count: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 429)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me._exit)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.Sort)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Add)
        Me.Name = "Form1"
        Me.Text = "Combo Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents input As TextBox
    Friend WithEvents Sort As Button
    Friend WithEvents remove As Button
    Friend WithEvents count As Button
    Friend WithEvents _exit As Button
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Label2 As Label
End Class
