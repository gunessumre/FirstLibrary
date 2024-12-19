namespace FirstLibrary.Models
{
    internal class Game
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public required string Platform { get; set; }
        public decimal Rating { get; set; }
    }
}
