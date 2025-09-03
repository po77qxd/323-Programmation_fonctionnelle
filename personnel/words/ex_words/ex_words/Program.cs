namespace ex_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

            words.Where(x => !x.Contains("x")).Reverse().ToList().ForEach(x => Console.WriteLine($"ne contiennent pas la lettre x: {x}"));

            words.Where(x => x.Length >= 4).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($":ont 4 charactères ou plus: {x}"));

            words.Where(x => x.Length > words.Average(x => x.Length)).OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine($":ont autant de caractères que la moyenne du nombre de caractères de la liste: {x}"));
        }
    }
}