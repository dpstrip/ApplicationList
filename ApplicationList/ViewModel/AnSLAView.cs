using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationList.ViewModel
{
    public class AnSLAView
    {
        public int ID { get; set; }
        public string Applicaiton { get; set; }
        public string MnthlyDwnTme { get; set; }
        public string PriorityLevel { get; set; }
        public string DB { get; set; }
        public string InfrComments { get; set; }
        public string CloudOnPrem { get; set; }
        public string OS { get; set; }
        public string Availability { get; set; }
    }
}
