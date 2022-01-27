# Hilo

Hilo is a game of chance. In this game, the player must guess
if the next card drawn will be higher or lower than the previous 
card. The player starts out with 100 points and if the player 
guesses correctly they will rewarded 100 points. If they guess 
incorrectly, they will lose 75 points. The player can keep playing
that game as long as they want, however if the player's score reaches
0 the game will end. 

# Getting Started

In order for this program to work, you need to have .NET 6.0 or newer
installed. You can access the game by first opening up the terminal or 
powershell. Then, change directories to the folder that the program is 
contained in (type cd followed by the pathway in the command line). Finally,
enter the command "dotnet build" followed by the command "dotnet run" in the
command line. 

You can also run this program in an IDE (Integrated Development Environment)
such as Visual Studio Code. All you need to do is open the folder that contains
the program, and then select "Run Without Debugging" within the "Run" menu in
the top left. You can alternatively run it by selecting the play button icon
on the left (Run and Debug), and the green arrow icon that appears at the top. 

# Program Elements

This program is organized as follows:

hilo_game (this folder contains the entire game)
    -- Program.cs (this is where the program starts to run)
    -- card.cs (this file constructs the card object)
    -- director.cs (this file puts the card into play and prompts the user)
    -- hilo_game.csproj (this is the dotnet file)

# Technology Require

.Net 6.0

# Author

Dylan Scott
dtscott9@byui.edu 