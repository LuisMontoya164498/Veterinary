using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El documento es requerido")]
        public String Documento { get; set; } = null;

        [Required(ErrorMessage = "El primer nombre es requerido")]

        public string FirstName { get; set; } = null;

        [Required(ErrorMessage = "El apellido es requerido")]
        public string LastName { get; set; } = null;

        public string FixedPhone { get; set; } = null;

        [Required(ErrorMessage = "El número del celular es requerido")]

        public string CellPhone { get; set; } = null;

        [Required(ErrorMessage = "La dirección es requerida")]
        public string Address { get; set; } = null;


        public string FullName => $"{FirstName}{LastName}";






    }
}
