using System;
using System.ComponentModel.DataAnnotations;

namespace stacks_Jakob_Cook 
{
    class Program
    {
        static void Main(string[] args) 
        {
            //the cards to be shown
            Card[] myCardsArray = new Card[]
            {
                new Card("A", "Spades"),
                new Card("J", "Clubs"),
                new Card("Q", "Diamonds"),
                new Card("Q", "Hearts"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds"),
            };  
            
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);
            //tells the cards in the deck
            Console.WriteLine("Cards in Deck :");
            foreach (Card card in startingDeck) 
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");
            //card list
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            Console.WriteLine("Got any 8's?");
            if(startingDeck.Count > 0) 
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("Cards in Deck:");
            foreach(Card card in startingDeck) 
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}