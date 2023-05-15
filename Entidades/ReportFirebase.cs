using Google.Cloud.Firestore;
using System.Collections.Generic;

namespace Entidades
{
    [FirestoreData]
    public class ReportFirebase
    {           
        [FirestoreProperty("dateTime")]
        public string DateTime { get; set; }
        [FirestoreProperty("latitude")]
        public double Latitude { get; set; }
        [FirestoreProperty("longitude")]
        public double Longitude { get; set; }
        [FirestoreProperty("category")]
        public string Category { get; set; }
        [FirestoreProperty("description")]
        public string Description { get; set; }
        [FirestoreProperty("isIncident")]
        public bool IsIncident { get; set; }
        [FirestoreProperty("photoURLs")]
        public List<string> PhotoURLs { get; set; }
        [FirestoreProperty("status")]
        public string Status { get; set; }

        public ReportFirebase()
        {
        }

        public ReportFirebase(string dateTime, string category,
            string description, bool isIncident, string status)
        {           
            DateTime = dateTime;
            Category = category;
            Description = description;
            IsIncident = isIncident;
            Status = status;
            PhotoURLs = new List<string>();
            Latitude = 0;
            Longitude = 0;
        }

        public ReportFirebase(string dateTime, string category, string description,
            bool isIncident, string status, List<string> photoURLs, double latitude, 
            double longitude)
            : this(dateTime, category, description, isIncident, status)
        {
            PhotoURLs = new List<string>(photoURLs);
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return DateTime + " - " + Category + " - " + Description + " - "
                + Latitude + " - " + Longitude + " - " + IsIncident + " - "
                + PhotoURLs + " - " + Status;
        }       
    }
}
