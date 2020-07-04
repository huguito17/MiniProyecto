Imports System.ComponentModel

Public Class RegistroEmpleados
    Dim conexion As New conexion()
    Dim dt As New DataTable

    Private Sub RegistroEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar()
        llenarSexo()
        llenarPuesto()
        BloquearDatosPlan()
    End Sub

    ' Funcion para llenar el combo de los puestos
    Public Sub llenarPuesto()
        Try
            conexion.llenarPuesto()
            cmbPuesto.DataSource = conexion.datos2.Tables("puesto")
            cmbPuesto.DisplayMember = "puesto"
        Catch ex As Exception
            MessageBox.Show("Error de conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Funcion para llenar el combo de sexo
    Public Sub llenarSexo()
        Try
            conexion.llenarSexo()
            cmbSexo.DataSource = conexion.datos2.Tables("sexo")
            cmbSexo.DisplayMember = "sexo"
        Catch ex As Exception
            MessageBox.Show("Error de conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardarRegistro_Click(sender As Object, e As EventArgs) Handles btnGuardarRegistro.Click
        'If dt = conexion.busqueda(" empleados ", " puesto like '%" + cmbPuesto.Text + "%'") > 4 Then

        'End If
        Try
            If Me.ValidateChildren And txtIdentidadRegistro.Text <> String.Empty Or IsNumeric(txtIdentidadRegistro.Text) And txtNombreRegistro.Text <> String.Empty And txtDireccionRegistro.Text <> String.Empty And txtDireccionRegistro.Text <> String.Empty And txtEdadRegistro.Text <> String.Empty Or IsNumeric(txtEdadRegistro.Text) Then
                Dim guardar As String = "insert into empleados values('" + txtIdentidadRegistro.Text + "','" + txtNombreRegistro.Text + "','" + txtApellidosRegistro.Text + "','" + txtDireccionRegistro.Text + "','" + txtEdadRegistro.Text + "','" + cmbSexo.Text + "','" + cmbPuesto.Text + "')"
                If (conexion.insertar(guardar)) Then
                    MessageBox.Show("Guardado")
                    Llenar()
                    Limpiar()
                    conexion.conexion.Close()
                Else
                    MessageBox.Show("Error al guardar")
                    conexion.conexion.Close()
                End If
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnModificarRegistro_Click(sender As Object, e As EventArgs) Handles btnModificarRegistro.Click
        Try
            Dim modificar As String = "identidad='" + txtIdentidadRegistro.Text + "', empNom='" + txtNombreRegistro.Text + "', empApe='" + txtApellidosRegistro.Text + "', direccion='" + txtDireccionRegistro.Text + "', edad='" + txtEdadRegistro.Text + "', sexo='" + cmbSexo.Text + "', puesto='" + cmbPuesto.Text + "'"
            If (conexion.modificar(" empleados ", modificar, " identidad= " + txtIdentidadRegistro.Text)) Then
                MessageBox.Show("Se ha actualizado satisfactoreamente")
                Llenar()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar los datos")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtNombreRegistro_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreRegistro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtApellidosRegistro_Validating(sender As Object, e As CancelEventArgs) Handles txtApellidosRegistro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccionRegistro_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccionRegistro.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cmbSexo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbPuesto_Validating(sender As Object, e As CancelEventArgs) Handles cmbPuesto.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdentidadRegistro_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtIdentidadRegistro, "Ingrese el numero de identidad")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombreRegistro_MouseHover(sender As Object, e As EventArgs) Handles txtNombreRegistro.MouseHover
        ToolTip.SetToolTip(txtNombreRegistro, "Agregue el nombre del empleado")
        ToolTip.ToolTipTitle = "Nombre Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellidosRegistro_MouseHover(sender As Object, e As EventArgs) Handles txtApellidosRegistro.MouseHover
        ToolTip.SetToolTip(txtApellidosRegistro, "Agregue el apellido del empleado")
        ToolTip.ToolTipTitle = "Apellido Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccionRegistro_MouseHover(sender As Object, e As EventArgs) Handles txtDireccionRegistro.MouseHover
        ToolTip.SetToolTip(txtDireccionRegistro, "Agregue la direccion del empleado")
        ToolTip.ToolTipTitle = "Direccion empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdadRegistro_MouseHover(sender As Object, e As EventArgs) Handles txtEdadRegistro.MouseHover
        ToolTip.SetToolTip(txtEdadRegistro, "Agregue la edad del empleado")
        ToolTip.ToolTipTitle = "Edad Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbSexo_MouseHover(sender As Object, e As EventArgs) Handles cmbSexo.MouseHover
        ToolTip.SetToolTip(cmbSexo, "Elija el sexo del empleado")
        ToolTip.ToolTipTitle = "Sexo Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbPuesto_MouseHover(sender As Object, e As EventArgs) Handles cmbPuesto.MouseHover
        ToolTip.SetToolTip(txtApellidosRegistro, "Elija el puesto del empleado")
        ToolTip.ToolTipTitle = "Puesto del Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtIdentidadRegistro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidadRegistro.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEdadRegistro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdadRegistro.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub Limpiar()
        txtIdentidadRegistro.Clear()
        txtNombreRegistro.Clear()
        txtApellidosRegistro.Clear()
        txtDireccionRegistro.Clear()
        txtEdadRegistro.Clear()
    End Sub

    Public Sub Llenar()
        Try
            conexion.Llenar("Select identidad as 'Identidad',empNom as 'Nombre',empApe as 'Apellido',direccion as 'Dirección',edad as 'Edad',sexo as 'Sexo',puesto as 'Puesto de trabajo' from empleados", "empleados")
            dtsEmpleados.DataSource = conexion.ds.Tables("empleados")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtIdentidadRegistro_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidadRegistro.Validating
        If DirectCast(sender, TextBox).Text.Length = 13 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Debe agregar el nombre del empleado")
        End If
    End Sub

    Private Sub dtsEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtsEmpleados.CellClick
        Dim FilaActual As Integer
        FilaActual = dtsEmpleados.CurrentRow.Index
        txtIdentidadRegistro.Text = dtsEmpleados.Rows(FilaActual).Cells(0).Value
        txtNombreRegistro.Text = dtsEmpleados.Rows(FilaActual).Cells(1).Value
        txtApellidosRegistro.Text = dtsEmpleados.Rows(FilaActual).Cells(2).Value
        txtDireccionRegistro.Text = dtsEmpleados.Rows(FilaActual).Cells(3).Value
        txtEdadRegistro.Text = dtsEmpleados.Rows(FilaActual).Cells(4).Value
        cmbSexo.Text = dtsEmpleados.Rows(FilaActual).Cells(5).Value
        cmbPuesto.Text = dtsEmpleados.Rows(FilaActual).Cells(6).Value
    End Sub

    Private Sub buscar()
        Try
            dt = conexion.busqueda(" empleados ", " identidad like '%" + txtIdentidadRegistro.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtsEmpleados.DataSource = dt
                conexion.conexion.Close()
            Else
                dtsEmpleados.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnLimpiarRegistro_Click(sender As Object, e As EventArgs) Handles btnLimpiarRegistro.Click
        Limpiar()
        cmbSexo.Text = ""
        cmbPuesto.Text = ""
    End Sub

    Private Sub txtBuscar_Validating(sender As Object, e As CancelEventArgs) Handles txtBuscar.Validating
        If DirectCast(sender, TextBox).Text.Length = 13 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Debe agregar el nombre del empleado")
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_Validating(sender As Object, e As CancelEventArgs) Handles txtNumero.Validating
        If DirectCast(sender, TextBox).Text.Length = 8 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Debe agregar el nombre del empleado")
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Terminar
    Private Sub plan()
        Try
            dt = conexion.busqueda(" empleados ", " identidad like '%" + txtIdentidadRegistro.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtsEmpleados.DataSource = dt
                conexion.conexion.Close()
            Else
                dtsEmpleados.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub BloquearDatosPlan()
        txtNumero.Enabled = False
        btnGuardar.Enabled = False
        btnLimpiar.Enabled = False
    End Sub

    Public Sub AccederPlan()
        txtNumero.Enabled = True
        btnGuardar.Enabled = True
        btnLimpiar.Enabled = True
    End Sub

    Public Sub limpiarDatosPlan()
        txtNumero.Clear()
        txtMarca.Clear()
        txtPlan.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarDatosPlan()
    End Sub

End Class