Public Class EquivalenciaDeTaxa
    Private taxa2 As Double

    Public Function JurosCompostos(ByVal taxa As Double, ByVal tempo1 As String, ByVal tempo2 As String, Optional ByVal dia_util As Double = 22) As Double
        taxa = taxa / 100
        If (tempo1 = tempo2) Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (dia_util / 30)) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ dia_util) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (30 / dia_util)) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "By day useful") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / dia_util)) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ 30) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ 180) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 365) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 360) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 366) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ 60) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ 90) - 1)
        ElseIf (tempo1 = "Daily") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ 120) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ 6) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 12) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 12) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 12) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ 2) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ 3) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ 4) - 1)
        ElseIf (tempo1 = "Semestral") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 2) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 2) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 2) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 3)) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 2)) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 1.5)) - 1)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 30)) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 180)) - 1)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 6)) - 1)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 365)) - 1)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 12)) - 1)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 2)) - 1)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 6)) - 1)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 4)) - 1)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 3)) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 60)) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 2)) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ 1.5) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ 2) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ 3) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 6) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 6) - 1)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 6) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 90)) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 3)) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 1.5)) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ (4 / 3)) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ 2) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 4) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 4) - 1)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 4) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 120)) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 4)) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 2)) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ 1.5) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 3) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 3) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (((1 + (taxa)) ^ 3) - 1)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / (4 / 3))) - 1)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 360)) - 1)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 12)) - 1)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 2)) - 1)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 6)) - 1)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 4)) - 1)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 3)) - 1)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Daily") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 366)) - 1)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Monthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 12)) - 1)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Semester") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 2)) - 1)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 6)) - 1)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 4)) - 1)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "4 months") Then
            Me.taxa2 = (((1 + (taxa)) ^ (1 / 3)) - 1)
        Else
            MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
            Exit Function
        End If
        Return Me.taxa2
    End Function

    Public Function JurosSimples(ByVal taxa As Double, ByVal tempo1 As String, ByVal tempo2 As String, Optional ByVal dia_util As Double = 22) As Double
        taxa = taxa / 100
        If (tempo1 = tempo2) Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = taxa
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Daily") Then
            Me.taxa2 = taxa * (dia_util / 30)
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Monthly") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Semester") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "By day useful") And (tempo2 = "Quarterly") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "By day useful") And (tempo2 = "4 months") Then
            Me.taxa2 = taxa * dia_util
        ElseIf (tempo1 = "Daily") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / (dia_util / 30)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "Semester") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "4 months") And (tempo2 = "By day useful") Then
            Me.taxa2 = taxa / dia_util
        ElseIf (tempo1 = "Daily") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa * 30)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa * 180)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (taxa * 365)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (taxa * 360)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (taxa * 366)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa * 60)
        ElseIf (tempo1 = "Daily") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa * 90)
        ElseIf (tempo1 = "Daily") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa * 120)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa * 6)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (taxa * 12)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (taxa * 12)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (taxa * 12)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa * 2)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa * 3)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa * 4)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (taxa * 2)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (taxa * 2)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (taxa * 2)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa / 3)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa / 2)
        ElseIf (tempo1 = "Semester") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa / 1.5)
        ElseIf (tempo1 = "Monthly") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 30)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 180)
        ElseIf (tempo1 = "Semester") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa / 6)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 365)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa / 12)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa / 2)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa / 6)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa / 4)
        ElseIf (tempo1 = "Annual (Civil)") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa / 3)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 60)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa / 2)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa * 1.5)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa * 2)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa * 3)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (taxa * 6)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (taxa * 6)
        ElseIf (tempo1 = "Bimonthly") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (taxa * 6)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 90)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa / 3)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa / 1.5)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa * (4 / 3))
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa * 2)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (taxa * 4)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (taxa * 4)
        ElseIf (tempo1 = "Quarterly") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (taxa * 4)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 120)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa / 4)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa / 2)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa * 1.5)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Annual (Civil)") Then
            Me.taxa2 = (taxa * 3)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Annual (Commercial)") Then
            Me.taxa2 = (taxa * 3)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Annual (Bissextile)") Then
            Me.taxa2 = (taxa * 3)
        ElseIf (tempo1 = "4 months") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa / (4 / 3))
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 360)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa / 12)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa / 2)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa / 6)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa / 4)
        ElseIf (tempo1 = "Annual (Commercial)") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa / 3)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Daily") Then
            Me.taxa2 = (taxa / 366)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Monthly") Then
            Me.taxa2 = (taxa / 12)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Semester") Then
            Me.taxa2 = (taxa / 2)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Bimonthly") Then
            Me.taxa2 = (taxa / 6)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "Quarterly") Then
            Me.taxa2 = (taxa / 4)
        ElseIf (tempo1 = "Annual (Bissextile)") And (tempo2 = "4 months") Then
            Me.taxa2 = (taxa / 3)
        Else
            MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
            Exit Function
        End If
        Return Me.taxa2
    End Function

End Class
