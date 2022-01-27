
namespace GameCard 
{
    // The pupose of the card class is to create an instance of a card for
    // each round the player does. The card will always have a value anywhere
    // between 1 and 13. 
    public class card 
    {
        public int cardValue;
        
        // This is the card contructor. It constructs a card instance and gives it 
        //a default value of one. This value is later changed in the method below.
        public card() 
        {
            cardValue = 1;
        }
        
        // This is the CardDraw method. A random card with the value anywhere between
        // 1 to 13 is drawn and given to the player. 
        public int CardDraw() 
        {
            Random draw = new Random();
           cardValue = draw.Next(1, 14);

            return cardValue;
        }
    }
}