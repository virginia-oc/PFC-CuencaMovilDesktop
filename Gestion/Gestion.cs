using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

public class Gestion
{
    public Gestion() 
    {
    }
        
    public static async Task<List<Report>> GetAllReports()
    {
        List<Report> reportsList;
        //Task<List<Report>> reportsTask;

        using (ReportADO reportADO = new ReportADO())
        {
            //reportsTask = reportADO.GetAllReportsAsync();
            reportsList = new List<Report>(await reportADO.GetAllReportsAsync()); 
            Debug.WriteLine(reportsList.Count);
        }

        foreach (Report report in reportsList) 
        {
            Debug.WriteLine(report);
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
