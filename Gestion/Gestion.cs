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

        using (ReportADO reportADO = new ReportADO())
        {           
            reportsList = new List<Report>(await reportADO.GetAllReportsAsync());            
        }      
        return reportsList;
    }

    public static async Task<List<Club>> GetAllClubs()
    {
        List<Club> clubsList;

        using (ClubADO clubADO = new ClubADO())
        {
            clubsList = new List<Club>(await clubADO.GetAllClubsAsync());
        }
        return clubsList;
    }

    public static async Task<string> GetAddressFromCoordinates(double latitude, double longitude)
    {
        string address = "";
        using (ReportADO reportADO = new ReportADO())
        {
            address = await reportADO.GetAddressFromCoordinatesAsync(latitude, longitude);
        }
        return address;
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

    public static void AddNewClub(ClubFirebase newClub)
    {
        using (ClubADO clubADO = new ClubADO())
        {
            clubADO.AddClub(newClub);
        }
    }
}
