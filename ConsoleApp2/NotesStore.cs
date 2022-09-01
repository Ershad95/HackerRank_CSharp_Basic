using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Item
    {
        public string Key { get; set; }
        public string value { get; set; }
    }
    public class NotesStore
    {
        List<string> states = new List<string>() { "active", "others", "completed" };
        List<Item> _notes = new List<Item>();
        public NotesStore() { }
        public void AddNote(String state, String name) {
            if(string.IsNullOrEmpty(name))
                throw new Exception("Name cannot be empty");
            if (!states.Contains(state))
                throw new ArgumentException($"Invalid state {state}");
            _notes.Add(new Item() { Key = state,value = name });

        }
        public List<String> GetNotes(String state) {
            if (!states.Contains(state))
                throw new ArgumentException($"Invalid state {state}");
            if (!_notes.Any(x => x.Key == state))
                return new List<string>();
            return _notes.Where(x => x.Key == state).Select(x=>x.value).ToList();
        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Company { get; set; }
        }
    }

}
