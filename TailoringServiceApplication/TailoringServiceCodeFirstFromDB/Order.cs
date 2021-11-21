namespace TailoringServiceCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Bills = new HashSet<Bill>();
            Measurements = new HashSet<Measurement>();
        }

        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Article { get; set; }

        [Required]
        [StringLength(50)]
        public string Service { get; set; }

        [Required]
        [StringLength(50)]
        public string Satus { get; set; }

        [Required]
        [StringLength(50)]
        public string Comment { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string PickUpDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}
