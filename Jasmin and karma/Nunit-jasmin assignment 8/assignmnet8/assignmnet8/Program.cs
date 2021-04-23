using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment8
{
    public static class Program
    {
        static void Main(string[] args)
        {
           
        }

        /// <summary>
        /// department list
        /// </summary>
       static List<department> l1 = new List<department>
            {
                new department() { depat_Id = 1, depat_name = "IT", dept_Location = "ahmadabad"},
                new department() { depat_Id = 2, depat_name = "EC", dept_Location = "Surat" },
                new department() { depat_Id = 3, depat_name = "CE", dept_Location = "vadodara"}
            };

        /// <summary>
        /// employee list
        /// </summary>
          static List<employee> e1 = new List<employee>()

                {
                new employee() { Id = 1, name = "sweta", age = 20},
                new employee() { Id = 2, name = "hiral", age = 21},
                new employee() { Id = 3, name = "grishma", age = 25}

           };


        /// <summary>
        /// 1. GetEmployee
        /// </summary>
        /// <returns></returns>


        public static List<employee> Getemployee()
        {
            return e1;
        }
       

        /// <summary>
        ///2. GetLocation
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetLocation(int id)
        {
            string name=string.Empty;
           foreach(employee e3 in e1)
            {
                foreach(department d2 in l1)
                {
                    if(e3.Id==id)
                    {
                        name = d2.dept_Location;
                      
                    }
                }

            }
            return name;
        }


        /// <summary>
        ///3. GetEmployee by department
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        

        public static List<employee> GetemployeeBydepartment(int age)
        {
            List<employee> e2 = e1.Where(x => x.age == age).ToList();
            return e2;

        }


        /// <summary>
        ///4. Getemployee Name
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        

        public static string GetemployeeName(int id)
        {
           employee e2 = e1.Where(x => x.Id == id).FirstOrDefault();
            return e2.name;
        }


        /// <summary>
        ///5. TotalEmployee
        /// </summary>
        /// <returns></returns>
        public static int Totalemployee()
        {
            int count;
            count = Getemployee().Count();
            return count;
        }


        /// <summary>
        /// 6.get department
        /// </summary>
        /// <returns></returns>

        public static List<department> Getdepartment()
        {
            List<department> d1 = new List<department>();
            string name=string.Empty;
            foreach (var s in e1)
            {
                foreach (var e in l1)
                {
                    if (e.depat_Id == s.Id)
                    {
                        name = e.depat_name;
                        d1.Add(e);
                        
                    }
                }

            }
            return d1;
        }
        }
}


/// <summary>
/// Department class
/// </summary>
public class department
{
    public int depat_Id { get; set; }
    public string depat_name { get; set; }
    public string dept_Location { get; set; }


}


/// <summary>
/// Employee class
/// </summary>
public class employee
{
    public string name { get; set; }
    public int age { get; set; }
    public int Id { get; set; }


    
}

