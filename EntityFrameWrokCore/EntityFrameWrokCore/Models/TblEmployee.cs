using System;
using System.Collections.Generic;

namespace EntityFrameWrokCore.Models
{
    public partial class TblEmployee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Empemail { get; set; }
        public string Emppass { get; set; }
        public string Empcity { get; set; }
        public int? Empsalary { get; set; }
    }
}
