Public Class frm_Huesped
    Dim string_conexion As String = "Provider=SQLOLEDB.1;Password=mercedeslucila;Persist Security Info=True;User ID=sa;Initial Catalog=HOTEL;Data Source=localhost\SQLEXPRESS"
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim accion As estado = estado.modificar
    Private Sub frm_Huesped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.accion = estado.modificar
        Me.BtnNuevo.Enabled = True
        Me.BtnCancelar.Enabled = False
        Me.BtnGuardar.Enabled = False
        Me.txt_nro_doc_reg.Enabled = False
        Me.TxtNroTarjeta.Enabled = False
        Me.TxtApellido.Enabled = False
        Me.TxtNombre.Enabled = False
        Me.cmb_tipo_doc_reg.Enabled = False
        Me.txt_ciudad.Enabled = False

        Me.txt_numero_hab.Enabled = False
        Me.cmb_hotel.Enabled = False


        carga_combo(Me.Cmb_tipo_doc, leo_tabla("TIPOSDOCUMENTOS"), "nombre_tipo", "nombres")
    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        If (combo.Items.Count > 0) Then
            combo.SelectedIndex = -1
        Else
            combo.Items.Clear()
            combo.DataSource = datos
            combo.ValueMember = pk
            combo.DisplayMember = descripcion
        End If

    End Sub

    Private Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from " & nombre_tabla

        tabla.Load(cmd.ExecuteReader)
        Return tabla

    End Function

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        If Me.Txt_nro_doc.Text = "" Then
            MessageBox.Show("Ingresar numero de documento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Txt_nro_doc.Focus()
        Else
            If Me.Cmb_tipo_doc.SelectedIndex = -1 Then
                MessageBox.Show("Seleccionar tipo documento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Cmb_tipo_doc.Focus()
            Else
                conexion.ConnectionString = Me.string_conexion
                conexion.Open()
                consulta = "select h.*,t.nombre_tipo,l.id_hotel,l.id_habitacion, o.fecha_alojamiento, ho.nombre_hotel from HUESPEDES h "
                consulta &= " join TIPOSDOCUMENTOS t on t.id_tipo_doc= h.tipo_doc "
                consulta &= " join HUESPEDXHABITACION o on o.pasaporte=h.num_doc "
                consulta &= " join HABITACIONES l on l.id_habitacion=o.id_habitacion "
                consulta &= " join HOTELES ho on ho.id_hotel=o.id_hotel "
                consulta &= " where h.num_doc= " & Me.Txt_nro_doc.Text
                consulta &= " And  t.nombre_tipo = '" & Me.Cmb_tipo_doc.SelectedValue & "'"

                cmd.CommandType = CommandType.Text
                cmd.CommandText = consulta
                cmd.Connection = conexion

                tabla.Load(cmd.ExecuteReader())
                conexion.Close()

                If tabla.Rows.Count() = 0 Then
                    MessageBox.Show("El huesped no existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    MessageBox.Show("El empleado existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.BtnCancelar.Enabled = True
                    Me.BtnGuardar.Enabled = True
                    Me.txt_nro_doc_reg.Enabled = True
                    Me.TxtNroTarjeta.Enabled = True
                    Me.TxtApellido.Enabled = True
                    Me.TxtNombre.Enabled = True
                    Me.cmb_tipo_doc_reg.Enabled = True
                    Me.txt_ciudad.Enabled = True
                    BtnNuevo.Enabled = True
                    carga_combo(Me.cmb_tipo_doc_reg, leo_tabla("TIPOSDOCUMENTOS"), "nombre_tipo", "nombres")
                    carga_combo(Me.cmb_hotel, Me.leo_tabla("HOTELES"), "nombre_hotel", "hotel")
                    TxtNombre.Text = tabla.Rows(0)("nombre")
                    TxtApellido.Text = tabla.Rows(0)("apellido")
                    cmb_tipo_doc_reg.SelectedValue = tabla.Rows(0)("nombre_tipo")
                    txt_nro_doc_reg.Text = tabla.Rows(0)("num_doc")
                    txt_ciudad.Text = tabla.Rows(0)("ciudad")
                    TxtNroTarjeta.Text = tabla.Rows(0)("numero_tarjeta")
                    txt_numero_hab.Text = tabla.Rows(0)("id_habitacion")
                    cmb_hotel.SelectedValue = tabla.Rows(0)("nombre_hotel")
                    DateTimePicker2.Value = tabla.Rows(0)("fecha_alojamiento")

                End If
            End If
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            Dim conexion As New Data.OleDb.OleDbConnection
            Dim cmd As New Data.OleDb.OleDbCommand
            Dim consulta As String = ""
            conexion.ConnectionString = Me.string_conexion
            conexion.Open()
            consulta = "delete imx from HUESPEDES imx"
            consulta &= " join TIPOSDOCUMENTOS t on t.id_tipo_doc=imx.tipo_doc"
            consulta &= " where imx.num_doc=" & Me.Txt_nro_doc.Text
            consulta &= " and t.nombre_tipo='" & Me.Cmb_tipo_doc.SelectedValue & "'"
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = consulta
            ' "and nro_doc = " & Me.Txt_nro_doc.Text

            cmd.ExecuteNonQuery()
            conexion.Close()

        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
            End If
            If TypeOf objeto Is ComboBox Then
                Dim actual As ComboBox = objeto
                actual.SelectedIndex = -1
            End If
        Next
        carga_combo(Me.cmb_tipo_doc_reg, leo_tabla("TIPOSDOCUMENTOS"), "nombre_tipo", "nombre")
        Me.accion = estado.insertar
        Me.BtnNuevo.Enabled = True
        Me.BtnCancelar.Enabled = True
        Me.BtnGuardar.Enabled = True
        Me.txt_nro_doc_reg.Enabled = True
        Me.txt_nro_doc_reg.Text = ""
        Me.TxtNroTarjeta.Enabled = True
        Me.TxtNroTarjeta.Text = ""
        Me.TxtApellido.Enabled = True
        Me.TxtApellido.Text = ""
        Me.TxtNombre.Enabled = True
        Me.TxtNombre.Text = ""
        Me.cmb_tipo_doc_reg.Enabled = True
        Me.cmb_tipo_doc_reg.SelectedIndex = -1
        Me.txt_ciudad.Enabled = True
        Me.txt_ciudad.Text = ""
    End Sub

    Private Function validar() As Boolean

        If Me.TxtNombre.Text = "" Then
            MsgBox("El nombre no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.TxtNombre.Focus()
            Return False
        End If
        If Me.TxtApellido.Text = "" Then
            MsgBox("El apellido no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.TxtApellido.Focus()
            Return False
        End If
        If Me.cmb_tipo_doc_reg.SelectedIndex = -1 Then
            MsgBox("El tipo de documento no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Cmb_tipo_doc.Focus()
            Return False
        End If
        If txt_nro_doc_reg.Text = "" Then
            MsgBox("El numero de documento no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Txt_nro_doc.Focus()
            Return False
        End If

        If Me.txt_ciudad.Text = "" Then
            MsgBox("La ciudad no puede estar vacia", MsgBoxStyle.Critical, "Importante")
            Me.txt_ciudad.Focus()
            Return False
        End If

        If Me.TxtNroTarjeta.Text = "" Then
            MsgBox("El numero de tarjeta no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.TxtNroTarjeta.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function validar_existencia() As Boolean
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        consulta = "Select * from HUESPEDES m "
        consulta &= " join TIPOSDOCUMENTOS t on t.id_tipo_doc=m.tipo_doc"
        consulta &= " where t.nombre_tipo = '" & cmb_tipo_doc_reg.SelectedValue & "'"
        consulta &= " and num_doc = '" & Me.txt_nro_doc_reg.Text & "'"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion

        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        If tabla.Rows.Count() = 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim modificacion As String = ""
        If validar() Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = True Then
                    conexion.ConnectionString = Me.string_conexion
                    conexion.Open()
                    modificacion = "Declare @valor int "
                    modificacion &= " select @valor=id_tipo_doc from TIPOSDOCUMENTOS"
                    modificacion &= " where nombre_tipo= '" & Me.cmb_tipo_doc_reg.SelectedValue & "'"
                    modificacion &= " insert into HUESPEDES(tipo_doc,num_doc,nombre,apellido,ciudad,numero_tarjeta)"
                    modificacion &= " values(@valor"
                    modificacion &= "," & Me.txt_nro_doc_reg.Text
                    modificacion &= ",'" & Me.TxtNombre.Text & "'"
                    modificacion &= ",'" & Me.TxtApellido.Text & "'"
                    modificacion &= ",'" & Me.txt_ciudad.Text & "'"
                    modificacion &= "," & Me.TxtNroTarjeta.Text & ")"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = modificacion
                    cmd.Connection = conexion
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Se ha guardado el empleado", "importante", MessageBoxButtons.OK)

                Else
                    MessageBox.Show("Ya existe el empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else

                conexion.ConnectionString = Me.string_conexion
                conexion.Open()

                modificacion = "Declare @valor int "
                modificacion &= " select @valor=id_tipo_doc from TIPOSDOCUMENTOS"
                modificacion &= " where nombre_tipo= '" & Me.Cmb_tipo_doc.SelectedValue & "'"
                modificacion &= " Declare @valor2 int "
                modificacion &= " select @valor2=id_tipo_doc from TIPOSDOCUMENTOS"
                modificacion &= " where nombre_tipo= '" & Me.cmb_tipo_doc_reg.SelectedValue & "'"
                modificacion &= " Update HUESPEDES "
                modificacion &= " Set nombre = '" & Me.TxtNombre.Text & "'"
                modificacion &= ", apellido = '" & Me.TxtApellido.Text & "'"
                modificacion &= ", tipo_doc = @valor2"
                modificacion &= ", nUM_doc = '" & Me.Txt_nro_doc.Text & "'"
                modificacion &= ", ciudad = '" & Me.txt_ciudad.Text & "'"
                modificacion &= ", numero_tarjeta = " & Me.TxtNroTarjeta.Text
                modificacion &= " where tipo_doc = @valor "
                modificacion &= " and num_doc =" & Me.Txt_nro_doc.Text
                cmd.CommandType = CommandType.Text
                cmd.CommandText = modificacion
                cmd.Connection = conexion
                cmd.ExecuteNonQuery()
                conexion.Close()
                MessageBox.Show("Se ha modificado el Huesped", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
