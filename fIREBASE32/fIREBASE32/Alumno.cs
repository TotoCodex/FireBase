using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseEJ
{
    [FirestoreData]
    public class Alumno
    {
        [FirestoreProperty]
        public string Name { get; set; }
        
        public Alumno(): this(""){ }
        public Alumno(string name)
        {
        }

    }
}
