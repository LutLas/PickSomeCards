using System;

namespace PickSomeCards
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string numberOfCardsToPick = Console.ReadLine();
            if (int.TryParse(numberOfCardsToPick, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickRandonCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            { 
                Console.WriteLine("Invalid Input");
            } 
        }
    }
}
