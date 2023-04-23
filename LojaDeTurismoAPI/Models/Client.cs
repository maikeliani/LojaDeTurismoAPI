namespace LojaDeTurismoAPI.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }

        public Address Adress { get; set; }

        public DateTime Dt_Register { get; set; }
    }
}
