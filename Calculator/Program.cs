namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä x");
            var x = Console.ReadLine();

            Console.WriteLine("Syötä y");

            var y = Console.ReadLine();

            Console.WriteLine("Minkä operaation haluat suorittaa: ");
            Console.WriteLine("Saatavilla olevat operaatiot: summa, jako, miinus, kerto");

            //kerto = *
            //plussa = +
            //miinus = -
            //jako = /
            var operaatio = Console.ReadLine();

            int result = Calculate(int.Parse(x), int.Parse(y), operaatio); 

         

            Console.WriteLine($"Interpolation example: Result {x} {operaatio} {y} = {result}");

        }

        //Tehtävä 6: Luo oma funktio, joka laskee tulokset operaation ja annettujen numeroiden peruseteella

        //Tehtävä 7: Lisää jako operaatioon if-lauseeseen tarkistus, että jos jompi kumpi numero on 0 ja ilmoita käyttäjälle virhetilanteesta (nollalla ei voi jakaa)

        //Tehtävä 8: Lisää if lauseseen myös toinen tapa laskea operaatio. Esimerkiksi summa operaatio voidaan tehdä
        //antamalla + tai summa teksti ja ohjelma osaa suorittaa operaation

        //Esimerkki funktio tehtävä 6:een
        public static int Calculate(int x, int y, string operaatio)
        {
            int result = 0;

            if (operaatio == "summa")
            {
                result = x + y;
            }
            else if (operaatio == "miinus")
            {
                result = x- y;
            }

            return result;
        }

        //Yksinkertainen funktio
        public static int Miinus(int a, int b)
        {
            var result = a - b;

            return result;
        }

        public int Summa(int a, int b)
        {
            return a + b;
        }

       
    }
}