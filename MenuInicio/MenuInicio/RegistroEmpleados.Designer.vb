<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtsEmpleados = New System.Windows.Forms.DataGridView()
        Me.txtNombreRegistro = New System.Windows.Forms.TextBox()
        Me.txtApellidosRegistro = New System.Windows.Forms.TextBox()
        Me.txtDireccionRegistro = New System.Windows.Forms.TextBox()
        Me.txtEdadRegistro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdentidadRegistro = New System.Windows.Forms.TextBox()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarRegistro = New System.Windows.Forms.Button()
        Me.btnModificarRegistro = New System.Windows.Forms.Button()
        Me.btnGuardarRegistro = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPlan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtsEmpleados)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(18, 454)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1176, 295)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabla Empleados"
        '
        'dtsEmpleados
        '
        Me.dtsEmpleados.AllowUserToAddRows = False
        Me.dtsEmpleados.AllowUserToDeleteRows = False
        Me.dtsEmpleados.AllowUserToOrderColumns = True
        Me.dtsEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtsEmpleados.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtsEmpleados.Location = New System.Drawing.Point(9, 29)
        Me.dtsEmpleados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtsEmpleados.Name = "dtsEmpleados"
        Me.dtsEmpleados.ReadOnly = True
        Me.dtsEmpleados.RowHeadersWidth = 51
        Me.dtsEmpleados.Size = New System.Drawing.Size(1148, 257)
        Me.dtsEmpleados.TabIndex = 0
        '
        'txtNombreRegistro
        '
        Me.txtNombreRegistro.Location = New System.Drawing.Point(94, 88)
        Me.txtNombreRegistro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreRegistro.Name = "txtNombreRegistro"
        Me.txtNombreRegistro.Size = New System.Drawing.Size(223, 26)
        Me.txtNombreRegistro.TabIndex = 4
        '
        'txtApellidosRegistro
        '
        Me.txtApellidosRegistro.Location = New System.Drawing.Point(94, 142)
        Me.txtApellidosRegistro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApellidosRegistro.Name = "txtApellidosRegistro"
        Me.txtApellidosRegistro.Size = New System.Drawing.Size(223, 26)
        Me.txtApellidosRegistro.TabIndex = 5
        '
        'txtDireccionRegistro
        '
        Me.txtDireccionRegistro.Location = New System.Drawing.Point(94, 192)
        Me.txtDireccionRegistro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccionRegistro.Multiline = True
        Me.txtDireccionRegistro.Name = "txtDireccionRegistro"
        Me.txtDireccionRegistro.Size = New System.Drawing.Size(223, 70)
        Me.txtDireccionRegistro.TabIndex = 6
        '
        'txtEdadRegistro
        '
        Me.txtEdadRegistro.Location = New System.Drawing.Point(94, 282)
        Me.txtEdadRegistro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEdadRegistro.MaxLength = 100
        Me.txtEdadRegistro.Name = "txtEdadRegistro"
        Me.txtEdadRegistro.Size = New System.Drawing.Size(223, 26)
        Me.txtEdadRegistro.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdentidadRegistro)
        Me.GroupBox2.Controls.Add(Me.cmbSexo)
        Me.GroupBox2.Controls.Add(Me.cmbPuesto)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtEdadRegistro)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtDireccionRegistro)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtApellidosRegistro)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNombreRegistro)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(501, 428)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Empleado"
        '
        'txtIdentidadRegistro
        '
        Me.txtIdentidadRegistro.Location = New System.Drawing.Point(94, 35)
        Me.txtIdentidadRegistro.Name = "txtIdentidadRegistro"
        Me.txtIdentidadRegistro.Size = New System.Drawing.Size(223, 26)
        Me.txtIdentidadRegistro.TabIndex = 15
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(94, 332)
        Me.cmbSexo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(223, 28)
        Me.cmbSexo.TabIndex = 12
        '
        'cmbPuesto
        '
        Me.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Location = New System.Drawing.Point(94, 380)
        Me.cmbPuesto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(223, 28)
        Me.cmbPuesto.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpiarRegistro)
        Me.GroupBox3.Controls.Add(Me.btnModificarRegistro)
        Me.GroupBox3.Controls.Add(Me.btnGuardarRegistro)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(354, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(138, 208)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operaciones"
        '
        'btnLimpiarRegistro
        '
        Me.btnLimpiarRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiarRegistro.Location = New System.Drawing.Point(8, 143)
        Me.btnLimpiarRegistro.Name = "btnLimpiarRegistro"
        Me.btnLimpiarRegistro.Size = New System.Drawing.Size(124, 49)
        Me.btnLimpiarRegistro.TabIndex = 4
        Me.btnLimpiarRegistro.Text = "Limpiar"
        Me.btnLimpiarRegistro.UseVisualStyleBackColor = True
        '
        'btnModificarRegistro
        '
        Me.btnModificarRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificarRegistro.Location = New System.Drawing.Point(8, 83)
        Me.btnModificarRegistro.Name = "btnModificarRegistro"
        Me.btnModificarRegistro.Size = New System.Drawing.Size(124, 55)
        Me.btnModificarRegistro.TabIndex = 1
        Me.btnModificarRegistro.Text = "Modificar"
        Me.btnModificarRegistro.UseVisualStyleBackColor = True
        '
        'btnGuardarRegistro
        '
        Me.btnGuardarRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuardarRegistro.Location = New System.Drawing.Point(8, 26)
        Me.btnGuardarRegistro.Name = "btnGuardarRegistro"
        Me.btnGuardarRegistro.Size = New System.Drawing.Size(124, 52)
        Me.btnGuardarRegistro.TabIndex = 0
        Me.btnGuardarRegistro.Text = "Guardar"
        Me.btnGuardarRegistro.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(16, 386)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Puesto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(22, 337)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(21, 286)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(9, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(9, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(9, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(542, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Buscar: "
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(616, 397)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(223, 26)
        Me.txtBuscar.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(40, 162)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Plan"
        '
        'txtPlan
        '
        Me.txtPlan.Location = New System.Drawing.Point(106, 155)
        Me.txtPlan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPlan.Name = "txtPlan"
        Me.txtPlan.ReadOnly = True
        Me.txtPlan.Size = New System.Drawing.Size(223, 26)
        Me.txtPlan.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(9, 234)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Descripcion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(27, 95)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Marca"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(106, 223)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(223, 104)
        Me.txtDescripcion.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(21, 35)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 20)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Telefono"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(106, 89)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(223, 26)
        Me.txtMarca.TabIndex = 15
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(106, 31)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumero.MaxLength = 8
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(223, 26)
        Me.txtNumero.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtPlan)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtMarca)
        Me.GroupBox4.Controls.Add(Me.txtNumero)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(528, 18)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(500, 351)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del plan"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnLimpiar)
        Me.GroupBox5.Controls.Add(Me.btnGuardar)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(354, 186)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(138, 157)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Operaciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(6, 92)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(124, 49)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuardar.Location = New System.Drawing.Point(8, 26)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(124, 52)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar plan"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'RegistroEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1206, 777)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RegistroEmpleados"
        Me.Text = "RegistroEmpleados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtsEmpleados As DataGridView
    Friend WithEvents txtNombreRegistro As TextBox
    Friend WithEvents txtApellidosRegistro As TextBox
    Friend WithEvents txtDireccionRegistro As TextBox
    Friend WithEvents txtEdadRegistro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPuesto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiarRegistro As Button
    Friend WithEvents btnModificarRegistro As Button
    Friend WithEvents btnGuardarRegistro As Button
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents txtIdentidadRegistro As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPlan As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
End Class
