<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.AnomButton2 = New WindowsApplication1.AnomButton
        Me.AnomButton1 = New WindowsApplication1.AnomButton
        Me.ClsAnomTheme1 = New WindowsApplication1.clsAnomTheme
        Me.AnomButton3 = New WindowsApplication1.AnomButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ClsAnomTheme1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnomButton2
        '
        Me.AnomButton2.Customization = "3PX1/9zc3P8AAAD/AAAA/w=="
        Me.AnomButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.AnomButton2.Image = Nothing
        Me.AnomButton2.Location = New System.Drawing.Point(44, 468)
        Me.AnomButton2.Name = "AnomButton2"
        Me.AnomButton2.NoRounding = False
        Me.AnomButton2.Size = New System.Drawing.Size(115, 41)
        Me.AnomButton2.TabIndex = 6
        Me.AnomButton2.Text = "База данных"
        Me.AnomButton2.Transparent = False
        '
        'AnomButton1
        '
        Me.AnomButton1.Customization = "3PX1/9zc3P8AAAD/AAAA/w=="
        Me.AnomButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.AnomButton1.Image = Nothing
        Me.AnomButton1.Location = New System.Drawing.Point(44, 394)
        Me.AnomButton1.Name = "AnomButton1"
        Me.AnomButton1.NoRounding = False
        Me.AnomButton1.Size = New System.Drawing.Size(115, 43)
        Me.AnomButton1.TabIndex = 5
        Me.AnomButton1.Text = "Регистрация"
        Me.AnomButton1.Transparent = False
        '
        'ClsAnomTheme1
        '
        Me.ClsAnomTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClsAnomTheme1.Controls.Add(Me.AnomButton2)
        Me.ClsAnomTheme1.Controls.Add(Me.AnomButton3)
        Me.ClsAnomTheme1.Controls.Add(Me.AnomButton1)
        Me.ClsAnomTheme1.Controls.Add(Me.PictureBox2)
        Me.ClsAnomTheme1.Controls.Add(Me.PictureBox1)
        Me.ClsAnomTheme1.Customization = "AAAA/wAAAP8="
        Me.ClsAnomTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClsAnomTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ClsAnomTheme1.Image = Nothing
        Me.ClsAnomTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ClsAnomTheme1.Movable = True
        Me.ClsAnomTheme1.Name = "ClsAnomTheme1"
        Me.ClsAnomTheme1.NoRounding = False
        Me.ClsAnomTheme1.ShowIcon = False
        Me.ClsAnomTheme1.Sizable = True
        Me.ClsAnomTheme1.Size = New System.Drawing.Size(514, 640)
        Me.ClsAnomTheme1.SmartBounds = True
        Me.ClsAnomTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ClsAnomTheme1.TabIndex = 7
        Me.ClsAnomTheme1.Text = "ClsAnomTheme1"
        Me.ClsAnomTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClsAnomTheme1.Transparent = False
        '
        'AnomButton3
        '
        Me.AnomButton3.Customization = "3PX1/9zc3P8AAAD/AAAA/w=="
        Me.AnomButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.AnomButton3.Image = Nothing
        Me.AnomButton3.Location = New System.Drawing.Point(44, 541)
        Me.AnomButton3.Name = "AnomButton3"
        Me.AnomButton3.NoRounding = False
        Me.AnomButton3.Size = New System.Drawing.Size(115, 41)
        Me.AnomButton3.TabIndex = 8
        Me.AnomButton3.Text = "Выйти"
        Me.AnomButton3.Transparent = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.nazv
        Me.PictureBox2.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(490, 279)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.pila
        Me.PictureBox1.Location = New System.Drawing.Point(206, 329)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 299)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(514, 640)
        Me.Controls.Add(Me.ClsAnomTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Главное меню"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClsAnomTheme1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents AnomButton1 As WindowsApplication1.AnomButton
    Friend WithEvents AnomButton2 As WindowsApplication1.AnomButton
    Friend WithEvents ClsAnomTheme1 As WindowsApplication1.clsAnomTheme
    Friend WithEvents AnomButton3 As WindowsApplication1.AnomButton

End Class
