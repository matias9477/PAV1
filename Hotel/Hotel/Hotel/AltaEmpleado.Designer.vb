﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_nro_doc = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmb_hotel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbPuesto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Txt_nombre = New System.Windows.Forms.TextBox()
        Me.Txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nro_doc_reg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc_reg = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Documento"
        '
        'Cmb_tipo_doc
        '
        Me.Cmb_tipo_doc.FormattingEnabled = True
        Me.Cmb_tipo_doc.Location = New System.Drawing.Point(104, 6)
        Me.Cmb_tipo_doc.Name = "Cmb_tipo_doc"
        Me.Cmb_tipo_doc.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_tipo_doc.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° Documento"
        '
        'Txt_nro_doc
        '
        Me.Txt_nro_doc.Location = New System.Drawing.Point(105, 38)
        Me.Txt_nro_doc.MaxLength = 10
        Me.Txt_nro_doc.Name = "Txt_nro_doc"
        Me.Txt_nro_doc.Size = New System.Drawing.Size(120, 20)
        Me.Txt_nro_doc.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(262, 9)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(42, 44)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_hotel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CmbPuesto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc_reg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_doc_reg)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 152)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleado"
        '
        'Cmb_hotel
        '
        Me.Cmb_hotel.Enabled = False
        Me.Cmb_hotel.FormattingEnabled = True
        Me.Cmb_hotel.Location = New System.Drawing.Point(58, 107)
        Me.Cmb_hotel.Name = "Cmb_hotel"
        Me.Cmb_hotel.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_hotel.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Hotel"
        '
        'CmbPuesto
        '
        Me.CmbPuesto.Enabled = False
        Me.CmbPuesto.FormattingEnabled = True
        Me.CmbPuesto.Location = New System.Drawing.Point(353, 107)
        Me.CmbPuesto.Name = "CmbPuesto"
        Me.CmbPuesto.Size = New System.Drawing.Size(121, 21)
        Me.CmbPuesto.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(299, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Puesto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Fecha Ingreso"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "yyyyMMdd"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 81)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Enabled = False
        Me.Txt_nombre.Location = New System.Drawing.Point(312, 17)
        Me.Txt_nombre.MaxLength = 20
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.Size = New System.Drawing.Size(162, 20)
        Me.Txt_nombre.TabIndex = 1
        '
        'Txt_apellido
        '
        Me.Txt_apellido.Enabled = False
        Me.Txt_apellido.Location = New System.Drawing.Point(58, 20)
        Me.Txt_apellido.MaxLength = 20
        Me.Txt_apellido.Name = "Txt_apellido"
        Me.Txt_apellido.Size = New System.Drawing.Size(162, 20)
        Me.Txt_apellido.TabIndex = 0
        '
        'txt_nro_doc_reg
        '
        Me.txt_nro_doc_reg.Enabled = False
        Me.txt_nro_doc_reg.Location = New System.Drawing.Point(345, 48)
        Me.txt_nro_doc_reg.MaxLength = 10
        Me.txt_nro_doc_reg.Name = "txt_nro_doc_reg"
        Me.txt_nro_doc_reg.Size = New System.Drawing.Size(129, 20)
        Me.txt_nro_doc_reg.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "N° Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido"
        '
        'cmb_tipo_doc_reg
        '
        Me.cmb_tipo_doc_reg.Enabled = False
        Me.cmb_tipo_doc_reg.FormattingEnabled = True
        Me.cmb_tipo_doc_reg.Location = New System.Drawing.Point(99, 48)
        Me.cmb_tipo_doc_reg.Name = "cmb_tipo_doc_reg"
        Me.cmb_tipo_doc_reg.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_doc_reg.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Tipo Documento"
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(470, 252)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(39, 43)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(133, 261)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(35, 36)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(80, 259)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(19, 259)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(41, 36)
        Me.BtnNuevo.TabIndex = 3
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'AltaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 313)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Txt_nro_doc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cmb_tipo_doc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AltaEmpleado"
        Me.Text = "Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_tipo_doc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_nro_doc As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cmb_hotel As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbPuesto As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Txt_nombre As TextBox
    Friend WithEvents Txt_apellido As TextBox
    Friend WithEvents txt_nro_doc_reg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tipo_doc_reg As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
End Class
