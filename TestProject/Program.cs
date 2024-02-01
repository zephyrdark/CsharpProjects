// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello C#!");

// // // example of calling different methods in the .NET Class library
// // Random dice = new Random();
// // int roll = dice.Next(1,7);
// // Console.WriteLine(roll);

// // int roll1 = dice.Next();
// // int roll2 = dice.Next(101);
// // int roll3 = dice.Next(50, 101);

// // Console.WriteLine($"First roll: {roll1}");
// // Console.WriteLine($"Second roll: {roll2}");
// // Console.WriteLine($"Third roll: {roll3}");

// // dice.Next()


// //Exercise - Code blocks and variable scope

// // string name = "steve";

// // if (name == "bob")
// //     Console.WriteLine("Found Bob");
// // else if (name == "steve") 
// //     Console.WriteLine("Found Steve");
// // else
// //     Console.WriteLine("Found Chuck");


// // Exercise - Implement a switch statement

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title= "Junior Associate";
//         break;
//     case 200:
//         title= "Senior Associate";
//         break;
//     case 300:
//         title= "Manager";
//         break;
//     case 400:
//         title= "Senior Manager";
//         break;
//     default:
//         title= "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");


// Exercise - Complete a challenge activity using switch statements
// Code challenge: rewrite if-elseif-else using a switch statement


// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch(product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch(product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch(product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }
// Console.WriteLine($"Product: {size} {color} {type}");


// // Exercise - Create and configure for iteration loops
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// // Exercise - Complete a challenge activity using for and if statements

// for (int i = 1; i <= 100; i++)
// {
//     if (i%3==0 && i%5==0) Console.WriteLine($"{i} - FizzBuzz");
//     else if (i%3==0) Console.WriteLine($"{i} - Fizz");
//     else if (i%5==0) Console.WriteLine($"{i} - Buzz");
//     else Console.WriteLine($"{i}");
// }

// Exercise - Create do and while iteration loops

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// /*
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");
// */


// //Code challenge - write code to implement the game rules

// int heroHealth = 10;
// int monsterHealth = 10;
// Random random = new Random();
// int attack = 0;

// do
// {
//     if (heroHealth > 0)
//     {
//         attack = random.Next(1,10);
//         monsterHealth -= attack;
//         Console.WriteLine($"Hero hits Monster for {attack} damage! Monster's remaining health: {monsterHealth}");
//     }

//     if (monsterHealth > 0)
//     {
//         attack = random.Next(1,10);
//         heroHealth -= attack;
//         Console.WriteLine($"Monster hits Hero for {attack} damage! Hero's remaining health: {heroHealth}");
//     }
// } while (heroHealth > 0 && monsterHealth > 0);

// if (heroHealth <= 0) Console.WriteLine("Hero has been slained!");
// if (monsterHealth <= 0) Console.WriteLine("Monster has been slained!");


// // Exercise - Complete a challenge activity to differentiate between do and while iteration statements

// int i = 0;
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);
// Console.WriteLine("Your input is valid and accepted.");

// capture user input in a string variable named readResult

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);


// https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
// // Code project 1 - write code that validates integer input

// string? readResult;
// bool validEntry = false;
//     Console.WriteLine("Type an integer value between 5 and 10. Press Enter to confirm.");
// do
// {
//     readResult = Console.ReadLine();
//     if (int.TryParse(readResult, out int intValue))
//     {
//         if (intValue >=5 && intValue <= 10)
//         {
//             Console.WriteLine($"Your input of \"{intValue}\" is an integer between 5 and 10. Your input is valid! The program will now close.");
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine($"Your input of \"{intValue}\" is not an integer between 5 and 10. Your input is invalid! Please try again.");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Your input of \"{readResult}\" was not an integer between 5 and 10. Your input is invalid! Please try again.");
//     }
// } while (validEntry == false);

// // Code Project 2

// Console.WriteLine("Please enter one of three role names: Administrator, Manager, or User.");
// string? userInput;
// bool validEntry = false;
// do
// {
//     userInput = Console.ReadLine();
//     if (userInput == null)
//     {
//         Console.WriteLine($"Your input of \"{userInput}\" is none of three role names: Administrator, Manager, or User. Your input is invalid! Please try again.");
//     }
//     else
//     {
//         userInput = userInput.Trim().ToLower();
//         switch(userInput)
//         {
//             case "administrator":
//                 Console.WriteLine($"Your input value ({userInput}) has been accepted.");
//                 validEntry = true;
//                 break;
//             case "manager":
//                 Console.WriteLine($"Your input value ({userInput}) has been accepted.");
//                 validEntry = true;
//                 break;
//             case "user":
//                 Console.WriteLine($"Your input value ({userInput}) has been accepted.");
//                 validEntry = true;
//                 break;
//             default:
//                 Console.WriteLine($"Your input of \"{userInput}\" is none of three role names: Administrator, Manager, or User. Your input is invalid! Please try again.");
//                 break;
//         }
//     }
// } while (validEntry == false);

// // Code Project 3

// string[] myStrings = new string[2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int startLocation = 0;
// int periodLocation;
// string outputString;

// foreach (string myString in myStrings)
// {
//     outputString = myString;
//     do
//     {
//         periodLocation = outputString.IndexOf(".");
//         if (periodLocation >= 0)
//         {
//             Console.WriteLine($"{outputString.Substring(startLocation,periodLocation)}");
//         }
//         else
//         {
//             Console.WriteLine($"{outputString}");
//             break;
//         }
//         outputString = outputString.Remove(0,periodLocation+1);
//         outputString = outputString.TrimStart(' ');
//     } while (periodLocation >= 0);
// }