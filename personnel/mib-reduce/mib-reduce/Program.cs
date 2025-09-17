namespace mib_reduce
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
