Public Class Forminquilinos
#Region "Listas"
    Public Piso As New List(Of String)
    Public Valor As New List(Of Integer)
    Public Direccion As New List(Of String)
    Public Inventario As New List(Of String)
#End Region
    
    'Programar la validacion de informacion de inquilinos (solo datos de inquilinos)
    Private Function Validaringreso() As Boolean
        If (IdentificacionTextBox.Text.Trim() = String.Empty) Then
            erp.SetError(IdentificacionTextBox, "Por favor escribe la identificación del arrendatario...")
            IdentificacionTextBox.Focus()
            Return False
        End If
        If (TelefonoTextBox.Text.Trim = String.Empty) Then
            erp.SetError(TelefonoTextBox, "Por favor escribe el numero telefonico del arrendatario")
            TelefonoTextBox.Focus()
            Return False
        End If
        If (EmailTextBox.Text.Trim = String.Empty) Then
            erp.SetError(EmailTextBox, "Por favor escribe el email del arrendatario...")
            EmailTextBox.Focus()
            Return False
        End If
        If (NombresTextBox.Text.Trim = String.Empty) Then
            erp.SetError(NombresTextBox, "Por favor escribe el nombre del arrendatario...")
            NombresTextBox.Focus()
            Return False
        End If
        If (cmbApartamento.Text.Trim = String.Empty) Then
            erp.SetError(cmbApartamento, "Por favor selecciona un apartamento para el arrendatario")
            cmbApartamento.Focus()
            Return False
        End If
       
        erp.SetError(IdentificacionTextBox, "")
        erp.SetError(TelefonoTextBox, "")
        erp.SetError(EmailTextBox, "")
        erp.SetError(NombresTextBox, "")
        erp.SetError(cmbApartamento, "")
        Return True
    End Function

    Private Sub cmbApartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbApartamento.SelectedIndexChanged
        PisoTextBox.Text = Piso(cmbApartamento.SelectedIndex)
        nudValor.Value = Valor(cmbApartamento.SelectedIndex)
        DireccionTextBox.Text = Direccion(cmbApartamento.SelectedIndex)
        InventarioTextBox.Text = Inventario(cmbApartamento.SelectedIndex)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (Validaringreso() = True) Then
            Close()
        End If
    End Sub
End Class