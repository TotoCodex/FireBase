using FirebaseEJ;

namespace fIREBASE32
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            var fire = new Fire("prog-32");
            await fire.Guardar(new FirebaseEJ.Alumno("JJUan"));
            await fire.Leer2();
        }
    }
}