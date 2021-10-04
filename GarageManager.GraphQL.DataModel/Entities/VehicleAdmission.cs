using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GarageManager.GraphQL.DataModel.Entities
{
    public class VehicleAdmission
    {
        [Required]
        public Guid VehicleId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public int Odometer { get; set; }

        [Required]
        [Range(1, 10)]
        public int FuelLevel { get; set; }

        [Required]
        public Guid HandledBy { get; set; }

        [Required]
        public DateTime AdmissionDate { get; set; }

        public DateTime? ReleasedDate { get; set; }

        [Required]
        public AdmissionStatus Status { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual User User { get; set; }
    }

    public enum AdmissionStatus
    {
        Todo,
        OnGoing,
        Hold,
        Finished,
        Released
    }
}
