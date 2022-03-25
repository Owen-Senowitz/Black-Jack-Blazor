namespace Black_Jack_Blazor.Data.BlackJack
{
    public enum GameState
    {
        NotStarted, //Before first hand
        Betting, //During the betting phase
        Dealing, //Only while dealer is dealing the initial deal
        InProgress, //After the initial deal, but before bets are paid out or collected.
        Insurance, //During an insurance bet
        Payout, //After the hand is over, during while bets are paid out or collected.
        Shuffling,
        Busted,
        BlackJack
    }
}
