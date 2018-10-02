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

    Private Sub frm_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "Importante",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) =
            Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class