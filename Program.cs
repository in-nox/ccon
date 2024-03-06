// See https://aka.ms/new-console-template for more information
using ccon;
using System.Collections.Generic;
using System.Linq;


var peeps = new List<Person>() {
    new Person() {
        Name = "Ryan",
        Age = 39
    },
    new Person() {
        Name = "Ted",
        Age = 39,
    },
    new Person() {
        Name = "Big McLargeHuge",
        Age = 42
    },
    new Person() {
        Name = "Mitchell",
        Age = 58
    },
    new Person() {
        Name = "Joe Don Baker",
        Age = 58
    }
};

var ryan = peeps.FirstOrDefault(p => p.Name == "Ryan");

if(ryan == null)
    Console.WriteLine("No ryans");


ryan.Name = "Ted";

foreach(var p in peeps) {
    Console.WriteLine(p.Name);
}
Console.WriteLine("Hello, World!");
