using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using AppListDal.Model;

namespace AppTestDal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var db = new AppListContext();

            var appList = db.ApplicationList.Include(a => a.Strategy).Include(b => b.SecurityCompliance);

            foreach (ApplicationList app in appList)
            {
                Console.WriteLine("ID: {0}, {1}, BO: {2}", app.Id, app.Application, app.BusinessOwner);
                if (!String.IsNullOrEmpty(app.Strategy.Sap))
                {
                    Console.WriteLine("              {0}", app.Strategy.Sap);
                    Console.WriteLine("           Work Councel Questionaire Complet:{0}  ", app.SecurityCompliance.WcquestionaireComplete);
                }
            }

            var pps = db.ApplicationList.Where(a => a.Id == 120).Include(a => a.Strategy).Include(b => b.SecurityCompliance).Include(s => s.Arch);

            foreach (ApplicationList anApp in pps)
            {
                Console.WriteLine("ID: {0}, {1}, BO: {2}", anApp.Id, anApp.Application, anApp.BusinessOwner);
                if (!String.IsNullOrEmpty(anApp.Strategy.Sap))
                {
                    Console.WriteLine("              {0}", anApp.Strategy.Sap);
                    Console.WriteLine("           Work Councel Questionaire Complet:{0}  ", anApp.SecurityCompliance.WcquestionaireComplete);
                }
            }

            var colNames = db.TbleColumn;
            foreach (TbleColumn tc in colNames)
            {
                Console.WriteLine("{0}, {1}, {3}, {2}", tc.Id, tc.ColumnName, tc.Definition, tc.Table);
            }
            Console.ReadKey();

        }
    }
}
