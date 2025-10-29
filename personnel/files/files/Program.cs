using System.IO;

namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../Projet";
            ListerFichiers(path);
            //ListerFichiers("C:\\");
        }
        static void ListerFichiers(string chemin, int niveau = 0)
        {
            if (!Directory.Exists(chemin))
            {
                return;
            }
            string indent = new string(' ', niveau * 2);

            try
            {
                Directory.GetFiles(chemin).ToList().ForEach(file =>
                {
                    Console.WriteLine(indent + "[F] " + Path.GetFileName(file));
                });
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Directory.GetDirectories(chemin).ToList().ForEach(directory =>
                {
                    Console.WriteLine(indent + "[D] " + Path.GetFileName(directory));
                    ListerFichiers(directory, niveau + 1);
                });
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
