<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Получить все записи"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(180, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Добавить запись"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 284)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "SOAP Client"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
