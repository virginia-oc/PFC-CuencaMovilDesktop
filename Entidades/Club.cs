using Google.Cloud.Firestore;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [FirestoreData]
    public class Club
    {
        string emptyField = "(sin especificar)";

        [FirestoreProperty]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Category { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
        public string Phone { get; set; }
        [FirestoreProperty]
        public string Website { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public byte[]? Photo { get; set; }

        public Club(string name, string category, string descripcion,
            string email) 
        {        
            Name = name;
            Category = category;
            Description = descripcion;
            Email = email;
            Phone = emptyField;
            Website = emptyField;
        }   

        public Club(string name, string category, string descripcion, 
            string phone, string website, string email, byte[] photo) 
            : this(name, category, descripcion, email)
        {
            Website = website;
            Phone = phone;
            Photo = photo;
        }
    }
}
