using Entidades;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Datos
{
    public class ClubADO : IDisposable
    {
        bool disposed;
        private static string projectId = "cuenca-movil-22b63";
        private string collectionName = "clubs";
        FirestoreDb firestoredb;

        public ClubADO() 
        {
            GetCredentials();
        }

        private void GetCredentials()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"cuenca-movil.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            firestoredb = FirestoreDb.Create(projectId);
        }

        public Task<DocumentReference> AddClub(Club newClub)
        {
            CollectionReference club = firestoredb.Collection("clubs");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "name", newClub.Name},
                { "category", newClub.Category },
                { "description", newClub.Description },
                { "phone", newClub.Phone },
                { "email", newClub.Email },
                { "website", newClub.Website },
                { "photo", "" }
            };
            return club.AddAsync(data);
        }

        async void GetAllClubs()
        {
            DocumentReference docref = firestoredb.Collection(collectionName)
                .Document();
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
        }

        async void GetClubById(string documentId)
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
