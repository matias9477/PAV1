Public Class frm_menu
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    Private Sub btn_habitaciones_Click(sender As Object, e As EventArgs) Handles btn_habitaciones.Click
        frm_habitacion.Show()
    End Sub
    Private Sub btn_instalaciones_Click(sender As Object, e As EventArgs) Handles btn_instalaciones.Click
        frm_instalaciones.Show()
    End Sub
    Private Sub btn_servicios_Click(sender As Object, e As EventArgs) Handles btn_servicios.Click
        frm_servicios.Show()
    End Sub
    Private Sub btn_huespedes_Click(sender As Object, e As EventArgs) Handles btn_huespedes.Click
        frm_Huesped.Show()
    End Sub
    Private Sub btn_hotel_Click(sender As Object, e As EventArgs) Handles btn_hotel.Click
        AltaEmpleado.Show()
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class