namespace LojaDeTurismoAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public Address SourceAdress { get; set; }

        public Address DestinationAdress { get; set; }

        public Client Client { get; set; }

        public DateTime Dt_Register { get; set; }

        public double Price { get; set; }
    }
}
