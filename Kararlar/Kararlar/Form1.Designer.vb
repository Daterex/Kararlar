<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SonucTextBox = New System.Windows.Forms.TextBox()
        Me.SayiTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonKontrol1 = New System.Windows.Forms.Button()
        Me.ButtonKontrol2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sayı Giriniz:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sonuç:"
        '
        'SonucTextBox
        '
        Me.SonucTextBox.Location = New System.Drawing.Point(171, 224)
        Me.SonucTextBox.Name = "SonucTextBox"
        Me.SonucTextBox.Size = New System.Drawing.Size(155, 20)
        Me.SonucTextBox.TabIndex = 2
        '
        'SayiTextBox
        '
        Me.SayiTextBox.Location = New System.Drawing.Point(226, 86)
        Me.SayiTextBox.Name = "SayiTextBox"
        Me.SayiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SayiTextBox.TabIndex = 3
        '
        'ButtonKontrol1
        '
        Me.ButtonKontrol1.Location = New System.Drawing.Point(117, 136)
        Me.ButtonKontrol1.Name = "ButtonKontrol1"
        Me.ButtonKontrol1.Size = New System.Drawing.Size(209, 31)
        Me.ButtonKontrol1.TabIndex = 4
        Me.ButtonKontrol1.Text = "Kontrol Et"
        Me.ButtonKontrol1.UseVisualStyleBackColor = True
        '
        'ButtonKontrol2
        '
        Me.ButtonKontrol2.Location = New System.Drawing.Point(117, 183)
        Me.ButtonKontrol2.Name = "ButtonKontrol2"
        Me.ButtonKontrol2.Size = New System.Drawing.Size(209, 23)
        Me.ButtonKontrol2.TabIndex = 5
        Me.ButtonKontrol2.Text = "Kontrol Et"
        Me.ButtonKontrol2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonKontrol2)
        Me.Controls.Add(Me.ButtonKontrol1)
        Me.Controls.Add(Me.SayiTextBox)
        Me.Controls.Add(Me.SonucTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SonucTextBox As TextBox
    Friend WithEvents SayiTextBox As TextBox
    Friend WithEvents ButtonKontrol1 As Button
    Friend WithEvents ButtonKontrol2 As Button
End Class
