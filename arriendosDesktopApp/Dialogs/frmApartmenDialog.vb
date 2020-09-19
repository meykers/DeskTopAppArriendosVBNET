Public Class frmApartmenDialog
    Private Function ValidarEntrada() As Boolean
        If (ApartamentoTextBox.Text.Trim() = String.Empty) Then
            erp.SetError(ApartamentoTextBox, "Por favor escriba el nombre del apartamento")
            ApartamentoTextBox.Focus()
            Return False
        End If
        If (PisoTextBox.Text.Trim = String.Empty) Then
            erp.SetError(PisoTextBox, "Por favor escriba el numero de piso")
            PisoTextBox.Focus()
            Return False
        End If
        If (DireccionTextBox.Text.Trim = String.Empty) Then
            erp.SetError(DireccionTextBox, "Por favor escriba la direccion")
            DireccionTextBox.Focus()
            Return False
        End If
        If (InventarioTextBox.Text.Trim() = String.Empty) Then
            erp.SetError(InventarioTextBox, "Escriba 'Sin amueblar' en caso que este no tenga muebles, caso corario, escriba cada uno de los muebles presentes")
            InventarioTextBox.Focus()
            Return False
        End If
        erp.SetError(ApartamentoTextBox, "")
        erp.SetError(PisoTextBox, "")
        erp.SetError(DireccionTextBox, "")
        erp.SetError(InventarioTextBox, "")
        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (ValidarEntrada() = True) Then
            Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class