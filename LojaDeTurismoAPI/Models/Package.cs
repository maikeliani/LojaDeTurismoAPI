namespace LojaDeTurismoAPI.Models
{
    public class Package
    {
        public int Id { get; set; }
        public Hotel Hotel { get; set; }

        public Ticket Ticket { get; set; }

        public DateTime Dt_Register { get; set; }

        public double Price { get; set; }

        public Client Client { get; set; }

    }
}
