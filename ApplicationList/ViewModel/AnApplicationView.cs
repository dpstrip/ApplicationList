using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationList.Models;

namespace ApplicationList.ViewModel
{
    public class AnApplicationView
    {
        private string v;

        public AnApplicationView(string v)
        {
            this.v = v;
            GetAnApp anAp = new GetAnApp(v);
            anAp.FillInViewModel(this);

        }

        public AnApplicationView()
        {
           

        }

        public int ID { get; set; }
        public string Application { get; set; }
        public string FunctionalArea { get; set; }
        public string ApplicationDescription { get; set; }
        public string EnterprisevsPlantSpecific { get; set; }
        public string ArchLayer { get; set; }
        public string Notes { get; set; }
        public string BusinessOwner { get; set; }
        public string ITOwner { get; set; }
        public string TechOwner { get; set; }
        public string Path { get; set; }
        public string LocationUsed { get; set; }
        public string AppType { get; set; }
        public string TypesOfUser { get; set; }
    }


}
