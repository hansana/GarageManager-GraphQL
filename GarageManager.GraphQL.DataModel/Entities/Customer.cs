using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GarageManager.GraphQL.DataModel.Entities
{
    public class Customer
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string MobileNumber { get; set; }

        public string HomeNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual ICollection<CustomerVehicle> CustomerVehicles { get; set; }

        public virtual ICollection<VehicleAdmission> VehicleAdmissions { get; set; }
    }
}
