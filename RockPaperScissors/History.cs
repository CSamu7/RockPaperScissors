class History {
    public int Wins { get; private set; } = 0;
    public int Losses { get; private set; } = 0;
    public int Draws { get; private set; } = 0;

    public void AddRecord(GameResult result) {
        if (result == GameResult.Win) Wins++;

        if (result == GameResult.Lose) Losses++;
        
        if (result == GameResult.Draw) Draws++;
    }

    public void ShowHistory() {
        Console.WriteLine("Player 1 - Draws - Player 2");

        Console.WriteLine($"{Wins} {Draws} {Losses}");
    }
}
