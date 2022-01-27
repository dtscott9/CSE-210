using GameCard;

namespace GameDirector 
{

    // The director class is basically the card dealer of the game. Inside
    // of this class are methods that present the player with a card, ask
    // them if they'd like to guess if the next card is higher or lower, and
    // ask them if they'd like to continue playing. 
    public class Director 
    {
       int totalScore = 300;

       //This DirectorChoice function calls the constructor from the card class
       // to create a new instance of the card, and then asks the player if 
       //they'd like to guess if the next card will be higher or lower. 
        public void DirectorChoice() 
        {
            card card = new card();

            int cardValue = card.CardDraw();

            Console.WriteLine($"Your card is {cardValue}");

            Console.WriteLine("Do you guess higher or lower for next card? [h/l] ");

            string choice = Console.ReadLine();
            choice = choice.ToLower();

            CalcScore(cardValue, choice);
        }

        // The CalcScore function calculates the player's current score based on
        // their choice from the previous method. If the player correctly guesses 
        // if the card is higher or lower, they gain 100 points. If they guess 
        // incorrectly, they lose 75 points. 
        public void CalcScore(int cardValue, string choice) 
        {
            card card1 = new card();

            int cardValue1 = card1.CardDraw();

            int score = 0;
            if (choice == "h" && cardValue1 > cardValue) 
            {
                    score += 100;
            } 

            else if (choice == "l" && cardValue1 < cardValue)
            {
                score += 100;
            }

            else if (choice == "h" && cardValue1 < cardValue) 
            {
                score -= 75;
            }

            else if (choice == "l" && cardValue1 > cardValue) 
            {
                score -= 75;
            }

            else if (choice == "h" || choice == "l" && cardValue1 == cardValue)
            {
                Console.WriteLine("Wow! Lucky, you got the same card! That's 200 points");
                score += 200;
            }

            else 
            {
                Console.WriteLine("That is not a valid choice, try again");
            }

            totalScore += score;

            Console.WriteLine($"The card was {cardValue1}");

        }

        // The GameStart function puts everything together to start the game.
        // It contains the main loop which keeps the game going unless the
        // player chooses to end it, or if the player's score reaches 0. 
        public void GameStart() 
        {
            bool keepPlaying = true;
            while (keepPlaying == true) 
            {
                DirectorChoice();

                if (totalScore <= 0) 
                {   
                    Console.WriteLine("Your score is 0 \n Game Over");
                    break;
                }

                Console.WriteLine($"Your current score is {totalScore}");

                Console.WriteLine("Would you like to keep playing? y/n ");
                string playGame = Console.ReadLine();
                playGame = playGame.ToLower();

                if (playGame == "y") 
                {
                    keepPlaying = true;
                }
               
                else if (playGame == "n")
                {   Console.WriteLine($"Game Over. Final score is {totalScore}");
                    keepPlaying = false;
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, try again");
                }
            }
        }
    }
}