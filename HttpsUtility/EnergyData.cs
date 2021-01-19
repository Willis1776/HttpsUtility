using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace HttpsUtility
{
    public class EnergyData
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TotalPhase { get; set; }
        public string PhaseA { get; set; }
        public string PhaseB { get; set; }
        public string PhaseC { get; set; }
    }
}