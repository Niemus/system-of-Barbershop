<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reg))
        Me.ClsAnomTheme1 = New WindowsApplication1.clsAnomTheme
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.AnomButton2 = New WindowsApplication1.AnomButton
        Me.AnomButton1 = New WindowsApplication1.AnomButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ClsAnomTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClsAnomTheme1
        '
        Me.ClsAnomTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClsAnomTheme1.Controls.Add(Me.MaskedTextBox3)
        Me.ClsAnomTheme1.Controls.Add(Me.MaskedTextBox2)
        Me.ClsAnomTheme1.Controls.Add(Me.MaskedTextBox1)
        Me.ClsAnomTheme1.Controls.Add(Me.TextBox6)
        Me.ClsAnomTheme1.Controls.Add(Me.Label6)
        Me.ClsAnomTheme1.Controls.Add(Me.Label5)
        Me.ClsAnomTheme1.Controls.Add(Me.MonthCalendar1)
        Me.ClsAnomTheme1.Controls.Add(Me.Label4)
        Me.ClsAnomTheme1.Controls.Add(Me.Label3)
        Me.ClsAnomTheme1.Controls.Add(Me.TextBox3)
        Me.ClsAnomTheme1.Controls.Add(Me.Label2)
        Me.ClsAnomTheme1.Controls.Add(Me.Label1)
        Me.ClsAnomTheme1.Controls.Add(Me.TextBox1)
        Me.ClsAnomTheme1.Controls.Add(Me.AnomButton2)
        Me.ClsAnomTheme1.Controls.Add(Me.AnomButton1)
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
        Me.ClsAnomTheme1.Size = New System.Drawing.Size(577, 629)
        Me.ClsAnomTheme1.SmartBounds = True
        Me.ClsAnomTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ClsAnomTheme1.TabIndex = 0
        Me.ClsAnomTheme1.Text = "ClsAnomTheme1"
        Me.ClsAnomTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClsAnomTheme1.Transparent = False
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(180, 275)
        Me.MaskedTextBox3.Mask = "0-00-00"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(179, 29)
        Me.MaskedTextBox3.TabIndex = 20
        Me.MaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(180, 104)
        Me.MaskedTextBox2.Mask = "+7 (999) 000-00-00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(179, 29)
        Me.MaskedTextBox2.TabIndex = 19
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(179, 181)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(179, 29)
        Me.MaskedTextBox1.TabIndex = 18
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(180, 310)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(179, 32)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Стоимость:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Код заказа:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(382, 50)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Время посещения:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Адрес:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(180, 141)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(179, 32)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Номер телефона:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ФИО:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(180, 65)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 32)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AnomButton2
        '
        Me.AnomButton2.Customization = "3PX1/9zc3P8AAAD/AAAA/w=="
        Me.AnomButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.AnomButton2.Image = Nothing
        Me.AnomButton2.Location = New System.Drawing.Point(23, 553)
        Me.AnomButton2.Name = "AnomButton2"
        Me.AnomButton2.NoRounding = False
        Me.AnomButton2.Size = New System.Drawing.Size(87, 53)
        Me.AnomButton2.TabIndex = 2
        Me.AnomButton2.Text = "Назад"
        Me.AnomButton2.Transparent = False
        '
        'AnomButton1
        '
        Me.AnomButton1.Customization = "3PX1/9zc3P8AAAD/AAAA/w=="
        Me.AnomButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.AnomButton1.Image = Nothing
        Me.AnomButton1.Location = New System.Drawing.Point(393, 553)
        Me.AnomButton1.Name = "AnomButton1"
        Me.AnomButton1.NoRounding = False
        Me.AnomButton1.Size = New System.Drawing.Size(157, 53)
        Me.AnomButton1.TabIndex = 0
        Me.AnomButton1.Text = "Зарегистрировать"
        Me.AnomButton1.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.nosh
        Me.PictureBox1.Location = New System.Drawing.Point(60, 377)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 629)
        Me.Controls.Add(Me.ClsAnomTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Регистрация"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClsAnomTheme1.ResumeLayout(False)
        Me.ClsAnomTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AnomButton1 As WindowsApplication1.AnomButton
    Friend WithEvents AnomButton2 As WindowsApplication1.AnomButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ClsAnomTheme1 As WindowsApplication1.clsAnomTheme
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
End Class
