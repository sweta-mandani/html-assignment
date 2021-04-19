
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;
namespace Prime.Services
{
    public class PrimeService
    {
        /// <summary>
        /// Login using if else
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public string Login(string UserId, string Password)
            {
                if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
                {
                    return "Userid or password could not be Empty.";
                }
                else
                {
                    if (UserId == "Admin" && Password == "Admin")
                    {
                        return "Welcome Admin.";
                    }
                    return "Incorrect UserId or Password.";
                }
            }
        /// <summary>
        /// ADD details in list
        /// </summary>
        /// <returns></returns>
            public List<EmployeeDetails> AllUsers()
            {
                List<EmployeeDetails> li = new List<EmployeeDetails>();
                li.Add(new EmployeeDetails
                {
                    id = 100,
                    Name = "Bharat",
                    Geneder = "male",
                    salary = 40000
                });
                li.Add(new EmployeeDetails
                {
                    id = 101,
                    Name = "sunita",
                    Geneder = "Female",
                    salary = 50000
                });
                li.Add(new EmployeeDetails
                {
                    id = 103,
                    Name = "Karan",
                    Geneder = "male",
                    salary = 40000
                });
                li.Add(new EmployeeDetails
                {
                    id = 104,
                    Name = "Jeetu",
                    Geneder = "male",
                    salary = 23000
                });
                li.Add(new EmployeeDetails
                {
                    id = 105,
                    Name = "Manasi",
                    Geneder = "Female",
                    salary = 80000
                });
                li.Add(new EmployeeDetails
                {
                    id = 106,
                    Name = "Ranjit",
                    Geneder = "male",
                    salary = 670000
                });
                return li;
            }

        /// <summary>
        /// getdetails using foreach
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EmployeeDetails> getDetails(int id)
        {
            List<EmployeeDetails> li1 = new List<EmployeeDetails>();
            PrimeService p = new PrimeService();
            var li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }


        /// <summary>
        /// salary using for loop
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EmployeeDetails> getsalary(int id)
        {
            List<EmployeeDetails> li2 = new List<EmployeeDetails>();
            PrimeService p = new PrimeService();
            var li = p.AllUsers();
            for(int i=0;i<li.Count;i++)
            {
                if(li[i].id==id)
                
                    if (li[i].salary > 25000)
                    {
                        double l = li[i].salary;
                        li2.Add(li[i]);
                    }
                    else
                    {
                        Console.WriteLine("not grater");
                    }
                
            }
            return li2;
        }
    }
    }

public class EmployeeDetails
{
    public int id
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }
    public double salary
    {
        get;
        set;
    }
    public string Geneder
    {
        get;
        set;
    }
}
