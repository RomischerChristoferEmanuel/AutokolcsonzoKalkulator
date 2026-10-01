using System.Diagnostics.Tracing;

List<int> ossze = new List<int> ();

int napidij = 12000;
bool viptag=false;
//2.feladat
for (int i = 0; ; i++)
{
    
    Console.WriteLine("Kibérelt napok: ");
    int napok=int.Parse (Console.ReadLine());
    if (viptag == false)
    {
        int tizotkedv = napok * napidij;
        if (napok < 7)
        {
            double kegv = tizotkedv;
            Console.WriteLine("\tbérlés adatai:");
            string nev=("Bérlő neve: ");
            Console.WriteLine($"Kölcsönzött napok(db): {napok}");
            Console.WriteLine($"VIP tag(true/false): {viptag}");
            
        }
        else
        {
            double kegv=tizotkedv*0.75;
            Console.WriteLine("\tbérlés adatai:");
            string nev = ("Bérlő neve: ");
            Console.WriteLine($"Kölcsönzött napok(db): {napok}");
            Console.WriteLine($"VIP tag(true/false): {viptag}");

        }

        if (napok < 3)
        {
            double kegv = tizotkedv;
            Console.WriteLine("\tbérlés adatai:");
            string nev = ("Bérlő neve: ");
            Console.WriteLine($"Kölcsönzött napok(db): {napok}");
            Console.WriteLine($"VIP tag(true/false): {viptag}");
        }
        else
        {
            double kegv = tizotkedv * 0.95;
            Console.WriteLine("\tbérlés adatai:");
            string nev = ("Bérlő neve: ");
            Console.WriteLine($"Kölcsönzött napok(db): {napok}");
            Console.WriteLine($"VIP tag(true/false): {viptag}");
            
            
        }
        
     
        
    }

    if (viptag == true)
    {
        int tizotkedv = napok * napidij;
        double kegv = tizotkedv * 0.75;
        Console.WriteLine("\tbérlés adatai:");
        string nev = ("Bérlő neve: ");
        Console.WriteLine($"Bérlő neve: {nev}");
        Console.WriteLine($"Kölcsönzött napok(db): {napok}");
        Console.WriteLine($"VIP tag(true/false): {viptag}");
    }

    //3.feladat

    
}


