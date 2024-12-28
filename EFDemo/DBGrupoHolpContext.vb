Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata


Public Class DBGrupoHolpContext
    Inherits DbContext


    Public Property GetEmployeesWithDepartment_Results As DbSet(Of GetEmployeesWithDepartment_Result)


    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)

        If (optionsBuilder.IsConfigured = False) Then

            '¿#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            'optionsBuilder.UseSqlServer("Data Source=siholp.com;Initial Catalog=DBGrupoHolp;User ID=Admin;Password=GhD3H01p")
            optionsBuilder.UseSqlServer("Data Source=CandyMarket.com.pe;Initial Catalog=DBGrupoHolp;User ID=Admin;Password=GhD3C0nD1")


        End If

    End Sub

    Public Function SP_GetEmployeesWithDepartment(ONLY_USEDINVENTA As Boolean, INC_ANULADOS As Boolean) As IEnumerable(Of GetEmployeesWithDepartment_Result)

        Return GetEmployeesWithDepartment_Results.FromSqlInterpolated($"[CONTABILIDAD].[USPCNSMonedas] {ONLY_USEDINVENTA}{INC_ANULADOS}").ToArray()



    End Function



End Class
