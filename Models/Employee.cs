using System.ComponentModel.DataAnnotations;

namespace WebApiRDSWithPostgreSql.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
		public string LastName { get; set; }

        public string Title { get; set; }

		public string Address { get; set; }

	}
}
