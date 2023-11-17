namespace Domain
{
    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Category { get; set; }
    }
}