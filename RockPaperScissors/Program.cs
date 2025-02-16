Console.WriteLine("Rock-Paper-Scissors");

Player player1 = new Player();
Player player2 = new Player(); 
History history = new History();

while (true) {
    Game myGame = new Game();

    Console.WriteLine("If you misspell your option, it will be rock");

    Console.WriteLine("Player 1: ");
    player1.PickOption();

    Console.WriteLine("Player 2: ");
    player2.PickOption();
  
    GameResult result = myGame.GetWinner(player1, player2);

    history.AddRecord(result);

    history.ShowHistory();
}

enum GameOptions { Rock, Paper, Scissors}

enum GameResult { Win, Draw, Lose}