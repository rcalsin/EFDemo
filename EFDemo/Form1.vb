Imports Microsoft.EntityFrameworkCore.SqlServer
Imports Microsoft.EntityFrameworkCore

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim Employ As GetEmployeesWithDepartment_Result


    Dim d As New DBGrupoHolpContext



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cc As Boolean = True
        Dim yy As Boolean = True


        'Dim c = d.GetEmployeesWithDepartment_Results.FirstOrDefault
        'Dim xxxxx As FormattableString = "Exec CONTABILIDAD.USPCNSMonedas"

        'Dim objEmploee = d.GetEmployeesWithDepartment_Results.FromSqlInterpolated($"Exec CONTABILIDAD.USPCNSMonedas @ONLY_USEDINVENTA={cc},@INC_ANULADOS={yy}").AsEnumerable
        Dim objEmploee = d.GetEmployeesWithDepartment_Results.FromSqlInterpolated($"Exec CONTABILIDAD.USPCNSMonedas @ONLY_USEDINVENTA=True,@INC_ANULADOS=True").AsEnumerable

        For Each item As GetEmployeesWithDepartment_Result In objEmploee

            MessageBox.Show(item.DESCMONEDA)

        Next

        'd.Database.ExecuteSqlCommand("",)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim cc As String = "623256"

        MessageBox.Show(cc.Substring(0, 1))
    End Sub
End Class
