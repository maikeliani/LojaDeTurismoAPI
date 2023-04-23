namespace LojaDeTurismoAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string? Street { get; set; } // colokei ?

        public int Number { get; set; }

        public string NeighborHood { get; set; }

        public string ZipCode { get; set; }

        public string Complement { get; set; }

        public City City { get; set; }

        public DateTime Dt_Register { get; set; }
    }
}
