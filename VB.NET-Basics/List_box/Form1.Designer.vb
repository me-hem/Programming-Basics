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
        Me.input = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.sort = New System.Windows.Forms.Button()
        Me.count = New System.Windows.Forms.Button()
        Me._exit = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.remove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(273, 81)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(341, 31)
        Me.input.TabIndex = 0
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.add.Location = New System.Drawing.Point(682, 79)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(90, 39)
        Me.add.TabIndex = 1
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'sort
        '
        Me.sort.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sort.Location = New System.Drawing.Point(682, 144)
        Me.sort.Name = "sort"
        Me.sort.Size = New System.Drawing.Size(90, 39)
        Me.sort.TabIndex = 2
        Me.sort.Text = "Sort"
        Me.sort.UseVisualStyleBackColor = True
        '
        'count
        '
        Me.count.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.count.Location = New System.Drawing.Point(682, 218)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(90, 39)
        Me.count.TabIndex = 3
        Me.count.Text = "Count"
        Me.count.UseVisualStyleBackColor = True
        '
        '_exit
        '
        Me._exit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me._exit.Location = New System.Drawing.Point(682, 364)
        Me._exit.Name = "_exit"
        Me._exit.Size = New System.Drawing.Size(90, 39)
        Me._exit.TabIndex = 4
        Me._exit.Text = "Exit"
        Me._exit.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 25
        Me.ListBox.Location = New System.Drawing.Point(53, 144)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(216, 229)
        Me.ListBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Just Chill Books Store"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(53, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter you book name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(53, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Count: 0"
        '
        'remove
        '
        Me.remove.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.remove.Location = New System.Drawing.Point(682, 293)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(90, 39)
        Me.remove.TabIndex = 9
        Me.remove.Text = "Remove"
        Me.remove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me._exit)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.sort)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.input)
        Me.Name = "Form1"
        Me.Text = "List Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents input As TextBox
    Friend WithEvents add As Button
    Friend WithEvents sort As Button
    Friend WithEvents count As Button
    Friend WithEvents _exit As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents remove As Button
End Class
