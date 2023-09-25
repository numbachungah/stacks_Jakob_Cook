using System;
using System.Collections.Generic;
using System.Text;

namespace stacks_Jakob_Cook
{
    class Card
    {

        public string Number { get; }

        public string Suit { get; }

        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}
