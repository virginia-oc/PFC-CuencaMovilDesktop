using Google.Cloud.Firestore;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Club
    {
        string emptyField = "(sin especificar)";
      
        public string Id { get; set; }        
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public List<string> PhotoURLs { get; set; }

        public Club()
        {

        }

        /// <summary>
        /// Este método clona el club de Firebase que entre por parámetro
        /// a un nuevo objeto de la clase Club
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clubFirebase"></param>
        public Club(string id, ClubFirebase clubFirebase)
        {
            Id= id;
            Name = clubFirebase.Name;
            Category = clubFirebase.Category;
            Description = clubFirebase.Description;
            Phone = clubFirebase.Phone;
            Website = clubFirebase.Website;
            Email = clubFirebase.Email;
            PhotoURLs = clubFirebase.PhotoURLs;
        }

        public Club(string id, string name, string category, string descripcion,
            string email) 
        {      
            Id= id;
            Name = name;
            Category = category;
            Description = descripcion;
            Email = email;
            Phone = emptyField;
            Website = emptyField;
        }   

        public Club(string id, string name, string category, string descripcion, 
            string phone, string website, string email, List<string> photos) 
            : this(id, name, category, descripcion, email)
        {
            Website = website;
            Phone = phone;
            PhotoURLs = new List<string>(photos);
        }
    }
}
