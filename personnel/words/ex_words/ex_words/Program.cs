using System.Text.RegularExpressions;

namespace ex_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1A
            //string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

            //words.Where(x => !x.Contains("x")).Reverse().ToList().ForEach(x => Console.WriteLine($"ne contiennent pas la lettre x: {x}"));

            //words.Where(x => x.Length >= 4).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($":ont 4 charactères ou plus: {x}"));

            //words.Where(x => x.Length > words.Average(x => x.Length)).OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine($":ont autant de caractères que la moyenne du nombre de caractères de la liste: {x}"));

            //1B
            //string[] words = { "whatThe!!!", "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "My kingdom for a horse !", "Ooops I did it again" };

            //words.Where(x => x != words.ElementAt(0) && x != words.ElementAt(words.Length - 1) && x != words.ElementAt(words.Length - 2))
            //    .ToList().ForEach(x => Console.WriteLine($"Données parasite 1: {x}"));

            //1C
            string[] words = { "+++++", "<<<<<", ">>>>>", "bonjour", "hello", "@@@@", "vert", "rouge", "bleu", "jaune", "#####", "%%%%%%%" };

            //words.Where(x => Regex.IsMatch(x, "[a-zA-Z]")).ToList().ForEach(x => Console.WriteLine($"Données parasite 2: {x}"));
            words.OrderBy(x => x).SkipWhile(x => !Regex.IsMatch(x, "[a-zA-Z]")).ToList().ForEach(x => Console.WriteLine($"Données parasite 2: {x}"));
            //oui on peut faire avec SkipWhile, on triant dans l'ordre a-z, donc les char spéciaux seront au début et les mots a la fin
            //donc dès que le skip while rencontre un mot il renvoie toute la fin de la liste, donc tout les mots
        }
    }
}