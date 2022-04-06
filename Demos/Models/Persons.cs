using System.ComponentModel.DataAnnotations;

namespace Demos.Models
{
    public class Persons
    {
        public Persons()
        {
         
        }

        [Required(ErrorMessage = "Please Enter First Name..")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name...")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter City...")]
        [Display(Name = "City")]       
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter State...")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Select the Gender...")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
    }
}
