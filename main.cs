using System;

class Program {
  public static void Main (string[] args) 
  {
    //hardcoded personal information variables
    var dateOfBirth = "8/15/1978"; 
    var workID = "work 000-111-0101"; 
    var cellPhoneNumbers = "cell 000-111-0189";

    //Print the information to console
    Console.WriteLine(ConcatName("John", "Smith"));
    Console.WriteLine(dateOfBirth); 
    Console.WriteLine(workID); 
    Console.WriteLine(cellPhoneNumbers); 
  }

    //Concatenates first name and last name into a string
  private static string ConcatName(string firstName, string lastName) {  
      return firstName + " " + lastName;
  }

  }