<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_nro_habitacion = New System.Windows.Forms.TextBox()
        Me.Txt_nombre_habitacion = New System.Windows.Forms.TextBox()
        Me.chebox_disponible = New System.Windows.Forms.CheckBox()
        Me.Cmb_hoteles = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_descr_habit = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Habitación "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Habitación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hotel "
        '
        'Txt_nro_habitacion
        '
        Me.Txt_nro_habitacion.Location = New System.Drawing.Point(106, 49)
        Me.Txt_nro_habitacion.Name = "Txt_nro_habitacion"
        Me.Txt_nro_habitacion.Size = New System.Drawing.Size(101, 20)
        Me.Txt_nro_habitacion.TabIndex = 9
        '
        'Txt_nombre_habitacion
        '
        Me.Txt_nombre_habitacion.Location = New System.Drawing.Point(378, 49)
        Me.Txt_nombre_habitacion.Name = "Txt_nombre_habitacion"
        Me.Txt_nombre_habitacion.Size = New System.Drawing.Size(111, 20)
        Me.Txt_nombre_habitacion.TabIndex = 10
        '
        'chebox_disponible
        '
        Me.chebox_disponible.AutoSize = True
        Me.chebox_disponible.Location = New System.Drawing.Point(22, 93)
        Me.chebox_disponible.Name = "chebox_disponible"
        Me.chebox_disponible.Size = New System.Drawing.Size(78, 17)
        Me.chebox_disponible.TabIndex = 11
        Me.chebox_disponible.Text = "Disponible "
        Me.chebox_disponible.UseVisualStyleBackColor = True
        '
        'Cmb_hoteles
        '
        Me.Cmb_hoteles.FormattingEnabled = True
        Me.Cmb_hoteles.Location = New System.Drawing.Point(86, 10)
        Me.Cmb_hoteles.Name = "Cmb_hoteles"
        Me.Cmb_hoteles.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_hoteles.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_descr_habit)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripción"
        '
        'txt_descr_habit
        '
        Me.txt_descr_habit.Location = New System.Drawing.Point(6, 19)
        Me.txt_descr_habit.Name = "txt_descr_habit"
        Me.txt_descr_habit.Size = New System.Drawing.Size(424, 20)
        Me.txt_descr_habit.TabIndex = 0
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(194, 246)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(39, 39)
        Me.BtnBuscar.TabIndex = 16
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(443, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(139, 246)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(37, 38)
        Me.BtnCancelar.TabIndex = 19
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(86, 246)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(25, 246)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(41, 36)
        Me.BtnNuevo.TabIndex = 17
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 307)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cmb_hoteles)
        Me.Controls.Add(Me.chebox_disponible)
        Me.Controls.Add(Me.Txt_nombre_habitacion)
        Me.Controls.Add(Me.Txt_nro_habitacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_nro_habitacion As TextBox
    Friend WithEvents Txt_nombre_habitacion As TextBox
    Friend WithEvents chebox_disponible As CheckBox
    Friend WithEvents Cmb_hoteles As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_descr_habit As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
End Class
