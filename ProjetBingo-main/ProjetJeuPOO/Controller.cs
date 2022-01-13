using System;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merci d'avoir choisi le jeu du SimiliPendu");
        }

        private void afficherMenu()
        {
            string choix;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Bingo");
                Console.WriteLine("2 - Black Jack");
                Console.WriteLine("3 - Pendu");
                Console.WriteLine("4 - Quitter");

                choix = Console.ReadLine();
                selectChoice(choix);
            } while (choix != "4");
        }


        private void selectChoice(string selection)
        {

            switch (selection)
            {

                case "1":
                    jouerBingo();
                    break;
                case "2":
                    jouerBlackJack();
                    break;
                case "3":
                    jouerPendu();
                    break;
                default:
                    break;
            }

        }
        private void jouerBingo() 
        {
        }
        private void jouerBlackJack() 
        {
        }
        private void jouerPendu() 
        {
        }
    }
}

