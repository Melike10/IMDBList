// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

namespace IMDBList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> Imdblist = new List<Movie>();
            bool devam;
            do
            {
                Console.Write("Film Adı: ");
                string fname = Console.ReadLine();
                double imdpuan;
                bool puangiris;

                // check the imbdpuan 
                do
                {
                    Console.Write("IMDB Puanı (0 ile 10 arasında): ");
                    puangiris = double.TryParse(Console.ReadLine(), out imdpuan);


                } while (!puangiris || imdpuan < 0 || imdpuan >10);

                // create movie
                Movie movie = new Movie(imdpuan, fname);
                // add list
                Imdblist.Add(movie);

            control: Console.WriteLine("Film girişine devam etmek istiyor musunuz?(e/h)");
                string secim = Console.ReadLine().ToLower();

                if (secim == "e")
                    devam = true;
                else if (secim == "h")
                    devam = false;
                else
                {
                    Console.WriteLine("Yanlış veri girdiniz. E ve H girmeniz yeterlidir.");
                    goto control;

                }


            } while (devam);


            // print all list
            Console.WriteLine("*** Girilen Film Listesi ***");
            Console.WriteLine("Film Adı / IMDB Puanı");
            foreach (Movie movie in Imdblist)
            {
                Console.WriteLine(movie.Name + " " + movie.ImdbPuan);

            }

            // print just impdpuan 4 between 9 movies
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("IMDB Puanı 4 ve 9 arasında olan filmler");
            var list4From9= Imdblist.Where(list => list.ImdbPuan >= 4 && list.ImdbPuan <= 9);

            foreach (Movie movie in list4From9)
            {
                Console.WriteLine(movie.Name+" "+ movie.ImdbPuan);
            }

            // print just movies that starts with a or A
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("A harfi ile başlayan filmler");
            var movieStartsWithA= Imdblist.Where(list => list.Name.StartsWith('A') || list.Name.StartsWith('a'));

            foreach (Movie movie in movieStartsWithA)
            {
                Console.WriteLine(movie.Name+" "+movie.ImdbPuan);
            }



        }
    }
}
