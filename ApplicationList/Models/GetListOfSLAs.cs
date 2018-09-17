using ApplicationList.ViewModel;
using AppListDal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationList.Models
{
    public class GetListOfSLAs
    {
        public List<AnSLAView> GetApps()
        {
            var db = new AppListContext();

            var appList = db.ApplicationList.Include(a => a.InfraSlas);
            List<AnSLAView> myList = new List<AnSLAView>();

            foreach (AppListDal.Model.ApplicationList app in appList)
            {
                AnSLAView asv = new AnSLAView();
                asv.Applicaiton = app.Application;
                asv.Availability = app.InfraSlas.Availability;
                asv.CloudOnPrem = app.InfraSlas.CloudOnPremSaas;
                asv.DB = app.InfraSlas.Db;
                asv.ID = app.InfraSlas.Id;
                asv.InfrComments = app.InfraSlas.InfraComment;
                asv.MnthlyDwnTme = app.InfraSlas.MnthlyDwnTmeMax;
                asv.OS = app.InfraSlas.Os;
                asv.PriorityLevel = app.InfraSlas.PriorityLevel;

                myList.Add(asv);
            }

            return myList;
        }
    }
}
