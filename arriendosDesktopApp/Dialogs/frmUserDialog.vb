Public Class frmUserDialog
    Dim conexion As New Conexion()
    Private Function ValidarEntradaUsuario() As Boolean
        If (NitTextBox.Text.Trim() = String.Empty) Then
            erp.SetError(NitTextBox, "Por favor escriba el numero de identifecacion de nuevo usuario del sistemas...")
            NitTextBox.Focus()
            Return False
        End If
        If (NombresTextBox.Text.Trim = String.Empty) Then
            erp.SetError(NombresTextBox, "Por favor, escriba el nombre y apelldios del nuevo usuario del sistema...")
            NombresTextBox.Focus()
            Return False
        End If
        If (UsuarioTextBox.Text.Trim = String.Empty) Then
            erp.SetError(UsuarioTextBox, "Por favor, escriba el usuario con el que te identificara en el sistema...")
            UsuarioTextBox.Focus()
            Return False
        End If

        If (PasswordTextBox.Text.Trim = String.Empty) Then
            erp.SetError(PasswordTextBox, "Por favor, escriba  la contraseña, que se usara para ingresar  al programa...")
            PasswordTextBox.Focus()
            Return False
        End If

        erp.SetError(NitTextBox, "")
        erp.SetError(NombresTextBox, "")
        erp.SetError(UsuarioTextBox, "")
        erp.SetError(PasswordTextBox, "")
        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (ValidarEntradaUsuario() = True) Then
            Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class