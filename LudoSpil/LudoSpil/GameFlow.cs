using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    //Makes the colors for the Ludo game
    public enum gameColor { yellow, blue, red, green };
    public class GameFlow
    {
        private int numberOfPlayers;
        private Player[] players;
        private int playerturn = 1;
        private bool GameRunning = true;

        private Dice dice = new Dice();


        public GameFlow()
        {
            MainMenu();
            Console.ReadKey();
        }

        //MainMenu der ikke kan ændres og ikke skal returnerer nogle værdier (void)
        private void MainMenu()
        {
            Console.WriteLine("Velkommen til Ludo");
            SetNumberOfPlayers();
            CreatePlayers();
            ShowPlayers();
        }

        private void SetNumberOfPlayers()
        {
            Console.Write("Hvor mange spillere skal være med?: ");


            while(numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                if(!int.TryParse(Console.ReadKey().KeyChar.ToString(), out this.numberOfPlayers))
                {
                    Console.WriteLine();
                    Console.WriteLine("Ugyldig værdi, vælg et tal mellem 2 og 4");
                }
            }
        }

        private void CreatePlayers()
        {
            this.players = new Player[this.numberOfPlayers];
            for (int i = 0; i < this.numberOfPlayers; i++)
            {
                Console.WriteLine();
                Console.Write("Hvad hedder spiller {0:D}? : ", (i + 1));
                String name = Console.ReadLine();
                String color = "";
                players[i] = new Player(name, color);

            }
        }
        private void ShowPlayers()
        {
            Console.WriteLine();
            Console.WriteLine("Her er dine spillere: ");
            foreach (Player pl in this.players)
            {
                Console.WriteLine(pl.GetName + " med farven: " + pl.GetColor);
            }
        }
    }
}
