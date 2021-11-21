namespace TailoringServiceCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Measurement
    {
        public int MeasurementId { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        public double? Bust { get; set; }

        public double? Neck { get; set; }

        public double? Waist { get; set; }

        public double? Hip { get; set; }

        public double? Shoulder { get; set; }

        public double? Arm { get; set; }

        public double? Leg { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
