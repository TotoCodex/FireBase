using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace FirebaseEJ
{
    public class Fire

    {
        private FirestoreDb db;

        public Fire(string projectID) 
        {
            
            
            db = FirestoreDb.Create(projectID);
            Console.WriteLine("Conectado");





        }
        public async Task Leer2() //async para funcionar await  
        {
            var colRef =db.Collection("materias/prog32/alumnos");
            var query = colRef.Limit(10);
            var snapshot= await query.GetSnapshotAsync();

            foreach (var item in snapshot.Documents) // me devuelve diccionarios
            {
                //var nombre = item.GetValue<string>("name");
               var alumno = item.ConvertTo<Alumno>();
                Console.WriteLine($"Nombre: {alumno.Name}");
            
            }
            
        
        }
        public async Task<DocumentReference> Guardar(Alumno alumno)
        {
            var colRef = db.Collection("materias/prog32/alumnos");
            //colRef.Document("123").SetAsync()
            var doc = await colRef.AddAsync(alumno);

            return doc;

        }
    }
}
