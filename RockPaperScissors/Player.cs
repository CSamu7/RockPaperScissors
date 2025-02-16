class Player {
    public GameOptions Option { get; set; }
    public void PickOption() {
        Console.Write("Pick rock, paper or scissors: ");
        string option = Console.ReadLine().ToLower();

        Option = option switch {
            "rock" => GameOptions.Rock,
            "paper" => GameOptions.Paper,
            "scissors" => GameOptions.Scissors,
            _ => GameOptions.Rock
        };
    }
}

