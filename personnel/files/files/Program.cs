using System.IO;

namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../Projet";
            ListerFichiers(path);
        }
        static void ListerFichiers(string chemin)
        {
            if (!Directory.Exists(chemin))
            {
                return;
            }
            Directory.GetFiles(chemin).ToList().ForEach(file => Console.WriteLine(Path.GetFileName(file)));
            Directory.GetDirectories(chemin).ToList().ForEach(directory =>
            {
                Console.WriteLine(Path.GetFileName(directory));
                ListerFichiers(directory);
            });
        }
    }
}
