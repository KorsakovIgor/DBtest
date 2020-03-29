using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DBtest
{
    public partial class  StaffInfo
    {
        [Required]
        [StringLength(100)]
        public string second_name { get; set; }

        [Required]
        [StringLength(100)]
        public string first_name { get; set; }

        [Required]
        [StringLength(100)]
        public string last_name { get; set; }

        [Required]
        [StringLength(100)]
        public string status_name { get; set; }

        [Required]
        [StringLength(100)]
        public string dep_name { get; set; }

        [Required]
        [StringLength(100)]
        public string post_name { get; set; }

        public DateTime? date_employ { get; set; }

        public DateTime? date_unemploy { get; set; }

      
    }
}
