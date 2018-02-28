

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Join {
    class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Pet
{
    public string Name { get; set; }
    public Person Owner { get; set; }
}

/// <summary>
/// Simple inner join.
/// </summary>
public static void InnerJoinExample()
{
    Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
    Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
    Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
    Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
    Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };
    Person ru = new Person { FirstName = "Ru", LastName = "Rapoo" };

    Pet barley = new Pet { Name = "Barley", Owner = terry };
    Pet boots = new Pet { Name = "Boots", Owner = terry };
    Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
    Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
    Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

    // Create two lists.
    List<Person> people = new List<Person> { magnus, terry, charlotte, arlene, rui, ru };
    List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

    // Create a collection of person-pet pairs. Each element in the collection
    // is an anonymous type containing both the person's name and their pet's name.
    var query = from person in people
                join pet in pets on person equals pet.Owner
                select new { OwnerName = person.FirstName, PetName = pet.Name };

    foreach (var ownerAndPet in query)
    {
        Console.WriteLine($"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}");
    }
}
// public static void LeftOuterJoinExample(){
//      Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
//     Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
//     Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
//     Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };

//     Pet barley = new Pet { Name = "Barley", Owner = terry };
//     Pet boots = new Pet { Name = "Boots", Owner = terry };
//     Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
//     Pet bluemoon = new Pet { Name = "Blue Moon", Owner = terry };
//     Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

//     // Create two lists.
//     List<Person> people = new List<Person> { magnus, terry, charlotte, arlene };
//     List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };
//     var query = from person in people
//                 join pet in pets on  
// }
}

