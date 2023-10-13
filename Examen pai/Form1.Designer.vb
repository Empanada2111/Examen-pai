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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Calculadro = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(349, 286)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 45)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 25.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(229, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 54)
        Label1.TabIndex = 1
        Label1.Text = "¡Bienvenido!"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(339, 180)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(339, 234)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(226, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 28)
        Label2.TabIndex = 4
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(209, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 28)
        Label3.TabIndex = 5
        Label3.Text = "Contraseña"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(226, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(329, 28)
        Label4.TabIndex = 6
        Label4.Text = "Ingrese su usuario y contraseña"
        ' 
        ' Calculadro
        ' 
        Calculadro.AutoSize = True
        Calculadro.Font = New Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Calculadro.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Calculadro.Location = New Point(12, 19)
        Calculadro.Name = "Calculadro"
        Calculadro.Size = New Size(233, 24)
        Calculadro.TabIndex = 7
        Calculadro.Text = "Calculadora chikita"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Calculadro)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Calculadro As Label
End Class
