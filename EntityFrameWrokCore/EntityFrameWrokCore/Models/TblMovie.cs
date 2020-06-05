using System;
using System.Collections.Generic;

namespace EntityFrameWrokCore.Models
{
    public partial class TblMovie
    {
        public int Mid { get; set; }
        public string Mname { get; set; }
        public string Mtype { get; set; }
        public DateTime? Mdate { get; set; }
        public bool? Mbooking { get; set; }
    }
}
