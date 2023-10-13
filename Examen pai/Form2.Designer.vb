<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(270, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 50)
        Label1.TabIndex = 0
        Label1.Text = "OPERACIONES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(234, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(370, 28)
        Label2.TabIndex = 1
        Label2.Text = "Elija la operación que desea realizar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(159, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(367, 157)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 42)
        Button1.TabIndex = 3
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(367, 205)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 42)
        Button2.TabIndex = 4
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(367, 252)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 42)
        Button3.TabIndex = 5
        Button3.Text = "x"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(367, 300)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 43)
        Button4.TabIndex = 6
        Button4.Text = "÷"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(636, 379)
        Button5.Name = "Button5"
        Button5.Size = New Size(99, 43)
        Button5.TabIndex = 7
        Button5.Text = "Logout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stylus BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(187, 28)
        Label5.TabIndex = 9
        Label5.Text = "Bienvenido/a wcm"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Cursor = Cursors.Cross
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
End Class
