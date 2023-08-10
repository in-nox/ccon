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
