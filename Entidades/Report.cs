using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Entidades
{     
    public class Report
    {        
        public string Id { get; set; }      
        public string DateTime { get; set; }      
        public double Latitude { get; set; }       
        public double Longitude { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public bool IsIncident { get; set; }     
        public List<string> PhotoURLs { get; set; }
        public string Status { get; set; }

        public Report() 
        { 
        }

        /// <summary>
        /// Este método clona el report de Firebase que entre por parámetro
        /// a un nuevo objeto de la clase Report
        /// </summary>
        /// <param name="reportFirebase"></param>
        public Report(string id, ReportFirebase reportFirebase)
        {
            Id = id;
            DateTime = reportFirebase.DateTime;
            Latitude = reportFirebase.Latitude;
            Longitude = reportFirebase.Longitude;
            Category = reportFirebase.Category;
            Description = reportFirebase.Description;
            IsIncident= reportFirebase.IsIncident;
            PhotoURLs = new List<string>(reportFirebase.PhotoURLs);
            Status = reportFirebase.Status;
        }

        public Report(string id, string dateTime, string category,
            string description, bool isIncident, string status)
        {
            Id = id;
            DateTime = dateTime;
            Category = category;
            Description = description;
            IsIncident = isIncident;
            Status = status;
            PhotoURLs= new List<string>();  
            Latitude= 0; 
            Longitude= 0;  
        }

        public Report(string id, string dateTime, string category, string description,
            bool isIncident, string status, List<string> photoURLs, double latitude, 
            double longitude)
            : this(id, dateTime, category, description, isIncident, status)
        {
            PhotoURLs = new List<string>(photoURLs);
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return Id + " - " + DateTime + " - " + Category + " - " + Description + " - " 
                + Latitude + " - " + Longitude + " - " + IsIncident + " - " 
                + PhotoURLs + " - " + Status;
        }        
    }
}
