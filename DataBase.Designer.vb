<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBase
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataBase))
        Me.КлиентыDataSet = New WindowsApplication1.КлиентыDataSet
        Me.КлиентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КлиентыTableAdapter = New WindowsApplication1.КлиентыDataSetTableAdapters.КлиентыTableAdapter
        Me.ClsAnomTheme1 = New WindowsApplication1.clsAnomTheme
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ФИОDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НомерТелефонаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.АдресDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ВремяПосещенияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЗаказDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.СтоимостьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.КлиентыDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлиентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClsAnomTheme1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'КлиентыDataSet
        '
        Me.КлиентыDataSet.DataSetName = "КлиентыDataSet"
        Me.КлиентыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'КлиентыBindingSource
        '
        Me.КлиентыBindingSource.DataMember = "Клиенты"
        Me.КлиентыBindingSource.DataSource = Me.КлиентыDataSet
        '
        'КлиентыTableAdapter
        '
        Me.КлиентыTableAdapter.ClearBeforeFill = True
        '
        'ClsAnomTheme1
        '
        Me.ClsAnomTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClsAnomTheme1.Controls.Add(Me.GroupBox1)
        Me.ClsAnomTheme1.Controls.Add(Me.DataGridView1)
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
        Me.ClsAnomTheme1.Size = New System.Drawing.Size(1024, 599)
        Me.ClsAnomTheme1.SmartBounds = True
        Me.ClsAnomTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ClsAnomTheme1.TabIndex = 1
        Me.ClsAnomTheme1.Text = "ClsAnomTheme1"
        Me.ClsAnomTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClsAnomTheme1.Transparent = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(787, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 544)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.storage_diskette_318_29934
        Me.PictureBox3.Location = New System.Drawing.Point(67, 235)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.kisspng_computer_icons_refresh_free_5b0d1344c8ab28_910850311527583556822
        Me.PictureBox2.Location = New System.Drawing.Point(46, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._603018
        Me.PictureBox1.Location = New System.Drawing.Point(46, 427)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ФИОDataGridViewTextBoxColumn, Me.НомерТелефонаDataGridViewTextBoxColumn, Me.АдресDataGridViewTextBoxColumn, Me.ВремяПосещенияDataGridViewTextBoxColumn, Me.ЗаказDataGridViewTextBoxColumn, Me.СтоимостьDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.КлиентыBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 544)
        Me.DataGridView1.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        '
        'ФИОDataGridViewTextBoxColumn
        '
        Me.ФИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.HeaderText = "ФИО"
        Me.ФИОDataGridViewTextBoxColumn.Name = "ФИОDataGridViewTextBoxColumn"
        '
        'НомерТелефонаDataGridViewTextBoxColumn
        '
        Me.НомерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона"
        Me.НомерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона"
        Me.НомерТелефонаDataGridViewTextBoxColumn.Name = "НомерТелефонаDataGridViewTextBoxColumn"
        '
        'АдресDataGridViewTextBoxColumn
        '
        Me.АдресDataGridViewTextBoxColumn.DataPropertyName = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.HeaderText = "Адрес"
        Me.АдресDataGridViewTextBoxColumn.Name = "АдресDataGridViewTextBoxColumn"
        '
        'ВремяПосещенияDataGridViewTextBoxColumn
        '
        Me.ВремяПосещенияDataGridViewTextBoxColumn.DataPropertyName = "Время посещения"
        Me.ВремяПосещенияDataGridViewTextBoxColumn.HeaderText = "Время посещения"
        Me.ВремяПосещенияDataGridViewTextBoxColumn.Name = "ВремяПосещенияDataGridViewTextBoxColumn"
        '
        'ЗаказDataGridViewTextBoxColumn
        '
        Me.ЗаказDataGridViewTextBoxColumn.DataPropertyName = "Заказ"
        Me.ЗаказDataGridViewTextBoxColumn.HeaderText = "Заказ"
        Me.ЗаказDataGridViewTextBoxColumn.Name = "ЗаказDataGridViewTextBoxColumn"
        '
        'СтоимостьDataGridViewTextBoxColumn
        '
        Me.СтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость"
        Me.СтоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость"
        Me.СтоимостьDataGridViewTextBoxColumn.Name = "СтоимостьDataGridViewTextBoxColumn"
        '
        'DataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 599)
        Me.Controls.Add(Me.ClsAnomTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataBase"
        Me.Text = "База данных"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.КлиентыDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлиентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClsAnomTheme1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClsAnomTheme1 As WindowsApplication1.clsAnomTheme
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents КлиентыDataSet As WindowsApplication1.КлиентыDataSet
    Friend WithEvents КлиентыBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents КлиентыTableAdapter As WindowsApplication1.КлиентыDataSetTableAdapters.КлиентыTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФИОDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НомерТелефонаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents АдресDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВремяПосещенияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЗаказDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СтоимостьDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
