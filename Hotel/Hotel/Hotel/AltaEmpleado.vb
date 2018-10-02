﻿Public Class AltaEmpleado
    Enum estado
        insertar
        modificar
    End Enum

    Dim accion As estado = estado.modificar
    Dim string_conexion As String = "Provider=SQLOLEDB.1;Password=mercedeslucila;Persist Security Info=True;User ID=sa;Initial Catalog=HOTEL;Data Source=localhost\SQLEXPRESS"

    Private Sub frm_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_combo(Me.CmbPuesto, Me.leo_tabla("Puestos"), "id_puesto", "puesto")
        carga_combo(Me.Cmb_hotel, Me.leo_tabla("Hotel"), "id_hotel", "hotel")
        carga_combo(Me.Cmb_tipo_doc, Me.leo_tabla("TIPOSDOCUMENTOS"), "nombre", "tipodocumento")
        carga_combo(Me.cmb_tipo_doc_reg, Me.leo_tabla("TIPOSDOCUMENTOS"), "nombre", "tipodocumento")
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
            End If
            If TypeOf objeto Is ComboBox Then
                Dim actual As ComboBox = objeto
                actual.SelectedIndex = -1
            End If
        Next
    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
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

    'PARA BUSCARRR

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
                MessageBox.Show("Seleccionar hotel", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Cmb_tipo_doc.Focus()
            Else
                conexion.ConnectionString = Me.string_conexion
                conexion.Open()

                consulta = "select m.*,h.nombre_hotel,p.descripcion from EMPLEADOS m "
                consulta &= "join TIPOSDOCUMENTOS t on m.tipo_doc=t.id_tipo_doc "
                consulta &= "join HOTELES h on h.id_hotel=m.id_hotel "
                consulta &= "join PUESTOS p on p.id_puesto=m.id_puesto "
                consulta &= "where m.num_doc= '" & Me.Txt_nro_doc.Text & "'"
                consulta &= " and  t.nombre = '" & Me.Cmb_tipo_doc.SelectedValue & "'"


                cmd.CommandType = CommandType.Text
                cmd.CommandText = consulta
                cmd.Connection = conexion

                tabla.Load(cmd.ExecuteReader())
                conexion.Close()

                If tabla.Rows.Count() = 0 Then
                    MessageBox.Show("El empleado no existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    Me.BtnBuscar.Enabled = False
                    Txt_nombre.Enabled = True
                    Txt_apellido.Enabled = True
                    Cmb_hotel.Enabled = True
                    cmb_tipo_doc_reg.Enabled = True
                    DateTimePicker1.Enabled = True
                    CmbPuesto.Enabled = True
                    MessageBox.Show("El empleado existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    BtnGuardar.Enabled = True
                    BtnCancelar.Enabled = True
                    carga_combo(Me.cmb_tipo_doc_reg, Me.leo_tabla("TIPOSDOCUMENTOS"), "nombre", "tipodocumento")
                    carga_combo(Me.CmbPuesto, Me.leo_tabla("PUESTOS"), "descripcion", "puesto")
                    carga_combo(Me.Cmb_hotel, Me.leo_tabla("HOTELES"), "nombre_hotel", "hotel")
                    Txt_nombre.Text = tabla.Rows(0)("nombre")
                    Txt_nro_doc.Text = tabla.Rows(0)("num_doc")
                    Txt_apellido.Text = tabla.Rows(0)("apellido")
                    Cmb_tipo_doc.SelectedValue = tabla.Rows(0)("tipo_doc")
                    Cmb_hotel.SelectedValue = tabla.Rows(0)("nombre_hotel")
                    CmbPuesto.SelectedValue = tabla.Rows(0)("descripcion")

                End If
            End If
        End If

    End Sub

    ' PARA SALIRRRR 
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "Importante",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) =
            Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim consulta As String = ""
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            Dim conexion As New Data.OleDb.OleDbConnection
            Dim cmd As New Data.OleDb.OleDbCommand
            conexion.ConnectionString = Me.string_conexion
            conexion.Open()
            cmd.Connection = conexion

            consulta = "delete from EMPLEADOS where id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
            consulta &= " and nro_doc = " & Me.Txt_nro_doc.Text & "'"

            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show("Empleado eliminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        carga_combo(Me.CmbPuesto, Me.leo_tabla("Puestos"), "id_puesto", "puesto")
        carga_combo(Me.Cmb_hotel, Me.leo_tabla("Hotel"), "id_hotel", "hotel")
        carga_combo(Me.Cmb_tipo_doc, Me.leo_tabla("TIPOSDOCUMENTOS"), "nombre", "tipodocumento")
        carga_combo(Me.cmb_tipo_doc_reg, Me.leo_tabla("TIPOSDOCUMENTOS"), "nombre", "tipodocumento")
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
            End If
            If TypeOf objeto Is ComboBox Then
                Dim actual As ComboBox = objeto
                actual.SelectedIndex = -1
            End If
        Next

    End Sub

    Private Function validar() As Boolean

        If Me.Txt_nombre.Text = "" Then
            MsgBox("El nombre no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Txt_apellido.Focus()
            Return False
        End If
        If Me.Txt_apellido.Text = "" Then
            MsgBox("El apellido no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Txt_apellido.Focus()
            Return False
        End If
        If Me.cmb_tipo_doc_reg.SelectedIndex = -1 Then
            MsgBox("El tipo de documento no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Cmb_tipo_doc.Focus()
            Return False
        End If
        If Txt_nro_doc.Text = "" Then
            MsgBox("El numero de documento no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Txt_nro_doc.Focus()
            Return False
        End If

        If (Me.DateTimePicker1.Value) > (System.DateTime.Now) Then ''''ver si funciona
            MsgBox("La fecha ingresada debe ser menor o igual a la fecha actual.", MsgBoxStyle.Critical, "Importante")
            Return False
        End If

        If Me.Cmb_hotel.SelectedIndex = -1 Then
            MsgBox("El hotel no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Cmb_hotel.Focus()
            Return False
        End If

        If Me.CmbPuesto.SelectedIndex = -1 Then
            MsgBox("El puesto no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.CmbPuesto.Focus()
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
        consulta = "Select * from EMPLEADOS where id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
        consulta &= " and nro_doc = " & Me.Txt_nro_doc.Text & "'"
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

                    modificacion = "Update Empleado "
                    modificacion &= "Set nombre = '" & Me.Txt_nombre.Text & "'"
                    modificacion &= ", apellido = '" & Me.Txt_apellido.Text & "'"
                    modificacion &= ", id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
                    modificacion &= ", nro_doc = '" & Me.Txt_nro_doc.Text & "'"
                    modificacion &= ", fecha_ingreso = " & Me.DateTimePicker1.Text & "'"
                    modificacion &= ", id_hotel = " & Me.Cmb_hotel.SelectedValue
                    modificacion &= ", id_puesto = " & Me.CmbPuesto.SelectedValue
                    modificacion &= " where id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue & "'"

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = modificacion
                    cmd.Connection = conexion
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Se ha guardado el empleado.", "importante", MessageBoxButtons.OK)

                Else
                    MessageBox.Show("Ya exite dicho empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conexion.ConnectionString = Me.string_conexion
                conexion.Open()

                modificacion = "Update Empleado "
                modificacion &= "Set nombre = '" & Me.Txt_nombre.Text & "'"
                modificacion &= ", apellido = '" & Me.Txt_apellido.Text & "'"
                modificacion &= ", id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
                modificacion &= ", nro_doc = '" & Me.Txt_nro_doc.Text & "'"
                modificacion &= ", fecha_ingreso = " & Me.DateTimePicker1.Text & "'"
                modificacion &= ", id_hotel = " & Me.Cmb_hotel.SelectedValue
                modificacion &= ", id_puesto = " & Me.CmbPuesto.SelectedValue
                modificacion &= " where id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue & "'"

                cmd.CommandType = CommandType.Text
                cmd.CommandText = modificacion
                cmd.Connection = conexion
                cmd.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show("Se ha modificado el empleado.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If
    End Sub


End Class