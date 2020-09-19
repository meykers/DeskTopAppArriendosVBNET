Public Class ForminquilinList
    Dim conexion As New Conexion()
    ' select * from apartamentos where id not in (select apartamento_id from inquilinos)
    ' La SQL anterior extrae la lista de apartamentos sin arrendar

    'Trabajo que tenes que hacer en el formulario
    ' Programar la conexion que ya tenemos a traves de la clase conexion
    ' Extraer la informacion de los inquilino y programar el evento load
    'Programar la busqueda de inquilinos Identificacion, nombres
    Private Sub ForminquilinList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsArriendos.Inquilinos.Clear()
        Dim SQL As String = "SELECT id, nit, nombres, apartamento_id,  (Select apartamento from apartamentos where id = apartamento_id) as apartamento,	(select valor from apartamentos where id = apartamento_id) as valor, telefono, email FROM inquilinos"
        conexion.SelectAll(SQL, DsArriendos.Inquilinos)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Listo
        Dim frmNuevo = New Forminquilinos()
        'Extraer la lista de apartamentos disponibles para mostrar al nuevo inquilino
        Dim Sql1 = "Select id, apartamento, piso, valor, direccion, inventario from apartamentos where id not in (select apartamento_id from inquilinos)"

        Dim lectorApartamentos = conexion.SelectConLector(Sql1), HayApartamentos As Boolean = False
        Dim IdsApartamentos As New List(Of Integer)
        While (lectorApartamentos.Read)            
            IdsApartamentos.Add(lectorApartamentos(0))
            frmNuevo.cmbApartamento.Items.Add(lectorApartamentos(1))
            frmNuevo.Piso.Add(lectorApartamentos(2))
            frmNuevo.Valor.Add(lectorApartamentos(3))
            frmNuevo.Direccion.Add(lectorApartamentos(4))
            frmNuevo.Inventario.Add(lectorApartamentos(5))
            HayApartamentos = True
        End While

        If HayApartamentos = False Then
            MessageBox.Show("No puede agregar mas inquilinos sin apartamentos disponibles", "No hay apartamentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmNuevo.IdentificacionTextBox.Focus()
            frmNuevo.ShowDialog()

            If (frmNuevo.DialogResult = Windows.Forms.DialogResult.OK) Then
                Dim SQL As String = String.Format("insert into Inquilinos (nit, nombres, telefono, email, apartamento_id) values('{0}', '{1}', {2}, '{3}', {4})", frmNuevo.IdentificacionTextBox.Text.Trim, frmNuevo.NombresTextBox.Text.Trim, frmNuevo.TelefonoTextBox.Text.Trim, frmNuevo.EmailTextBox.Text.Trim, IdsApartamentos(frmNuevo.cmbApartamento.SelectedIndex))
                conexion.AccionSQL(SQL)
                Call ForminquilinList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion del Arrendatario ha sido almacenada", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If       
    End Sub

   
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Listo
        If (InquilinosBindingSource.Count > 0) Then
            If MessageBox.Show("Confirme que desea eliminar esta informacion", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim ID As Integer = Convert.ToInt16(InquilinosDataGridView.CurrentRow.Cells(0).Value)
                Dim SQL = String.Format("Delete from inquilinos where ID = {0}", ID)
                conexion.AccionSQL(SQL)
                Call ForminquilinList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion del inquilino ha sido eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    
    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        If (CmbBuscar.SelectedIndex < 0) Then
            MessageBox.Show("Por favor seleccione un criterio para realizar busqueda", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else
            If (Txtcriterio.Text.Trim() = String.Empty) Then
                MessageBox.Show("Por favor escriba el criterio para realizar la busqueda", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            Else
                Dim SQL As String = ""
                Select Case CmbBuscar.SelectedIndex
                    Case 0 'Identificacion
                        SQL = String.Format("SELECT id, nit, nombres, apartamento_id,  (Select apartamento from apartamentos where id = apartamento_id) as apartamento,	(select valor from apartamentos where id = apartamento_id) as valor, telefono, email FROM inquilinos where nit like '{0}%'", Txtcriterio.Text.Trim())

                    Case 1 'Nombre
                        SQL = String.Format("Select *, apartamentos.apartamento, apartamentos.valor from inquilinos inner join apartamentos on inquilinos.apartamento_id = apartamentos.id where inquilinos.nombres like '{0}%'", Txtcriterio.Text.Trim())
                End Select
                DsArriendos.Inquilinos.Clear()
                conexion.SelectAll(SQL, DsArriendos.Inquilinos)
                InquilinosDataGridView.Focus()
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (InquilinosBindingSource.Count > 0) Then
            Dim Editar = New Forminquilinos()
            Editar.IdentificacionTextBox.Text = InquilinosDataGridView.CurrentRow.Cells(1).Value
            Editar.TelefonoTextBox.Text = InquilinosDataGridView.CurrentRow.Cells(6).Value
            Editar.EmailTextBox.Text = InquilinosDataGridView.CurrentRow.Cells(7).Value
            Editar.NombresTextBox.Text = InquilinosDataGridView.CurrentRow.Cells(2).Value
            'Extraer la lista de apartamentos disponibles para mostrar al nuevo inquilino
            Dim Sql1 = "Select id, apartamento, piso, valor, direccion, inventario from apartamentos where id not in (select apartamento_id from inquilinos)"
            Dim nIndice As Integer = 0
            Dim lectorApartamentos = conexion.SelectConLector(Sql1)
            Dim IdsApartamentos As New List(Of Integer)
            While (lectorApartamentos.Read)
                IdsApartamentos.Add(lectorApartamentos(0))
                Editar.cmbApartamento.Items.Add(lectorApartamentos(1))
                Editar.Piso.Add(lectorApartamentos(2))
                Editar.Valor.Add(lectorApartamentos(3))
                Editar.Direccion.Add(lectorApartamentos(4))
                Editar.Inventario.Add(lectorApartamentos(5))
                nIndice = nIndice + 1
            End While
            lectorApartamentos.Close()
            conexion.CerrarConexion()
            'Despues de agregar los apartamentos disponibles, agregar el departamento que tiene el inquilino
            Dim SQL2 As String = String.Format("Select id, apartamento, piso, valor, direccion, inventario from apartamentos where id = {0}", InquilinosDataGridView.CurrentRow.Cells(3).Value.ToString())

            Dim lectorAparActual = conexion.SelectConLector(SQL2)
            While (lectorAparActual.Read)
                IdsApartamentos.Add(lectorAparActual(0))
                Editar.cmbApartamento.Items.Add(lectorAparActual(1))
                Editar.Piso.Add(lectorAparActual(2))
                Editar.Valor.Add(lectorAparActual(3))
                Editar.Direccion.Add(lectorAparActual(4))
                Editar.Inventario.Add(lectorAparActual(5))
                nIndice = nIndice + 1
            End While
            lectorAparActual.Close()
            conexion.CerrarConexion()
            Dim ID As Integer = Convert.ToInt16(InquilinosDataGridView.CurrentRow.Cells(0).Value)
            Dim Usuario_id As Integer = 1 'Luego lo sustuiremos por el ID del usuario logueado en el sistema
            Editar.cmbApartamento.SelectedIndex = nIndice - 1
            Editar.ShowDialog()

            If (Editar.DialogResult = Windows.Forms.DialogResult.OK) Then
                Dim SQL As String = String.Format("Update Inquilinos set nit = '{0}', nombres ='{1}', telefono = {2}, email='{3}', apartamento_id = {4} where id = {5}", Editar.IdentificacionTextBox.Text.Trim(), Editar.NombresTextBox.Text.Trim(), Editar.TelefonoTextBox.Text.Trim(), Editar.EmailTextBox.Text.Trim(), IdsApartamentos(Editar.cmbApartamento.SelectedIndex), ID)
                conexion.AccionSQL(SQL)
                Call ForminquilinList_Load(Nothing, Nothing)
                MessageBox.Show("La informacion de los arrendatarios ha sido actualizada", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class