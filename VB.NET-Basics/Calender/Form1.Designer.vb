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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.view = New System.Windows.Forms.Button()
        Me.day = New System.Windows.Forms.ComboBox()
        Me.year = New System.Windows.Forms.ComboBox()
        Me.month = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(306, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(83, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date: "
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_exit.Location = New System.Drawing.Point(306, 382)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(92, 45)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'view
        '
        Me.view.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.view.Location = New System.Drawing.Point(512, 382)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(92, 45)
        Me.view.TabIndex = 3
        Me.view.Text = "View"
        Me.view.UseVisualStyleBackColor = True
        '
        'day
        '
        Me.day.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.day.FormattingEnabled = True
        Me.day.Location = New System.Drawing.Point(227, 182)
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(150, 35)
        Me.day.TabIndex = 4
        Me.day.Text = "Day"
        '
        'year
        '
        Me.year.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.year.FormattingEnabled = True
        Me.year.Location = New System.Drawing.Point(586, 182)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(150, 35)
        Me.year.TabIndex = 5
        Me.year.Text = "Year"
        '
        'month
        '
        Me.month.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.month.FormattingEnabled = True
        Me.month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.month.Location = New System.Drawing.Point(404, 182)
        Me.month.Name = "month"
        Me.month.Size = New System.Drawing.Size(150, 35)
        Me.month.TabIndex = 6
        Me.month.Text = "Month"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 526)
        Me.Controls.Add(Me.month)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.day)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calender"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents view As Button
    Friend WithEvents day As ComboBox
    Friend WithEvents year As ComboBox
    Friend WithEvents month As ComboBox
End Class
