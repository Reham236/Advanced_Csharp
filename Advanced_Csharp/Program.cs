using System.Xml.Linq;

namespace Advanced_Csharp
{
    ////Polymorphism
    //    class Employee
    //    {
    //        public string FName = "FN";
    //        public string LName = "LN";
    //        public virtual void PrintName()
    //        {
    //            Console.WriteLine(FName+ " "+LName);
    //        }

    //    }
    //    class PartTime:Employee
    //    {
    //        public override void PrintName()
    //        {
    //                Console.WriteLine(FName + " " + LName + " Part Time");
    //        }
    //    }
    //    class FullTime : Employee
    //    {
    //        public override void PrintName()
    //        {
    //            Console.WriteLine(FName + " " + LName+ " Full Time");
    //        }

    //    }


    /// <summary>
    //Encapsulation(SET && GET Methods)
    /// </summary>
    //class Student
    //{
    //        //public string Name=null;
    //        //public int ID=-101;
    //        //public int passMark = 35;
    //        public string Name ;
    //        public int ID ;
    //        public int passMark = 35;
    //        public void SetID(int id)
    //        {
    //            if (ID < 0)
    //            {
    //                throw new Exception("invalid ID");
    //            }
    //            this.ID=id;
    //        }
    //        public int GetID()
    //        {
    //            return this.ID;
    //        }
    //        public void setName(string name)
    //        {
    //            if(string.IsNullOrEmpty(name))
    //            {
    //               name = "No Name Founded";
    //                this.Name = name;
    //            }
    //            this.Name=name;
    //        }
    //        public string GetName()
    //        {
    //            return this.Name;
    //        }
    //    }
    ////
      //Encapsulation (Properties)


    class Student
    {
        private int id ;
        private string name ;
        private int PassMak=35;
       
        public int Id
        {
            set
            {
                if(value<=0) {
                    throw new Exception("Invalid ID");
                }
                this.id = value;

            }
            get
            {
                return this.id;

            }
        }
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    value= "No Name Founded";
                    this.name = value;
                }
                this.name= value;
            }
            get
            {
                return this.name;
            }
        }
        
        public int GetPassMark
        {
            get
            {
                return this.PassMak;
            }
        }

        public string Email { get ; set ; }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism
            //Employee[] employees = new Employee [3];
            //employees[0] = new Employee();
            //employees[1]=new PartTime();
            //employees[2]=new FullTime();
            //foreach(Employee e in employees)
            //{
            //    e.PrintName();
            //}
             

            //Encapsulation(SET && GET Methods)
            //Student student = new Student();
            //student.SetID(101);
            //student.setName("");
            
            //Console.WriteLine("Name= {0} & ID= {1} & PassMark= {2} "
            //    , student.GetName(), student.GetID(), student.passMark);

            //Encapsulation (Properties)
            Student s = new Student();
            s.Id = 1;
            s.Name = null;
            Console.WriteLine("ID= {0} & Name= {1} & PassMark= {2}",s.Id,s.Name ,s.GetPassMark);


        }
    }
}
