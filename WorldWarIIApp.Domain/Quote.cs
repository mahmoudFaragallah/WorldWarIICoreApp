namespace WorldWarIIApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Solider Solider { get; set; }
        public int SoliderId { get; set; }

    }
}