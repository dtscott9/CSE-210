
namespace GameCard {

    public class card {

        public int cardValue = 0;
        public int points = 0; 
        public int playerGuess = 0;



        public card() {

        }



        public int CardDraw() {
            Random draw = new Random();
           cardValue = draw.Next(1, 14);

            return cardValue;


        }






    }









}