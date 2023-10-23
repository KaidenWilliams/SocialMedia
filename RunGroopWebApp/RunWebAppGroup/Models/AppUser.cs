using System.ComponentModel.DataAnnotations;

namespace RunWebAppGroup.Models
{
    public class AppUser

    //? Operator used to make a value nullable, can either be null or specified type
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public Address? Address { get; set; }

        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
