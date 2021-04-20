
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
                salary = 4000
            });
            li.Add(new EmployeeDetails
            {
                id = 101,
                Name = "sunita",
                Geneder = "Female",
                salary = 5000
            });
            li.Add(new EmployeeDetails
            {
                id = 103,
                Name = "Karan",
                Geneder = "male",
                salary = 4000
            });
            li.Add(new EmployeeDetails
            {
                id = 104,
                Name = "Jeetu",
                Geneder = "male",
                salary = 2000
            });
            li.Add(new EmployeeDetails
            {
                id = 105,
                Name = "Manasi",
                Geneder = "Female",
                salary = 2000
            });
            li.Add(new EmployeeDetails
            {
                id = 106,
                Name = "Ranjit",
                Geneder = "male",
                salary = 6000
            });
            return li;
        }

        /// <summary>
        /// getdetails using for Loop
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EmployeeDetails> getDetails(int id)
        {
            List<EmployeeDetails> li1 = new List<EmployeeDetails>();
            PrimeService p = new PrimeService();
            var li = p.AllUsers();
            for (int i = 0; i < li.Count; i++)
            {


                if (li[i].id == id)
                {
                    li1.Add(li[i]);
                }
            }
            return li1;
        }


        /// <summary>
        /// salary using for foreach
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EmployeeDetails> getsalary(int id)
        {
            List<EmployeeDetails> li2 = new List<EmployeeDetails>();
            PrimeService p = new PrimeService();
            var li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.id == id)
                {
                    if (x.salary > 5000)
                    {

                        li2.Add(x);
                    }
                    else
                    {
                        Console.WriteLine("not grater");
                    }
                }

            }
            return li2;
        }


        /// <summary>
        /// totalsalary using while loop
        /// </summary>
        /// <returns></returns>

        public double totalsalary()
        {

            PrimeService p = new PrimeService();
            double sum = 0;
            int i = 0;
            var li = p.AllUsers();
            while (i < li.Count)
            {
                sum = sum + li[i].salary;
                i++;
            }
            Console.WriteLine(sum);
            return sum;
        }

        /// <summary>
        /// getgender using switch 
        /// </summary>
        /// <param name="gender"></param>

        public void getgender(string gender)
        {

            PrimeService p = new PrimeService();
            var li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.Geneder == gender)
                {
                    string ch = x.Geneder.Substring(0, 1);
                    char[] ch1 = ch.ToCharArray();
                    char ch2 = ch1[0];
                    switch (ch2)
                    {
                        case 'm':
                            Console.WriteLine("Male");
                            break;

                        case 'F':
                            Console.WriteLine("Female");
                            break;
                    }

                }

            }

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
