using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static ex_mib_map.Program;
using static System.Net.Mime.MediaTypeNames;

namespace ex_mib_map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produit> produits = new List<Produit> {
                    new Produit(1, "Bornand", "Pommes", 20, "kg", 6.90),
                    new Produit(1, "Bornand", "Poires", 16, "kg", 3.50),
                    new Produit(1, "Bornand", "Pastèques", 14, "pièce", 6.00),
                    new Produit(1, "Bornand", "Melons", 5, "kg", 7.00),
                    new Produit(2, "Dumont", "Noix", 20, "sac", 5.50),//8.60
                    new Produit(2, "Dumont", "Raisin", 6, "kg", 5.60),
                    new Produit(2, "Dumont", "Pruneaux", 13, "kg", 8.10),
                    new Produit(2, "Dumont", "Myrtilles", 12, "kg", 8.90),
                    new Produit(2, "Dumont", "Groseilles", 12, "kg", 5.20),
                    new Produit(3, "Vonlanthen", "Pêches", 8, "kg", 8.70),
                    new Produit(3, "Vonlanthen", "Haricots", 6, "kg", 6.90),
                    new Produit(3, "Vonlanthen", "Courges", 18, "pièce", 4.30),
                    new Produit(3, "Vonlanthen", "Tomates", 12, "kg", 9.40),
                    new Produit(3, "Vonlanthen", "Pommes", 20, "kg", 3.90),
                    new Produit(4, "Barizzi", "Poires", 5, "kg", 6.30),
                    new Produit(4, "Barizzi", "Pastèques", 6, "pièce", 2.50),
                    new Produit(4, "Barizzi", "Melons", 14, "kg", 4.20),
                    new Produit(4, "Barizzi", "Noix", 20, "sac", 7.50),
                    new Produit(4, "Barizzi", "Raisin", 15, "kg", 7.20),
                    new Produit(5, "Blanc", "Pruneaux", 5, "kg", 9.00),
                    new Produit(5, "Blanc", "Myrtilles", 18, "kg", 5.60),
                    new Produit(5, "Blanc", "Groseilles", 10, "kg", 2.10),
                    new Produit(5, "Blanc", "Pêches", 20, "kg", 6.40),
                    new Produit(5, "Blanc", "Haricots", 9, "kg", 2.90),
                    new Produit(6, "Repond", "Courges", 12, "pièce", 7.40),
                    new Produit(6, "Repond", "Tomates", 12, "kg", 4.20),
                    new Produit(6, "Repond", "Pommes", 15, "kg", 6.50),
                    new Produit(6, "Repond", "Poires", 18, "kg", 2.40),
                    new Produit(6, "Repond", "Pastèques", 7, "pièce", 5.70),
                    new Produit(7, "Mancini", "Pêches", 10, "kg", 2.90),
                    new Produit(7, "Mancini", "Haricots", 11, "kg", 6.70),
                    new Produit(7, "Mancini", "Courges", 10, "pièce", 6.40),
                    new Produit(7, "Mancini", "Tomates", 13, "kg", 1.50),
                    new Produit(7, "Mancini", "Pommes", 14, "kg", 7.00),
                    new Produit(8, "Favre", "Poires", 5, "kg", 8.40),
                    new Produit(8, "Favre", "Pastèques", 5, "pièce", 1.70),
                    new Produit(8, "Favre", "Haricots", 5, "kg", 3.00),
                    new Produit(8, "Favre", "Courges", 17, "pièce", 2.00),
                    new Produit(8, "Favre", "Tomates", 9, "kg", 5.20),
                    new Produit(9, "Bovay", "Pommes", 13, "kg", 7.70),
                    new Produit(9, "Bovay", "Poires", 5, "kg", 3.80),
                    new Produit(9, "Bovay", "Pastèques", 20, "pièce", 2.10),
                    new Produit(9, "Bovay", "Melons", 20, "kg", 6.40),
                    new Produit(9, "Bovay", "Noix", 13, "sac", 8.80),
                    new Produit(10, "Cherix", "Raisin", 8, "kg", 7.10),
                    new Produit(10, "Cherix", "Pruneaux", 19, "kg", 7.90),
                    new Produit(10, "Cherix", "Myrtilles", 9, "kg", 4.20),
                    new Produit(10, "Cherix", "Groseilles", 10, "kg", 4.40),
                    new Produit(10, "Cherix", "Pêches", 9, "kg", 4.40),
                    new Produit(11, "Beaud", "Haricots", 19, "kg", 8.40),
                    new Produit(11, "Beaud", "Courges", 16, "pièce", 8.70),
                    new Produit(11, "Beaud", "Tomates", 18, "kg", 5.30),
                    new Produit(11, "Beaud", "Pommes", 8, "kg", 7.30),
                    new Produit(11, "Beaud", "Poires", 13, "kg", 9.20),
                    new Produit(12, "Corbaz", "Pastèques", 15, "pièce", 7.40),
                    new Produit(12, "Corbaz", "Melons", 12, "kg", 1.60),
                    new Produit(12, "Corbaz", "Noix", 11, "sac", 7.50),
                    new Produit(12, "Corbaz", "Raisin", 16, "kg", 4.50),
                    new Produit(12, "Corbaz", "Pruneaux", 20, "kg", 3.30),
                    new Produit(13, "Amaudruz", "Myrtilles", 18, "kg", 5.70),
                    new Produit(13, "Amaudruz", "Groseilles", 19, "kg", 8.00),
                    new Produit(13, "Amaudruz", "Pêches", 12, "kg", 5.50),
                    new Produit(13, "Amaudruz", "Haricots", 13, "kg", 5.20),
                    new Produit(13, "Amaudruz", "Courges", 7, "pièce", 9.60),
                    new Produit(14, "Bühlmann", "Tomates", 12, "kg", 7.70),
                    new Produit(14, "Bühlmann", "Pommes", 17, "kg", 1.90),
                    new Produit(14, "Bühlmann", "Poires", 7, "kg", 3.00),
                    new Produit(14, "Bühlmann", "Pastèques", 11, "pièce", 6.90),
                    new Produit(14, "Bühlmann", "Melons", 7, "kg", 4.70),
                    new Produit(15, "Crizzi", "Noix", 10, "sac", 1.60),
                    new Produit(15, "Crizzi", "Raisin", 17, "kg", 7.80),
                    new Produit(15, "Crizzi", "Pruneaux", 18, "kg", 9.00),
                    new Produit(15, "Crizzi", "Myrtilles", 12, "kg", 3.00),
                    new Produit(15, "Crizzi", "Groseilles", 12, "kg", 3.50)
            };

            var i18n = new Dictionary<string, string>()
            {
                { "Pommes","Apples"},
                { "Poires","Pears"},
                { "Pastèques","Watermelons"},
                { "Melons","Melons"},
                { "Noix","Nuts"},
                { "Raisin","Grapes"},
                { "Pruneaux","Plums"},
                { "Myrtilles","Blueberries"},
                { "Groseilles","Berries"},
                { "Tomates","Tomatoes"},
                { "Courges","Pumpkins"},
                { "Pêches","Peaches"},
                { "Haricots","Beans"}
            };
            //ex 1
            Func<Produit, string> anonProducteur = p => p._producteur.Substring(0, 3) + "..." + p._producteur.Substring(p._producteur.Length - 1, 1);
            Func<string, string> translateProduct = productName => i18n[productName];
            Func<int, double, double> maxCA = (qte, prixParUnite) => qte * prixParUnite;

            produits
                .Select(p => (anonProducteur(p), translateProduct(p._produit), maxCA(p._qte, p._prixParUnite)))
                .ToList()
                .Where(x => x.Item1 == "Dum...t" &&  x.Item2 == "Nuts")
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            List<(string, string, double)> text = produits
                .Select(p => (anonProducteur(p), translateProduct(p._produit), maxCA(p._qte, p._prixParUnite)))
                .ToList()
                .Where(x => x.Item1 == "Dum...t" && x.Item2 == "Nuts")
                .ToList();
            //.ToString();
            //Console.WriteLine(text[0].Item1);
            File.WriteAllText("produitEx1.csv", $"Seller; Product; CA\n{text[0].Item1}; {text[0].Item2}; {text[0].Item3}");

            //ex2
            Func<string, string> anonProducteurMore = p => p.Substring(0, 1) + (p.Length - 1).ToString() + p.Substring(p.Length - 1, 1);
            Func<int, string> categorize = qte => qte < 10 ? "Stock faible" : qte > 15 ? "Stock eleve" : "Stock normal";
            Func<int, double, double> adjustUnitValue = (qte, ppu) => qte < 10 ? (ppu - ppu * 0.15) : qte > 15 ? ppu : (ppu - ppu * 0.05);
            Func<int, double, string> CApremium = (qte, prixParUnite) => qte * prixParUnite > 100 ? "Premium" : "Standard";

            var produitEx2 = produits
                .Select(p => (anonProducteurMore(p._producteur),
                                categorize(p._qte),
                                adjustUnitValue(p._qte, p._prixParUnite),
                                CApremium(p._qte, p._prixParUnite)))
                .ToList();
            //.ForEach(x => Console.WriteLine(x));

            //string json = ;
            //Console.WriteLine(json);


            //Mesure de performance
            Action dashboardLamba = () =>
            {
                var produitEx2 = produits
                    .Select(p => (
                        anonProducteurMore(p._producteur),
                        categorize(p._qte),
                        adjustUnitValue(p._qte, p._prixParUnite),
                        CApremium(p._qte, p._prixParUnite)))
                    .ToList();
            };
            var resultDashboardLamba = MesurePerf(dashboardLamba);
            Console.WriteLine("dashboardLamba : " + resultDashboardLamba);

            Action dashboardAnonObject = () =>
            {
                var produitEx2 = produits
                    .Select(p => new
                    {
                        prod = anonProducteurMore(p._producteur),
                        cat = categorize(p._qte),
                        value = adjustUnitValue(p._qte, p._prixParUnite),
                        quality = CApremium(p._qte, p._prixParUnite)
                    })
                    .ToList();
            };
            var resultdashboardAnonObject = MesurePerf(dashboardAnonObject);
            Console.WriteLine("dashboardAnonObject : " + resultdashboardAnonObject);
        }

        static (long time, long memory) MesurePerf(Action action, int iterations = 1000)
        {
            // Forcer le garbage collection avant mesure
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            var memoryBefore = GC.GetTotalMemory(false);
            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
            {
                action();
            }

            stopwatch.Stop();
            var memoryAfter = GC.GetTotalMemory(false);

            return (stopwatch.ElapsedMilliseconds, memoryAfter - memoryBefore);
        }

        public class Produit
        {
            public int _emplacement { get; private set; }
            public string _producteur { get; private set; }
            public string _produit { get; private set; }
            public int _qte { get; private set; }
            public string _unite { get; private set; }
            public double _prixParUnite { get; private set; }
            public Produit(int emplacement, string producteur, string produit, int qte, string unite, double prixParUnite)
            {
                _emplacement = emplacement;
                _producteur = producteur;
                _produit = produit;
                _qte = qte;
                _unite = unite;
                _prixParUnite = prixParUnite;
            }
        };
    }
}
