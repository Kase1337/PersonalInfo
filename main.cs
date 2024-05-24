using System;

class Program {
  public static void Main (string[] args) 
  {
    //hardcoded personal information variables
    var dateOfBirth = "2/27/1949"; 
    var workID = "work 000-444-0101"; 
    var cellPhoneNumbers = "cell 000-444-0189";

    //Print the information to console
    Console.WriteLine(ConcatName("Robert", "Hall"));
    Console.WriteLine(dateOfBirth); 
    Console.WriteLine(workID); 
    Console.WriteLine(cellPhoneNumbers); 
  }

    //Concatenates first name and last name into a string
  private static string ConcatName(string firstName, string lastName) {  
      return firstName + " " + lastName;
  }

  }