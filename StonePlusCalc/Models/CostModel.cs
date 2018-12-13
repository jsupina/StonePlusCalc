using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StonePlusCalc.Models
{
    public class CostModel
    {
        public double Tons { get; set; }
        public double MPPT { get; set; }
        public double FPPT { get; set; }
        public double FI { get; set; }
        public double FC { get; set; }
        public double VI { get; set; }
        public double VC { get; set; }
        public bool check { get; set; }
        public string Code { get; set; }

    }
}