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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(420, 70)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(366, 276)
        Me.ListBox1.TabIndex = 35
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(99, 239)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 42)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Opprett tabell"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(222, 304)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 47)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Hent data"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(99, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 47)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Legg inn data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 42)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Avslutt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 42)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Koble til server"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(99, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(222, 22)
        Me.TextBox3.TabIndex = 29
        Me.TextBox3.Text = "mysql.stud.iie.hist.no"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(99, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(222, 22)
        Me.TextBox2.TabIndex = 28
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 22)
        Me.TextBox1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Passord"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Brukernavn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 419)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
