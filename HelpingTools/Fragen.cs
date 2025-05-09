using System;

namespace AdventureMan.HelpingTools
{
    public class Fragen
    {
        public static void HeroWahl()
        {
            Console.WriteLine("Wählen Sie Ihr Spieler: ");
            Console.WriteLine("[1] Human");
            Console.WriteLine("[2] Monster");
            Console.WriteLine("[3] Hybrid");
            
            int input = Convert.ToInt32(Console.ReadLine());
            
            
            switch (input)
            {
                case 1:
                    
                    break;
                case 2:
                
                    break;
                case 3:
                 
                    break;
            }
            
            
            
            
        }
    }
}