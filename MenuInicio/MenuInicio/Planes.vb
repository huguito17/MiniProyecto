Imports System.ComponentModel
Public Class Planes
    Dim conexion As New conexion()
    Private Sub Planes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarProcedimiento()
    End Sub

    Private Sub mostrarProcedimiento()
        conexion.Llenar("select EMP.identidad as 'Identidad',EMP.empNom as 'Nombre Empleado',EMP.empApe as 'Apellido Empleado',EMP.puesto as 'Puesto Empleado',PLA.numeroTel as 'Telefono',PLA.marca as 'Marca Telefono',PLA.descripcion as 'Descripción del plan' 
                           from empleados as EMP 
                           inner join planes as PLA on EMP.identidad 
                            = PLA.identidad", "empleados,planes")
        dtgPlan.DataSource = conexion.ds.Tables("empleados,planes")
    End Sub


End Class