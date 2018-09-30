Public Class frm_habitacion

    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim accion As estado = estado.modificar
    Dim string_conexion As String = "Provider=SQLOLEDB.1;Password=mercedeslucila;Persist Security Info=True;User ID=sa;Initial Catalog=HOTEL;Data Source=localhost\SQLEXPRESS"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_combo(Me.Cmb_hotel, Me.leo_tabla("HOTELES"), "nombre_hotel", "hotel")
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

    ' PARA SALIRRRR 
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    'PARA BUSCARRR

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        If Me.Txt_nro_habitacion.Text = "" Then
            MessageBox.Show("Ingresar numero de habitación", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Txt_nro_habitacion.Focus()
        Else
            If Me.Cmb_hotel.SelectedIndex = -1 Then
                MessageBox.Show("Seleccionar hotel", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Txt_nro_habitacion.Focus()
            Else
                conexion.ConnectionString = Me.string_conexion
                conexion.Open()

                consulta = "select ha.*,ho.nombre_hotel from HABITACIONES ha join HOTELES ho on ha.id_hotel = ho.id_hotel where ho.nombre_hotel = '" & Me.Cmb_hotel.SelectedValue & "'"
                consulta &= " and ha.id_habitacion = " & Me.Txt_nro_habitacion.Text

                cmd.CommandType = CommandType.Text
                cmd.CommandText = consulta
                cmd.Connection = conexion

                tabla.Load(cmd.ExecuteReader())
                conexion.Close()

                If tabla.Rows.Count() = 0 Then
                    MessageBox.Show("La habitacion no existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else

                    Me.accion = estado.modificar
                    MessageBox.Show("La habitacion exite", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Txt_nombre_habitacion.Enabled = True
                    chebox_disponible.Enabled = True
                    txt_descr_habit.Enabled = True
                    txtNroHab.Enabled = True
                    cmb_hotel_reg.Enabled = True
                    BtnGuardar.Enabled = True
                    BtnCancelar.Enabled = True
                    carga_combo(Me.cmb_hotel_reg, Me.leo_tabla("HOTELES"), "nombre_hotel", "hotel")
                    Txt_nombre_habitacion.Text = tabla.Rows(0)("nombre")
                    txt_descr_habit.Text = tabla.Rows(0)("descripcion")
                    txtNroHab.Text = tabla.Rows(0)("id_habitacion")
                    cmb_hotel_reg.SelectedValue = tabla.Rows(0)("nombre_hotel")

                    If tabla.Rows(0)("disponible") = 1 Then
                        chebox_disponible.Checked = True
                    Else
                        chebox_disponible.Checked = False
                    End If

                End If
            End If
        End If

    End Sub


    'PARA CANCELARR Y BORRARR 

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim consulta As String = ""
        If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            Dim conexion As New Data.OleDb.OleDbConnection
            Dim cmd As New Data.OleDb.OleDbCommand
            If accion = estado.modificar Then


                conexion.ConnectionString = Me.string_conexion
                conexion.Open()
                cmd.Connection = conexion

                consulta = "delete ha from HABITACIONES ha Join HOTELES ho on ha.id_hotel = ho.id_hotel"
                consulta &= "where ha.id_habitacion= "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = consulta
                cmd.ExecuteNonQuery()
                conexion.Close()
            End If
        End If
    End Sub

    'PARA MODIFICARRR

    Private Function validar() As Boolean

        If Me.txtNroHab.Text = "" Then
            MsgBox("El numero de habitacion no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txtNroHab.Focus()
            Return False
        End If
        If Me.Txt_nombre_habitacion.Text = "" Then
            MsgBox("El nombre de la habitacion no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.Txt_nombre_habitacion.Focus()
            Return False
        End If
        If Me.cmb_hotel_reg.SelectedIndex = -1 Then
            MsgBox("El hotel no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.cmb_hotel_reg.Focus()
            Return False
        End If
        If txt_descr_habit.Text = "" Then
            MsgBox("La descripcion no puede estar vacia", MsgBoxStyle.Critical, "Importante")
            Me.txt_descr_habit.Focus()
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
        consulta = "Select * from HABITACIONES ha join HOTELES ho On ha.id_hotel=ho.id_hotel where ho.nombre_hotel = '" & Me.cmb_hotel_reg.SelectedValue & "'"
        consulta &= " and ha.id_habitacion = " & Me.txtNroHab.Text
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
                    Dim disponible As Integer = 0
                    If Me.chebox_disponible.Checked = True Then
                        disponible = 1
                    End If

                    conexion.ConnectionString = Me.string_conexion
                    conexion.Open()
                    modificacion = "DECLARE @valor int "
                    modificacion &= "SELECT @valor = id_hotel FROM HOTELES WHERE nombre_hotel = '" & Me.cmb_hotel_reg.SelectedValue & "'"
                    modificacion &= " insert into HABITACIONES("
                    modificacion &= "id_habitacion,nombre,descripcion,disponible,id_hotel) "
                    modificacion &= "values(" & Me.txtNroHab.Text
                    modificacion &= ",'" & Me.Txt_nombre_habitacion.Text & "'"
                    modificacion &= ",'" & Me.txt_descr_habit.Text & "'"
                    modificacion &= "," & disponible
                    modificacion &= ",@valor)"

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = modificacion
                    cmd.Connection = conexion
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Se ha guardado la habitacion", "importante", MessageBoxButtons.OK)

                Else
                    MessageBox.Show("Ya existe la habitación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                Dim disponible As Integer = 0

                If Me.chebox_disponible.Checked = True Then
                    disponible = 1
                End If

                conexion.ConnectionString = Me.string_conexion
                conexion.Open()

                modificacion = "DECLARE @valor int "
                modificacion &= "SELECT @valor = id_hotel FROM HOTELES WHERE nombre_hotel = '" & Me.cmb_hotel_reg.SelectedValue & "'"
                modificacion &= "Update HABITACIONES "
                modificacion &= "Set id_habitacion = '" & Me.txtNroHab.Text & "'"
                modificacion &= ", nombre = '" & Me.Txt_nombre_habitacion.Text & "'"
                modificacion &= ", descripcion = '" & Me.txt_descr_habit.Text & "'"
                modificacion &= ", disponible = '" & disponible & "'"
                modificacion &= ", id_hotel = @valor"
                modificacion &= " where id_habitacion= " & Me.Txt_nro_habitacion.Text

                cmd.CommandType = CommandType.Text
                cmd.CommandText = modificacion
                cmd.Connection = conexion
                cmd.ExecuteNonQuery()
                conexion.Close()

                MessageBox.Show("Se ha modificado la habitación", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Me.accion = estado.insertar
        Txt_nro_habitacion.Text = ""
        Cmb_hotel.SelectedIndex = -1
        Txt_nombre_habitacion.Enabled = True
        Txt_nombre_habitacion.Text = ""
        chebox_disponible.Enabled = True
        chebox_disponible.Checked = False
        txt_descr_habit.Enabled = True
        txt_descr_habit.Text = ""
        txtNroHab.Enabled = True
        txtNroHab.Text = ""
        cmb_hotel_reg.Enabled = True
        cmb_hotel_reg.SelectedIndex = -1
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        carga_combo(Me.cmb_hotel_reg, Me.leo_tabla("HOTELES"), "nombre_hotel", "hotel")

    End Sub
End Class