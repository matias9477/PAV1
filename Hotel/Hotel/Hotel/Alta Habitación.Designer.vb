<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_habitacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_habitacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_nro_habitacion = New System.Windows.Forms.TextBox()
        Me.Cmb_hotel = New System.Windows.Forms.ComboBox()
        Me.txt_descr_habit = New System.Windows.Forms.TextBox()
        Me.chebox_disponible = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNroHab = New System.Windows.Forms.TextBox()
        Me.Txt_nombre_habitacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_hotel_reg = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.column_hotel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Huesped = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column_habit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "N° Habitación "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hotel "
        '
        'Txt_nro_habitacion
        '
        Me.Txt_nro_habitacion.Location = New System.Drawing.Point(106, 10)
        Me.Txt_nro_habitacion.MaxLength = 3
        Me.Txt_nro_habitacion.Name = "Txt_nro_habitacion"
        Me.Txt_nro_habitacion.Size = New System.Drawing.Size(101, 20)
        Me.Txt_nro_habitacion.TabIndex = 0
        '
        'Cmb_hotel
        '
        Me.Cmb_hotel.FormattingEnabled = True
        Me.Cmb_hotel.Location = New System.Drawing.Point(106, 39)
        Me.Cmb_hotel.Name = "Cmb_hotel"
        Me.Cmb_hotel.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_hotel.TabIndex = 1
        '
        'txt_descr_habit
        '
        Me.txt_descr_habit.Enabled = False
        Me.txt_descr_habit.Location = New System.Drawing.Point(91, 73)
        Me.txt_descr_habit.MaxLength = 500
        Me.txt_descr_habit.Name = "txt_descr_habit"
        Me.txt_descr_habit.Size = New System.Drawing.Size(345, 20)
        Me.txt_descr_habit.TabIndex = 2
        '
        'chebox_disponible
        '
        Me.chebox_disponible.AutoSize = True
        Me.chebox_disponible.Enabled = False
        Me.chebox_disponible.Location = New System.Drawing.Point(18, 99)
        Me.chebox_disponible.Name = "chebox_disponible"
        Me.chebox_disponible.Size = New System.Drawing.Size(78, 17)
        Me.chebox_disponible.TabIndex = 7
        Me.chebox_disponible.Text = "Disponible "
        Me.chebox_disponible.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "N° Habitación "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre Habitación"
        '
        'txtNroHab
        '
        Me.txtNroHab.Enabled = False
        Me.txtNroHab.Location = New System.Drawing.Point(91, 44)
        Me.txtNroHab.MaxLength = 3
        Me.txtNroHab.Name = "txtNroHab"
        Me.txtNroHab.Size = New System.Drawing.Size(101, 20)
        Me.txtNroHab.TabIndex = 1
        '
        'Txt_nombre_habitacion
        '
        Me.Txt_nombre_habitacion.Enabled = False
        Me.Txt_nombre_habitacion.Location = New System.Drawing.Point(325, 44)
        Me.Txt_nombre_habitacion.MaxLength = 10
        Me.Txt_nombre_habitacion.Name = "Txt_nombre_habitacion"
        Me.Txt_nombre_habitacion.Size = New System.Drawing.Size(111, 20)
        Me.Txt_nombre_habitacion.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Hotel "
        '
        'cmb_hotel_reg
        '
        Me.cmb_hotel_reg.Enabled = False
        Me.cmb_hotel_reg.FormattingEnabled = True
        Me.cmb_hotel_reg.Location = New System.Drawing.Point(79, 13)
        Me.cmb_hotel_reg.Name = "cmb_hotel_reg"
        Me.cmb_hotel_reg.Size = New System.Drawing.Size(121, 21)
        Me.cmb_hotel_reg.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Descripcion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb_hotel_reg)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_nombre_habitacion)
        Me.GroupBox1.Controls.Add(Me.txtNroHab)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chebox_disponible)
        Me.GroupBox1.Controls.Add(Me.txt_descr_habit)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 131)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habitacion"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(251, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(39, 39)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(30, 425)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(41, 36)
        Me.BtnNuevo.TabIndex = 3
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(86, 425)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(147, 425)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(37, 38)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(465, 423)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(39, 43)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column_hotel, Me.Huesped, Me.column_habit})
        Me.DataGridView1.Location = New System.Drawing.Point(45, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'column_hotel
        '
        Me.column_hotel.HeaderText = "hotel"
        Me.column_hotel.Name = "column_hotel"
        '
        'Huesped
        '
        Me.Huesped.HeaderText = "Column_huesped"
        Me.Huesped.Name = "Huesped"
        '
        'column_habit
        '
        Me.column_habit.HeaderText = "Habitacion"
        Me.column_habit.Name = "column_habit"
        '
        'frm_habitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 477)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cmb_hotel)
        Me.Controls.Add(Me.Txt_nro_habitacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_habitacion"
        Me.Text = "Habitaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_nro_habitacion As TextBox
    Friend WithEvents Cmb_hotel As ComboBox
    Friend WithEvents txt_descr_habit As TextBox
    Friend WithEvents chebox_disponible As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNroHab As TextBox
    Friend WithEvents Txt_nombre_habitacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_hotel_reg As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents column_hotel As DataGridViewTextBoxColumn
    Friend WithEvents Huesped As DataGridViewTextBoxColumn
    Friend WithEvents column_habit As DataGridViewTextBoxColumn
End Class
