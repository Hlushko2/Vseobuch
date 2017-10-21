using ConsoleApplication1._1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1._1
{
    class Program
    {

        static void Main(string[] args)
        {
            MyDbContext db = new MyDbContext();
            db.Rigeons.Add(new Rigeon() { Name = "dsfds" });
           // db.SaveChanges();
            db.Citys.Add(new City() { Name = "dsfd", Rigeons = new List<Rigeon>() { new Rigeon() { Name = "sad" } } });
            db.Citys.Where(x=>x.ID==1).First().Rigeons.Add(new Rigeon() {Name="if" });
            db.SaveChanges();
        }
    }
}
