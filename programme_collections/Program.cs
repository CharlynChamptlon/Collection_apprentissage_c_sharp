// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace programme_collections
{
    class Program
    {
        static int SommeTableau(int[] tab)
        {
            int somme = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                somme += tab[i];
            }
            return (somme);
        }

        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0; i < tableau.Length ; i++)
            {
                Console.WriteLine($"[{i}] {tableau[i]}");
                
            }
        }

        static void AfficherValeurMaximale(int[] tableau)
        {
            int max = tableau[0];
            for (int i = 1;i < tableau.Length ; i++)
            {
                if (max < tableau[i])
                {
                    max = tableau[i];
                }
            }
            Console.WriteLine($"La valeur maximale est : {max}.");
        }
        static void Tableaux()
        {
            
            //int[] t = { 200,40,15,8,12 };
            const int TAILLE_TABLEAU = 20;
            int[] t = new int[TAILLE_TABLEAU];
            Random rand = new Random();
            for (int j = 0; j < TAILLE_TABLEAU; j++)
            {
                t[j] = rand.Next(1,101);
            }
            AfficherTableau(t);
            AfficherValeurMaximale(t);
            
        }

        static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
            int longueurMax = 0;
            string nomLong = "";
            if (!ordreDescendant)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine($"[{i}] : {liste[i]}");
                    if (liste[i].Length > longueurMax)
                    {
                        longueurMax = liste[i].Length;
                        nomLong = liste[i];
                    }
                }
            }
            else
            {
                for (int i = liste.Count-1; i >=0; i--)
                {
                    Console.WriteLine($"[{i}] : {liste[i]}");
                    if (liste[i].Length > longueurMax)
                    {
                        longueurMax = liste[i].Length;
                        nomLong = liste[i];
                    }
                }
            }
            Console.WriteLine($"Le nom le plus long est : {nomLong}");
        }

        static void AfficherElementsCommuns(List<string> l1, List<string> l2)
        {
            List<string> l = new List<string>();

            for (int i =0; i<l1.Count; i++)
            {
                if (l2.Contains(l1[i]))
                {
                    l.Add(l1[i]);
                }
            }
            AfficherListe(l);
        }
        static void Listes()
        {
            /*List<int> liste = new List<int>();
            liste.Add(5);
            liste.Add(8);
            liste.Add(10);
            AfficherListe(liste);*/

            /*List<string> listeNoms = new List<string>();
            while(true)
            {
                Console.Write("Rentrez un nom (ENTER pour finir): ");
                string nom = Console.ReadLine();

                if (nom == "") { break; }

                if (listeNoms.Contains(nom))
                {
                    Console.WriteLine("ERREUR : ce nom est déjà dans la liste.");
                }
                else
                {
                    listeNoms.Add(nom);
                }
                
            }


            for (int i = listeNoms.Count - 1; i >= 0; i--)
            {
                int longCara = listeNoms[i].Length;
                char cara = listeNoms[i][longCara - 1];
                if (cara == 'e')
                {
                    listeNoms.Remove(listeNoms[i]);
                }
            }
            //List<string> lesPremiersNoms = listeNoms.GetRange(0, 3);
            AfficherListe(listeNoms,false);*/

            List<string> liste1 = new List<string>() { "paul", "jean", "pierre", "emilie", "martin"};
            List<string> liste2 = new List<string>() { "sophie", "jean", "martin", "toto" };

            AfficherElementsCommuns(liste1,liste2);

        }

        static void ArrayListe()
        {
            ArrayList a = new ArrayList();
            a.Add("Toto");
            a.Add(49);
            a.Add(true);
            a.Add(false);

            for (int i = 0; i < a.Count;i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void ListesDeListes()
        {
            var pays = new List<List<string>>();

            pays.Add(new List<string> {"France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" });
            pays.Add(new List<string> { "Etats-Unis", "New-York", "Chicago", "Los Angeles", "San Francisco" });
            pays.Add(new List<string> { "Italie", "Venise", "Florence", "Milan", "Pise", "Rome", "Turin" });

            for (int i = 0; i < pays.Count;i++)
            {
                var p = pays[i];
                Console.WriteLine(p[0] + " - " + (p.Count-1) + " villes");
                for (int j  = 1; j < p.Count;j++)
                {
                    Console.WriteLine("  "+p[j]);
                }
                Console.WriteLine();
            }

        }

        static void Dictionnaire()
        {
            string personneAChercher = "Martin";
            var d = new Dictionary<string, string>();
            d.Add("Jean", "0682456972");
            d.Add("Marie", "0674235981");
            d["Martin"] = "0625147895";

            if (d.ContainsKey(personneAChercher))
            {
                Console.WriteLine(d[personneAChercher]);
            }
            else
            {
                Console.WriteLine("Cette personne n'a pas été trouvée.");
            }
            
        }

        static void BoucleForEach()
        {
            //var noms = new string[] { "Toto", "Jean", "Pierre" };
            //var noms = new List<string> {"Toto","Jean","Pierre" };

            

            /*for (int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine(noms[i]);
            }
            foreach (var nom in noms)
            {
                Console.WriteLine(nom);
            }*/

            var d = new Dictionary<string, string>();
            d.Add("Jean", "0682456972");
            d.Add("Marie", "0674235981");
            d["Martin"] = "0625147895";

            foreach(var e in d)
            {
                Console.WriteLine(e.Key + ": " + e.Value);
            }

        }

        static void TrisEtLinq()
        {
            /*var noms = new string[] { "Toto", "Jean", "Pierre","Emilie","Sophie","Martin","Benoit","Vincent","Paul" };
            //Tri si c'est une liste
            //noms.Sort();
            //Tri si c'est un tableau
            //Array.Sort(noms);
            var noms2 = noms.OrderByDescending(e => e[e.Length - 1]);
            var noms3 = noms2.Where(nom => nom.Length > 4).ToList();

            foreach (var nom in noms3)
            {
                Console.WriteLine(nom);
            }*/

            var notes = new List<int> { 4,8,1,9,2};
            notes = notes.OrderBy(n => -n).ToList();
            notes = notes.Where(n => n <= 5).ToList();
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }

        }

        static void MaFonction(out int p)
        {
            ///
            p = 10;
        }

        static void MaFonction2(List<int> p)
        {
            p[0] = 10;
        }
        static void PassageValeursOuRef()
        {
            int a = 5;
            //MaFonction(a);  //Passage par valeur
            MaFonction(out a);  //Passage par ref
            Console.WriteLine(a);

            /*var l = new List<int> { 5};
            MaFonction2(l);  //Passage par référence

            Console.WriteLine(l[0]);*/

            int num = 0;
            if (int.TryParse("hfc",out num)){
                Console.WriteLine(num);
                num++;
            }
            else
            {
                Console.WriteLine("Problème de conversion");
            }

        }

        static void Main(string[] args)
        {
            //Tableaux();
            //Listes();
            //ArrayListe();
            //ListesDeListes();
            //Dictionnaire();
            //BoucleForEach();
            //TrisEtLinq();
            PassageValeursOuRef(); 
        }
    }
}
