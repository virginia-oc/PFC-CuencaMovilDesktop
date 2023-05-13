using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Gestion
{
    public Gestion() 
    {
    }
        
    public static List<Report> GetAllReports()
    {
        List<Report> reportsList = new List<Report>();
        Task<List<Report>> reportsTask;
        using (ReportADO reportADO = new ReportADO())
        {
            reportsTask = reportADO.GetAllReportsAsync();

        }
        return reportsList;
    }

    public static void UpdateStatusReport(string status)
    {

    }

    public static void GetReportsByStatus(string status)
    {

    }

    public static void GetReportsByCategory(string category)
    {

    }

    public static void GetIncidents()
    {

    }

    public static void GetRequests()
    {

    }

    public static void GetReportsSortByDateTime()
    {

    }

    public static void AddNewClub(Club newClub)
    {
        using (ClubADO clubADO = new ClubADO())
        {
            clubADO.AddClub(newClub);
        }
    }
}
