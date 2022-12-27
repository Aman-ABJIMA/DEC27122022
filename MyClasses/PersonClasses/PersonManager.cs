using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;
            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }
                ret.FirstName = first;
                ret.LastName = last;
            }
            return ret;
        }

        public List<Person>GetPeople() 
        {
        List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "AMAN", LastName = "SINGH" });
            people.Add(new Person() { FirstName = "KULDEEP", LastName = "SINGH" });
            people.Add(new Person() { FirstName = "ISANSHI", LastName = "AGRAWAL" });
            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();
            people.Add(CreatePerson("AMAN","SINGH",true));
            people.Add(CreatePerson("KULDEEP","SINGH",true));
            
            return people;
        }



        public List<Person> GetEmployees()
        {
            List<Person> people = new List<Person>();
            people.Add(CreatePerson("AMAN", "SINGH", false));
            people.Add(CreatePerson("KULDEEP", "SINGH", false));
            people.Add(CreatePerson("Ishanshi", "Agrawal", false));

            return people;
        }


        public List<Person> GetBoth()
        {
            List<Person> people = new List<Person>();
            people.AddRange(GetEmployees());

            people.AddRange(GetSupervisors());

            return people;
        }
    }
}
