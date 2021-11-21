namespace TailoringServiceCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bill
    {
        public int BillId { get; set; }

        public int Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string Payment { get; set; }

        public int Status { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
