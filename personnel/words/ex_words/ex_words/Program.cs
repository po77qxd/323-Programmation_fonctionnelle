using System.Text.RegularExpressions;

namespace ex_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1A
            //string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

            //words
            //    .Where(x => !x.Contains("x"))
            //    .Reverse()
            //    .ToList()
            //    .ForEach(x => Console.WriteLine($"ne contiennent pas la lettre x: {x}"));

            //words.Where(x => x.Length >= 4).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($":ont 4 charactères ou plus: {x}"));

            //words.Where(x => x.Length > words.Average(x => x.Length)).OrderByDescending(x => x).ToList()
            //    .ForEach(x => Console.WriteLine($":ont autant de caractères que la moyenne du nombre de caractères de la liste: {x}"));

            //1B
            //string[] words = { "whatThe!!!", "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "My kingdom for a horse !", "Ooops I did it again" };

            //words.Skip(1).SkipLast(2)
            //    .ToList().ForEach(x => Console.WriteLine($"Données parasite 1: {x}"));

            //1C
            //string[] words = { "+++++", "<<<<<", ">>>>>", "bonjour", "hello", "@@@@", "vert", "rouge", "bleu", "jaune", "#####", "%%%%%%%" };

            ////words.Where(x => Regex.IsMatch(x, "[a-zA-Z]")).ToList().ForEach(x => Console.WriteLine($"Données parasite 2: {x}"));
            //words.OrderBy(x => x).SkipWhile(x => !Regex.IsMatch(x, "[a-zA-Z]")).ToList().ForEach(x => Console.WriteLine($"Données parasite 2: {x}"));
            //oui on peut faire avec SkipWhile, on triant dans l'ordre a-z, donc les char spéciaux seront au début et les mots a la fin
            //donc dès que le skip while rencontre un mot il renvoie toute la fin de la liste, donc tout les mots

            //Partie 2
            string word = "aba";
            //Func<char, int> NumberOfLetter = letter => word.Count(x => x == letter);

            

            Dictionary<char, double> repartition = new Dictionary<char, double>()
            {
                {'a', 0.0815},
                {'b', 0.0097},
            };
            Dictionary<char, int> repartitionInWord = new Dictionary<char, int>();

            Action<char> CountLetter = (char letter) => {
                if (repartitionInWord.ContainsKey(letter))
                {
                    repartitionInWord[letter]++;
                }
                else {
                    repartitionInWord.Add(letter, 1);
                }
            };

            //.ForEach(letter => Console.WriteLine(repartition[letter]));
            //double epsilon = word.Where(x => repartition.ContainsKey(x)).ToList()
            //    //Aggregate(initial sum, (sum, letter) => condition ? sum + valeur : sum, renvoyer la somme)
            //    //si moins de 1 lettre, ajouter le epsilon aux total, sinon calculer le epsilon/nombre d'occurance de la lettre
            //    .Aggregate(0, (double sum, char letter) => NumberOfLetter(letter) < 1 ? sum + repartition[letter] : sum + (repartition[letter] / NumberOfLetter(letter)), sum => sum); 
            //Console.WriteLine(epsilon);

            word.Where(x => repartition.ContainsKey(x)).ToList().ForEach(letter => CountLetter(letter));

            double epsilon = repartitionInWord.Aggregate(0, (double sum, char letter) => repartitionInWord[letter] <= 1 ?  sum + repartition[letter] : sum + (repartition[letter] / repartitionInWord[letter]), sum => sum);

        }
    }
}