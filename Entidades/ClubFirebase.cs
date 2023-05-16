using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [FirestoreData]
    public class ClubFirebase
    {
        string emptyField = "(sin especificar)";
      
        [FirestoreProperty("name")]
        public string Name { get; set; }
        [FirestoreProperty("category")]
        public string Category { get; set; }
        [FirestoreProperty("description")]
        public string Description { get; set; }
        [FirestoreProperty("phone")]
        public string Phone { get; set; }
        [FirestoreProperty("website")]
        public string Website { get; set; }
        [FirestoreProperty("email")]
        public string Email { get; set; }
        [FirestoreProperty("photoURLs")]
        public List<string> PhotoURLs { get; set; }

        public ClubFirebase()
        {

        }

        public ClubFirebase(string name, string category, string descripcion,
            string email)
        {
            Name = name;
            Category = category;
            Description = descripcion;
            Email = email;
            Phone = emptyField;
            Website = emptyField;
        }

        public ClubFirebase(string name, string category, string descripcion,
            string phone, string website, string email, List<string> photos)
            : this(name, category, descripcion, email)
        {
            Website = website;
            Phone = phone;
            PhotoURLs = new List<string>(photos);
        }
    }
}
