Public Class frm_instalaciones
    'Dim string_conexion As String = "Provider=SQLOLEDB.1;Password=mercedeslucila;Persist Security Info=True;User ID=sa;Initial Catalog=HOTEL;Data Source=localhost\SQLEXPRESS"


    'Private Sub frm_instalaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    carga_combo(Me.cmb_instalacion, Me.leo_tabla("INSTALACIONES"), "nombre", "instalacion")
    '    carga_combo(Me.cmb_hotel, Me.leo_tabla("HOTELES"), "nombre_hotel", "hotel")
    '    Me.cmb_hotel_reg.Enabled = False
    '    Me.cmb_instalacion_reg.Enabled = False
    '    Me.chk_disponible_reg.Enabled = False
    '    For Each objeto As System.Windows.Forms.Control In Me.Controls
    '        If TypeOf objeto Is TextBox Then
    '            objeto.Text = ""
    '        End If
    '        If TypeOf objeto Is ComboBox Then
    '            Dim actual As ComboBox = objeto
    '            actual.SelectedIndex = -1
    '        End If
    '    Next
    'End Sub

    'Private Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable
    '    Dim conexion As New Data.OleDb.OleDbConnection
    '    Dim cmd As New Data.OleDb.OleDbCommand
    '    Dim tabla As New Data.DataTable

    '    conexion.ConnectionString = Me.string_conexion
    '    conexion.Open()
    '    cmd.Connection = conexion
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "select * from " & nombre_tabla

    '    tabla.Load(cmd.ExecuteReader)
    '    Return tabla

    'End Function
    'Private Sub carga_combo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
    '    combo.Items.Clear()
    '    combo.DataSource = datos
    '    combo.ValueMember = pk
    '    combo.DisplayMember = descripcion
    'End Sub
    'Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
    '    Me.Close()
    'End Sub

    'Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

    'End Sub
End Class