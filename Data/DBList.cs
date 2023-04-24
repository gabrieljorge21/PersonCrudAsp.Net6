using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PersonCrud.Models;

namespace PersonCrud.Data
{
    public class DBList
    {
        //singleton design creational pattern
        private static List<Person> _peopleList = new List<Person>();

        private DBList() { }

        public static List<Person> Instance()
        {
            return _peopleList;
        }
        public static void Add(Person p)
        {
            _peopleList.Add(p);
        }

        public static void Delete(int id)
        {
            foreach(var person in _peopleList)
            {
                if (person.Id == id)
                {
                    _peopleList.Remove(person);
                }
                else
                {
                    throw new Exception("Person isn't in the DB.");
                }
            }
        }
    }
}
