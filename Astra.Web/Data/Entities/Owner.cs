using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Astra.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }


        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FirstName{ get; set; }


        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string LastName { get; set; }


        [Display(Name = "Fixed Phone")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FixedPhone { get; set; }

        [Display(Name = "Cell Phone")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string CellPhone { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }

        #region Sintaxis vieja para concatenar propiedades de lectura
        /*
        public string FullName 
        {
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }
        */
        #endregion


        #region Sintaxis actual para concatenar propiedades de lectura
        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        #endregion

        public ICollection<Pet> Pets { get; set; }

    }
}
