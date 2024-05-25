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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(25, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(121, 23)
        TextBox1.TabIndex = 0
        TextBox1.Text = "peliculas "
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(25, 67)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(121, 23)
        TextBox2.TabIndex = 1
        TextBox2.Text = "estrenos"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Window
        TextBox3.Location = New Point(25, 112)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(121, 23)
        TextBox3.TabIndex = 2
        TextBox3.Text = "director " & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "                                             " & vbCrLf
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(81, 155)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(65, 23)
        TextBox4.TabIndex = 3
        TextBox4.Text = "label id"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(29, 200)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 36)
        Button1.TabIndex = 4
        Button1.Text = "cargar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 310)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button

End Class
