namespace NASA_API.Domain.Models
{
    public class Rover
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string NasaUrl { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public double Weight { get; set; }
        public int NumberOfWheels { get; set; }
    }
}
