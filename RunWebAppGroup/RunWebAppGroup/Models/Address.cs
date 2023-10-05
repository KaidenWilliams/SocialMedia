using System.ComponentModel.DataAnnotations;

namespace RunWebAppGroup.Models
{
    public class Address
    {
        //Think of Poco as database table, only think of Pocos as that not normal classes 
        //Goal is to fill up models with data from datatable
        //String is going to be varchar in data table

        [Key]
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
