namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Genre { get; set; }
        public required decimal Price { get; set; }
        public required DateTime ReleasedDate { get; set; }
    }
}