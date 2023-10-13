<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(354, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 50)
        Label1.TabIndex = 0
        Label1.Text = "Suma"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(358, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(358, 191)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(250, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 28)
        Label2.TabIndex = 3
        Label2.Text = "No.1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(250, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 28)
        Label3.TabIndex = 4
        Label3.Text = "No.2"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(373, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 38)
        Button1.TabIndex = 5
        Button1.Text = "Sumar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(666, 375)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 36)
        Button2.TabIndex = 6
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(51, 375)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 36)
        Button3.TabIndex = 7
        Button3.Text = "C"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stylus BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(414, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 34)
        Label4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(327, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 28)
        Label5.TabIndex = 9
        Label5.Text = "Ingrese 2 numeros"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        Text = "Suma"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
