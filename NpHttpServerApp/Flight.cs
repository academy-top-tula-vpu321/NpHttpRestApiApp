namespace NpHttpServerApp
{
    public class Flight
    {
        static public int GlobalId { set; get; } = 0;

        public int Id { get; set; }
        public string Title { get; set; }
        public string ToCity { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }

        public Flight(string title, string toCity, DateOnly date, TimeOnly time)
        {
            Id = ++GlobalId;
            Title = title;
            ToCity = toCity;
            Date = date;
            Time = time;
        }
    }
}
