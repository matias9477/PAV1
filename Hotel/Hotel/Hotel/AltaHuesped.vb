Public Class frm_Huesped
    Private Sub frm_Huesped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''AGREGAR LA CADENA DE CONEXION!!!!!
    Dim string_conexion As String = "Provider=SQLOLEDB.1;Password=mercedeslucila;Persist Security Info=True;User ID=sa;Initial Catalog=HOTEL;Data Source=localhost\SQLEXPRESS"


    'Private Sub AltaHuesped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    carga_combo(Me.Cmb_tipo_doc, Me.leo_tabla("Tipo_Doc"), "id_tipo_doc", "tipo_doc")
    'End Sub


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

    ''PARA BUSCARRR

    'Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
    '    Dim conexion As New Data.OleDb.OleDbConnection
    '    Dim cmd As New Data.OleDb.OleDbCommand
    '    Dim consulta As String = ""
    '    Dim tabla As New Data.DataTable

    '    conexion.ConnectionString = Me.string_conexion
    '    conexion.Open()

    '    consulta = "select * from huesped where id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
    '    consulta &= "and nro_doc = " & Me.Txt_nro_doc.Text

    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = consulta
    '    cmd.Connection = conexion

    '    tabla.Load(cmd.ExecuteReader())
    '    conexion.Close()

    '    If tabla.Rows.Count() = 0 Then
    '        MessageBox.Show("El huesped no existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '    Else
    '        MessageBox.Show("El empleado existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        TxtNombre.Enabled = True
    '        TxtApellido.Enabled = True
    '        cmbTipoDoc.Enabled = True
    '        txt_nro_docum.Enabled = True
    '        CmbCiudad.Enabled = True
    '        CmbTipoTarjeta.Enabled = True
    '        TxtNroTarjeta.Enabled = True
    '        BtnGuardar.Enabled = True
    '        BtnCancelar.Enabled = True
    '        BtnNuevo.Enabled = True

    '        TxtNombre.Text = tabla.Rows(0)("nombre")
    '        TxtApellido.Text = tabla.Rows(0)("apellido")
    '        cmbTipoDoc.SelectedValue = tabla.Rows(0)("is_tipo_doc")
    '        CmbTipoTarjeta.SelectedValue = tabla.Rows(0)("id_tipo_tarjeta")
    '        CmbCiudad.SelectedValue = tabla.Rows(0)("id_ciudad")
    '        TxtNroTarjeta.Text = tabla.Rows(0)("numero_tarjeta")

    '    End If
    'End Sub


    ''' PARA SALIRRRR 
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
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

    ''PARA CANCELARR Y BORRARR 
    'Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

    '    If MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

    '        Dim conexion As New Data.OleDb.OleDbConnection
    '        Dim cmd As New Data.OleDb.OleDbCommand
    '        conexion.ConnectionString = Me.string_conexion
    '        conexion.Open()
    '        cmd.Connection = conexion
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "delete from huesped where  where id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
    '        ' "and nro_doc = " & Me.Txt_nro_doc.Text

    '        cmd.ExecuteNonQuery()
    '        conexion.Close()

    '    End If
    'End Sub

    ''COMO SE HACEEEEEEEE
    ''Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

    ''For Each objeto As System.Windows.Forms.Control In Me.Controls
    ''If TypeOf objeto Is TextBox Then
    ''           objeto.Text = ""
    ''End If
    ''If TypeOf objeto Is ComboBox Then
    ''Dim actual As ComboBox = objeto
    ''           actual.SelectedIndex = -1
    ''End If
    ''Next
    ''
    ''Me.txt_documento.Enabled = True
    ''Me 'Txt_apellido.Focus()
    ''Me.accion = estado.insertar

    ''End Sub

    ''PARA MODIFICARRR

    'Private Function validar() As Boolean

    '    If Me.TxtNombre.Text = "" Then
    '        MsgBox("El nombre no puede estar vacio", MsgBoxStyle.Critical, "Importante")
    '        Me.TxtNombre.Focus()
    '        Return False
    '    End If
    '    If Me.TxtApellido.Text = "" Then
    '        MsgBox("El apellido no puede estar vacio", MsgBoxStyle.Critical, "Importante")
    '        Me.TxtApellido.Focus()
    '        Return False
    '    End If
    '    If Me.Cmb_tipo_doc.SelectedIndex = -1 Then
    '        MsgBox("El tipo de documento no puede estar vacio", MsgBoxStyle.Critical, "Importante")
    '        Me.Cmb_tipo_doc.Focus()
    '        Return False
    '    End If
    '    If Txt_nro_doc.Text = "" Then
    '        MsgBox("El numero de documento no puede estar vacio", MsgBoxStyle.Critical, "Importante")
    '        Me.Txt_nro_doc.Focus()
    '        Return False
    '    End If

    '    If Me.CmbCiudad.SelectedIndex = -1 Then
    '        MsgBox("La ciudad no puede estar vacia", MsgBoxStyle.Critical, "Importante")
    '        Me.CmbCiudad.Focus()
    '        Return False
    '    End If

    '    If Me.CmbTipoTarjeta.SelectedIndex = -1 Then
    '        MsgBox("El tipo de tarjeta no puede estar vacio", MsgBoxStyle.Critical, "Importante")
    '        Me.CmbTipoTarjeta.Focus()
    '        Return False
    '    End If

    '    If Me.TxtNroTarjeta.Text = "" Then
    '        MsgBox("El numero de tarjeta no puede estar vacio", MsgBoxStyle.Critical, "Importante")
    '        Me.TxtNroTarjeta.Focus()
    '        Return False
    '    End If

    '    Return True

    'End Function


    'Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    '    Dim conexion As New Data.OleDb.OleDbConnection
    '    Dim cmd As New Data.OleDb.OleDbCommand
    '    Dim modificacion As String = ""
    '    conexion.ConnectionString = Me.string_conexion
    '    conexion.Open()
    '    If validar() Then
    '        modificacion = "Update Huesped "
    '        modificacion &= "Set nombre = '" & Me.TxtNombre.Text & "'"
    '        modificacion &= ", apellido = '" & Me.TxtApellido.Text & "'"
    '        modificacion &= ", id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
    '        modificacion &= ", nro_doc = '" & Me.Txt_nro_doc.Text & "'"
    '        modificacion &= ", id_ciudad = " & Me.CmbCiudad.SelectedValue
    '        modificacion &= ", id_tarjeta = " & Me.CmbTipoTarjeta.SelectedValue
    '        modificacion &= ", numero_tarjeta = " & Me.TxtNroTarjeta.Text & "'"
    '        modificacion &= " where id_tipo_doc = " & Me.Cmb_tipo_doc.SelectedValue
    '        '"and nro_doc = " & Me.Txt_nro_doc.Text
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = modificacion
    '        cmd.Connection = conexion
    '        cmd.ExecuteNonQuery()
    '        conexion.Close()
    '        MessageBox.Show("Se ha modificado el Huesped", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End If
    'End Sub
End Class
