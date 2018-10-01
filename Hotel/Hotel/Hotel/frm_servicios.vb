Public Class frm_servicios

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
        Private Sub frm_instalaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RemoveHandler Me.cmb_hotel.SelectedIndexChanged, AddressOf cmb_hotel_SelectedIndexChanged
            carga_combo(Me.cmb_hotel, Me.leo_tabla("HOTELES"), "nombre_hotel", "hotel")
            cmb_hotel.SelectedIndex = -1
            AddHandler Me.cmb_hotel.SelectedIndexChanged, AddressOf cmb_hotel_SelectedIndexChanged
        Me.cmb_servicio.Enabled = False

        Me.txt_descripcion.Enabled = False
        Me.txt_servicio_reg.Enabled = False
        Me.cmb_hotel_reg.Enabled = False
        Me.txt_precio.Enabled = False

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


    Private Sub cmb_hotel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_hotel.SelectedIndexChanged
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""
        Me.cmb_servicio.Enabled = True
        conexion.ConnectionString = Me.string_conexion
        conexion.Open()

        consulta = "select ins.nombre from SERVICIOS ins"
        consulta &= " join SERVICIOXHOTEL as ih on ih.id_servicio=ins.id_servicio"
        consulta &= " join HOTELES as ho on ho.id_hotel=ih.id_hotel"
        consulta &= " where ho.nombre_hotel= '" & Me.cmb_hotel.SelectedValue & "'"
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta

        tabla.Load(cmd.ExecuteReader)
        conexion.Close()
        cmb_servicio.Items.Clear()
        For index = 0 To tabla.Rows.Count - 1
            cmb_servicio.Items.Add(tabla.Rows(index)("nombre"))
        Next


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        Me.accion = estado.modificar
        Me.BtnGuardar.Enabled = True
        Me.BtnCancelar.Enabled = True
        Me.txt_descripcion.Enabled = True
        Me.txt_precio.Enabled = True
        Me.txt_servicio_reg.Enabled = True
        Me.cmb_hotel_reg.Enabled = False

        If Me.cmb_hotel.SelectedIndex = -1 Then
            MessageBox.Show("Seleccionar hotel", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmb_hotel.Focus()
        Else
            If Me.cmb_servicio.SelectedIndex = -1 Then
                MessageBox.Show("Seleccionar servicio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.cmb_servicio.Focus()
            Else
                conexion.ConnectionString = Me.string_conexion
                conexion.Open()

                consulta = "select se.*, sh.costo,ho.nombre_hotel from SERVICIOS as se"
                consulta &= " join SERVICIOXHOTEL as sh on sh.id_servicio=se.id_servicio"
                consulta &= " join HOTELES as ho on ho.id_hotel=sh.id_hotel"
                consulta &= " where ho.nombre_hotel='" & Me.cmb_hotel.SelectedValue & "'"
                consulta &= " and se.nombre='" & Me.cmb_servicio.SelectedItem & "'"

                cmd.CommandType = CommandType.Text
                cmd.CommandText = consulta
                cmd.Connection = conexion

                tabla.Load(cmd.ExecuteReader())
                conexion.Close()


                carga_combo(Me.cmb_hotel_reg, leo_tabla("HOTELES"), "nombre_hotel", "hotel")
                cmb_hotel_reg.SelectedValue = tabla.Rows(0)("nombre_hotel")
                txt_servicio_reg.Text = tabla.Rows(0)("nombre")
                txt_descripcion.Text = tabla.Rows(0)("descripcion")
                txt_precio.Text = tabla.Rows(0)("costo")

            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Me.accion = estado.insertar
        Me.txt_descripcion.Enabled = True
        Me.txt_servicio_reg.Enabled = True
        Me.cmb_hotel_reg.Enabled = True
        Me.txt_precio.Text = True
        Me.BtnCancelar.Enabled = True
        Me.BtnGuardar.Enabled = True
        RemoveHandler Me.cmb_hotel.SelectedIndexChanged, AddressOf cmb_hotel_SelectedIndexChanged
        carga_combo(Me.cmb_hotel, leo_tabla("HOTELES"), "nombre_hotel", "hotel")
        AddHandler Me.cmb_hotel.SelectedIndexChanged, AddressOf cmb_hotel_SelectedIndexChanged
        cmb_servicio.Items.Clear()
        cmb_servicio.Enabled = False


        carga_combo(Me.cmb_hotel_reg, leo_tabla("HOTELES"), "nombre_hotel", "hotel")
        txt_servicio_reg.Text = ""
        txt_descripcion.Text = ""
        txt_precio.Text = ""
    End Sub

    Private Function validar() As Boolean
        If Me.txt_servicio_reg.Text = "" Then
            MsgBox("El servicio no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txt_servicio_reg.Focus()
            Return False
        End If
        If Me.txt_descripcion.Text = "" Then
            MsgBox("La descripcion no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txt_descripcion.Focus()
            Return False
        End If
        If Me.cmb_hotel_reg.SelectedIndex = -1 Then
            MsgBox("Seleccionar hotel", MsgBoxStyle.Critical, "Importante")
            Me.cmb_hotel_reg.Focus()
            Return False
        End If
        If Me.txt_precio.Text = "" Then
            MsgBox("El precio no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txt_descripcion.Focus()
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
        consulta = "select * from SERVICIOXHOTEL i "
        consulta &= " join HOTELES ho on ho.id_hotel=i.id_hotel"
        consulta &= " join SERVICIOS im on im.id_servicio=i.id_servicio "
        consulta &= " where ho.nombre_hotel='" & Me.cmb_hotel_reg.SelectedValue & "'"
        consulta &= " and im.nombre='" & Me.txt_servicio_reg.Text & "'"
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
                    modificacion &= " select @valor=id_servicio from SERVICIOS"
                    modificacion &= " where id_servicio=(select MAX(id_servicio) from SERVICIOS)"
                    modificacion &= "Declare @valor2 int "
                    modificacion &= " select @valor2=id_hotel from HOTELES"
                    modificacion &= " where nombre_hotel = '" & Me.cmb_hotel_reg.SelectedValue & "'"
                    modificacion &= " insert into SERVICIOS(id_servicio,nombre,descripcion)"
                    modificacion &= " values(@valor+1"
                    modificacion &= ",'" & Me.txt_servicio_reg.Text & "'"
                    modificacion &= ",'" & Me.txt_descripcion.Text & "')"
                    modificacion &= " insert into SERVICIOXHOTEL(id_servicio,id_hotel,costo)"
                    modificacion &= " values (@valor+1"
                    modificacion &= ",@valor2"
                    modificacion &= "," & Me.txt_precio.Text & ")"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = modificacion
                    cmd.Connection = conexion
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Se ha guardado el servicio", "importante", MessageBoxButtons.OK)

                Else
                    MessageBox.Show("Ya existe el servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else

                conexion.ConnectionString = Me.string_conexion
                conexion.Open()

                modificacion = "Declare @valor int "
                modificacion &= " Select @valor = id_servicio FROM SERVICIOS WHERE nombre = '" & Me.cmb_servicio.SelectedItem & "'"
                modificacion &= " Update SERVICIOS "
                modificacion &= " set nombre = '" & Me.txt_servicio_reg.Text & "'"
                modificacion &= " , descripcion = '" & Me.txt_descripcion.Text & "'"
                modificacion &= " where id_servicio = @valor"
                modificacion &= " Declare @valor2 int"
                modificacion &= " select @valor2=id_hotel from HOTELES where nombre_hotel = '" & Me.cmb_hotel.SelectedValue & "'"
                modificacion &= " update SERVICIOXHOTEL"
                modificacion &= " set costo = " & Me.txt_precio.Text
                modificacion &= " where id_hotel = @valor2"
                modificacion &= " and id_servicio = @valor"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = modificacion
                cmd.Connection = conexion
                cmd.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show("Se ha modificado el servicio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim consulta As String = ""
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            Dim conexion As New Data.OleDb.OleDbConnection
            Dim cmd As New Data.OleDb.OleDbCommand
            If accion = estado.modificar Then


                conexion.ConnectionString = Me.string_conexion
                conexion.Open()
                cmd.Connection = conexion

                consulta = "delete imx from SERVICIOXHOTEL imx "
                consulta &= " join SERVICIOS i on i.id_servicio=imx.id_servicio"
                consulta &= " join HOTELES ho on ho.id_hotel=imx.id_hotel"
                consulta &= " where i.nombre='" & Me.txt_servicio_reg.Text & "'"
                consulta &= " and ho.nombre_hotel= '" & Me.cmb_hotel_reg.SelectedValue & "'"
                consulta &= " delete r from SERVICIOS r"
                consulta &= " where nombre='" & Me.txt_servicio_reg.Text & "'"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = consulta
                cmd.ExecuteNonQuery()
                conexion.Close()
                MessageBox.Show("Servicio eliminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
End Class