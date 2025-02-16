class Game {
    public GameResult GetWinner(Player player1, Player player2) {
        if(player1.Option == player2.Option) return GameResult.Draw;

        if (player1.Option == GameOptions.Paper) {
            return player2.Option == GameOptions.Rock ? GameResult.Win : GameResult.Lose;
        }

        if(player1.Option == GameOptions.Rock) {
            return player2.Option == GameOptions.Scissors ? GameResult.Win : GameResult.Lose;
        }

        if(player1.Option == GameOptions.Scissors) 
            return player2.Option == GameOptions.Paper ? GameResult.Win : GameResult.Lose;

        return GameResult.Draw;
    }
}

