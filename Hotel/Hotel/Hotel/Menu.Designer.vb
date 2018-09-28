<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.btn_habitaciones = New System.Windows.Forms.Button()
        Me.btn_huespedes = New System.Windows.Forms.Button()
        Me.btn_hotel = New System.Windows.Forms.Button()
        Me.btn_instalaciones = New System.Windows.Forms.Button()
        Me.btn_servicios = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_habitaciones
        '
        Me.btn_habitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_habitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_habitaciones.Image = CType(resources.GetObject("btn_habitaciones.Image"), System.Drawing.Image)
        Me.btn_habitaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_habitaciones.Location = New System.Drawing.Point(12, 9)
        Me.btn_habitaciones.Name = "btn_habitaciones"
        Me.btn_habitaciones.Size = New System.Drawing.Size(120, 135)
        Me.btn_habitaciones.TabIndex = 0
        Me.btn_habitaciones.Text = "Habitaciones"
        Me.btn_habitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_habitaciones.UseVisualStyleBackColor = True
        '
        'btn_huespedes
        '
        Me.btn_huespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huespedes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huespedes.Image = CType(resources.GetObject("btn_huespedes.Image"), System.Drawing.Image)
        Me.btn_huespedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_huespedes.Location = New System.Drawing.Point(12, 150)
        Me.btn_huespedes.Name = "btn_huespedes"
        Me.btn_huespedes.Size = New System.Drawing.Size(120, 135)
        Me.btn_huespedes.TabIndex = 3
        Me.btn_huespedes.Text = "Huespedes"
        Me.btn_huespedes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_huespedes.UseVisualStyleBackColor = True
        '
        'btn_hotel
        '
        Me.btn_hotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hotel.Image = CType(resources.GetObject("btn_hotel.Image"), System.Drawing.Image)
        Me.btn_hotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hotel.Location = New System.Drawing.Point(138, 150)
        Me.btn_hotel.Name = "btn_hotel"
        Me.btn_hotel.Size = New System.Drawing.Size(120, 135)
        Me.btn_hotel.TabIndex = 4
        Me.btn_hotel.Text = "Hotel"
        Me.btn_hotel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_hotel.UseVisualStyleBackColor = True
        '
        'btn_instalaciones
        '
        Me.btn_instalaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_instalaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_instalaciones.Image = CType(resources.GetObject("btn_instalaciones.Image"), System.Drawing.Image)
        Me.btn_instalaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_instalaciones.Location = New System.Drawing.Point(138, 9)
        Me.btn_instalaciones.Name = "btn_instalaciones"
        Me.btn_instalaciones.Size = New System.Drawing.Size(120, 135)
        Me.btn_instalaciones.TabIndex = 1
        Me.btn_instalaciones.Text = "Instalaciones"
        Me.btn_instalaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_instalaciones.UseVisualStyleBackColor = True
        '
        'btn_servicios
        '
        Me.btn_servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_servicios.Image = CType(resources.GetObject("btn_servicios.Image"), System.Drawing.Image)
        Me.btn_servicios.Location = New System.Drawing.Point(264, 9)
        Me.btn_servicios.Name = "btn_servicios"
        Me.btn_servicios.Size = New System.Drawing.Size(120, 135)
        Me.btn_servicios.TabIndex = 2
        Me.btn_servicios.Text = "Servicios"
        Me.btn_servicios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_servicios.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(264, 150)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(120, 135)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 295)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_habitaciones)
        Me.Controls.Add(Me.btn_huespedes)
        Me.Controls.Add(Me.btn_hotel)
        Me.Controls.Add(Me.btn_instalaciones)
        Me.Controls.Add(Me.btn_servicios)
        Me.Name = "frm_menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_servicios As Button
    Friend WithEvents btn_instalaciones As Button
    Friend WithEvents btn_hotel As Button
    Friend WithEvents btn_huespedes As Button
    Friend WithEvents btn_habitaciones As Button
    Friend WithEvents btn_salir As Button
End Class
