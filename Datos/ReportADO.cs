using Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using Google.Cloud.Firestore;

namespace Datos
{
    public class ReportADO : IDisposable
    {
        bool disposed;
        private static string projectId = "cuenca-movil-22b63";      
        private string collectionName = "reports";
        FirestoreDb firestoredb; 

        public ReportADO() 
        {
            GetCredentials();
        }
      
        private void GetCredentials()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"cuenca-movil.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredb = FirestoreDb.Create(projectId);
        }

        public async Task<List<Report>> GetAllReportsAsync()
        {
            CollectionReference collection = firestoredb.Collection(collectionName);
            QuerySnapshot allReports = await collection.GetSnapshotAsync();
            List<Report> reportsList = new List<Report>();

            foreach (DocumentSnapshot document in allReports.Documents)
            {
                Report report = document.ConvertTo<Report>();              
                reportsList.Add(report);
                Debug.WriteLine(report);
            }

            return reportsList;
        }      

        async void GetReportById(string documentId)
        {
            DocumentReference docref = firestoredb.Collection(collectionName)
                .Document(documentId);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                Dictionary<string, object> club = snap.ToDictionary();
                foreach (var item in club)
                {

                }
            }
        }

        public void UpdateStatusReport(string status)
        {

        }

        public void GetReportsByStatus(string status)
        {

        }

        public void GetReportsByCategory(string category)
        {

        }

        public void GetIncidents()
        {

        }

        public void GetRequests()
        {

        }

        public void GetReportsSortByDateTime()
        {

        }


        /// <summary>
        /// Llama a la función Dispose implementada de la interfaz IDisposable e 
        /// impide que se llame al finalizador del objeto
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Método de la interfaz IDisposable. Libera objetos de esta clase de la memoria que 
        /// estén administrados por el sistema
        /// </summary>
        /// <param name="disposing">Valor booleano usado para liberar o no recursos
        /// no manejados como ficheros o conexiones</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //Liberar recursos no manejados como ficheros, conexiones a bd, etc.
            }

            disposed = true;
        }
    }
}
