using GameCard;


namespace GameDirector {
    
    public class Director {

       
       int totalScore = 300;

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

        public void CalcScore(int cardValue, string choice) 
        {
            
            
            card card1 = new card();

            int cardValue1 = card1.CardDraw();

            int score = 0;
            if (choice == "h" && cardValue1 > cardValue) {
                    score += 100;
            } 

            else if (choice == "l" && cardValue1 < cardValue) {
                score += 100;
            }

            else if (choice == "h" && cardValue1 < cardValue) {
                score -= 75;
            }

            else if (choice == "l" && cardValue1 > cardValue) {
                score -= 75;
            }

            else if (choice == "h" || choice == "l" && cardValue1 == cardValue)
            {
                Console.WriteLine("Wow! Lucky, you got the same card! That's 200 points");
                score += 200;
            }

            else {
                Console.WriteLine("That is not a valid choice, try again");
            }

            totalScore += score;

            Console.WriteLine($"The card was {cardValue1}");
            
            
           
        }

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