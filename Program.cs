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
        Name = "Ripsteakface",
        Age = 666
    },
    new Person() {
        Name = "Joe Don",
        Age = 66
    },
    new Person() {
        Name = "Mitchell",
        Age = 56
    },
    new Person() {
        Name = "Liz Lemon",
        Age = 41
    },
    new Person() {
        Name = "Tracy Jordan",
        Age = 45
    },
    new Person() {
        Name = "Jack Donaghy",
        Age = 50
    },
    new Person() {
        Name = "Jenna Maroney",
        Age = 25
    },
    new Person() {
        Name = "Kenneth Parcel",
        Age = 120
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
