Public Class frmCodeudorDialog

    Private Function Validaringreso() As Boolean
        If (NombresTextBox.Text.Trim = String.Empty) Then
            erp.SetError(NombresTextBox, "Por favor escriba el nnombres de codeudor..")
            NombresTextBox.Focus()
            Return False
        End If

        If (DireccionTextBox.Text.Trim = String.Empty) Then
            erp.SetError(DireccionTextBox, "Por favor escriba la direccion del codeudor..")
            DireccionTextBox.Focus()
            Return False
        End If

        If (TelefonoTextBox.Text.Trim = String.Empty) Then
            erp.SetError(TelefonoTextBox, "Por favor escribe el numero telefonico de ese codeudor...")
            TelefonoTextBox.Focus()
            Return False
        End If

        If (EmailTextBox.Text.Trim() = String.Empty) Then
            erp.SetError(EmailTextBox, " por favor dame el email de codeudor..")
            EmailTextBox.Focus()
            Return False
        End If


        erp.SetError(NombresTextBox, "")
        erp.SetError(DireccionTextBox, "")
        erp.SetError(TelefonoTextBox, "")
        erp.SetError(EmailTextBox, "")
        Return True
    End Function
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (Validaringreso() = True) Then
            Close()
        End If
    End Sub
End Class