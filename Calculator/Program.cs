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

            int result = 0;

            if (operaatio == "summa")
            {
                result = int.Parse(x) + int.Parse(y);
            }
            else if (operaatio == "miinus")
            {
                result = int.Parse(x) - int.Parse(y);
            }
            else if (operaatio == "jako")
            {
                result = int.Parse(x) / int.Parse(y);
            }
            else if (operaatio == "kerto")
            {
                result = int.Parse(x) * int.Parse(y);
            }

            Console.WriteLine($"Interpolation example: Result {x} {operaatio} {y} = {result}");
        }

        //Tehtävä 6: Luo oma funktio, joka laskee tulokset operaation ja annettujen numeroiden peruseteella

        //Tehtävä 7: Lisää jako operaatioon if-lauseeseen tarkistus, että jos jompi kumpi numero on 0 ja ilmoita käyttäjälle virhetilanteesta (nollalla ei voi jakaa)
       
        //Tehtävä 8: Lisää if lauseseen myös toinen tapa laskea operaatio. Esimerkiksi summa operaatio voidaan tehdä
        //antamalla + tai summa teksti ja ohjelma osaa suorittaa operaation
    }
}