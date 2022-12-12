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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.namee = New System.Windows.Forms.TextBox()
        Me.tuitionn = New System.Windows.Forms.TextBox()
        Me.inflationn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        Me.yearr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(164, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tuition(in $):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Inflation(in %): "
        '
        'namee
        '
        Me.namee.Location = New System.Drawing.Point(94, 71)
        Me.namee.Name = "namee"
        Me.namee.Size = New System.Drawing.Size(253, 20)
        Me.namee.TabIndex = 4
        '
        'tuitionn
        '
        Me.tuitionn.Location = New System.Drawing.Point(94, 102)
        Me.tuitionn.Name = "tuitionn"
        Me.tuitionn.Size = New System.Drawing.Size(253, 20)
        Me.tuitionn.TabIndex = 5
        '
        'inflationn
        '
        Me.inflationn.Location = New System.Drawing.Point(94, 134)
        Me.inflationn.Name = "inflationn"
        Me.inflationn.Size = New System.Drawing.Size(253, 20)
        Me.inflationn.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tuition Inflation"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(11, 249)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(13, 16)
        Me.result.TabIndex = 8
        Me.result.Text = ": "
        '
        'yearr
        '
        Me.yearr.Location = New System.Drawing.Point(93, 159)
        Me.yearr.Name = "yearr"
        Me.yearr.Size = New System.Drawing.Size(254, 20)
        Me.yearr.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Years: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 284)
        Me.Controls.Add(Me.yearr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inflationn)
        Me.Controls.Add(Me.tuitionn)
        Me.Controls.Add(Me.namee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents namee As TextBox
    Friend WithEvents tuitionn As TextBox
    Friend WithEvents inflationn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents result As Label
    Friend WithEvents yearr As TextBox
    Friend WithEvents Label5 As Label
End Class
