namespace balatrogamemain
{
    interface ICard
    {
        CardValue Value { get; }
        Suit Suit { get; }
        int Score { get; }
    }

    interface IExtraCard : ICard
    {
        int Bonus { get; }
        string Effect { get; }
    }

    interface IHand
    {
        List<ICard> Cards { get; }
        void Add(ICard card);
        void Remove(ICard card);
        int GetScore();
        void Show();
    }
}
