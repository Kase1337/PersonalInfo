using System;

class Program {
  public static void Main (string[] args) 
  {
    //hardcoded personal information variables
    var dateOfBirth = "12/01/1987"; 
    var workID = "work 000-222-0101"; 
    var cellPhoneNumbers = "cell 000-222-0189";

    //Print the information to console
    Console.WriteLine(ConcatName("Chris", "Johnson"));
    Console.WriteLine(dateOfBirth); 
    Console.WriteLine(workID); 
    Console.WriteLine(cellPhoneNumbers); 
  }

    //Concatenates first name and last name into a string
  private static string ConcatName(string firstName, string lastName) {  
      return firstName + " " + lastName;
  }

  }