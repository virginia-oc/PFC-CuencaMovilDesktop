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
            reportsList = new List<Report>(await reportADO.GetAllReports());            
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
            address = await reportADO.GetAddressFromCoordinates(latitude, longitude);
        }
        return address;
    }

    public static void UpdateReportStatus(Report report, string newStatus)
    {
        using (ReportADO reportAdo = new ReportADO())
        {
            reportAdo.UpdateReportStatus(report.Id, newStatus);
        }
    }

    public static List<Club> FilterClubsByText(List<Club> clubs, string text)
    {
        List<Club> filteredClubs = new List<Club>();
        if (text.Length == 0)
            return clubs;
        else
        {
            foreach (Club club in clubs)
            {
               if (club.Contain(text))
                   filteredClubs.Add(club);
            }
            return filteredClubs;
        }
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
