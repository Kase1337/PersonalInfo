using System;

class Program {
  public static void Main (string[] args) 
  {
    //hardcoded personal information variables
    var dateOfBirth = "6/24/1992"; 
    var workID = "000-000-0101"; 
    var cellPhoneNumbers = "000-000-0189";

    //Print the information to console
    Console.WriteLine(ConcatName("Lucinda", "Potter"));
    Console.WriteLine(dateOfBirth); 
    Console.WriteLine(workID); 
    Console.WriteLine(cellPhoneNumbers); 
  }

    //Concatenates first name and last name into a string
  private static string ConcatName(string firstName, string lastName) {  
      return firstName + " " + lastName;
  }

  }