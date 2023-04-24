namespace LojaDeTurismoAPI.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Adress { get; set; }

        public DateTime Dt_Register { get; set; }

        public double Price { get; set; }

    }
}
