namespace ReservationApi.Infrastructure.Model
{
    public class Room : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
    }
}