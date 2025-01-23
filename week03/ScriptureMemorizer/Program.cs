using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Mosiah", 2, 41, 41);
        Scripture scripture = new Scripture("And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.", ref1);
        
        Console.WriteLine("Original Scripture:");
        scripture.DisplayScripture();

        scripture.HideRandomWords(5);
        Console.WriteLine("\nScripture after hiding 5 random words:");
        scripture.DisplayScripture();
    }
}
