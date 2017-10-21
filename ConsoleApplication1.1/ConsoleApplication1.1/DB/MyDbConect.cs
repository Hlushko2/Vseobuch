using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1._1.DB
{
   public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Rigeon> Rigeons { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Rigeon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Strit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    //public class Strit_Rigeon
    //{
    //    public int ID { get; set; }
    //    public Strit Name_Strit { get; set; }
    //    public Rigeon Name_Rigeon { get; set; }
    //    public override string ToString()
    //    {
    //        return Name_Strit.ToString() + "\nРайон: " + Name_Rigeon.ToString();
    //    }
    //}

    public class Adres
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Strit Name_Strit { get; set; }
        public Rigeon Name_Rigeon { get; set; }
        public override string ToString()
        {
            return Name.ToString();
        }
    }

    public class House
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Adres adres { get; set; }
        public override string ToString()
        {
            return Name.ToString();
        }
    }

    public class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Adres adres { get; set; }
        public override string ToString()
        {
            return Name.ToString();
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }        
        public DateTime Birthday { get; set; }
        public override string ToString()
        {
            return FirstName + LastName + Surname;
        }
    }

    public class Student_In_School
    {
        public int ID { get; set; }
        public Student student { get; set; }
        public School school { get; set; }
        public DateTime graduation { get; set; }
        public override string ToString()
        {
            return "s";
        }
    }

    public class Student_In_House
    {
        public int ID { get; set; }
        public Student student { get; set; }
        public House house { get; set; }
        public DateTime gra2duation { get; set; }
        public override string ToString()
        {
            return "s";
        }
    }

    class MyDbContext :DbContext
    {
        public MyDbContext() : base("Students") { }
        public MyDbContext(string str) : base(str) { }

        public virtual DbSet<City> Citys { get; set; }
        public virtual DbSet<Rigeon> Rigeons { get; set; }
        public virtual DbSet<Strit> Strits { get; set; }
        public virtual DbSet<Adres> Adreses { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_In_School> Students_In_School { get; set; }
        public virtual DbSet<Student_In_House> Students_In_House { get; set; }
    }
}
