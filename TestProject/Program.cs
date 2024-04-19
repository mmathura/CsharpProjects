// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello C#!");

// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);
// int result = Random.Next(); // error

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else 
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Your code goes here

// Console.WriteLine(daysUntilExpiration); // debugging
/*
if (daysUntilExpiration == 0) 
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1) 
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5) 
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10) 
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
*/
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

fraudulentOrderIDs[3] = "D000"; // boundry error
*/
/*
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/
/*
int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;


foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/
/*
string[] names = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string name in names) 
{
    if (name.StartsWith("B"))
    {
        Console.WriteLine(name);
    }
}
*/
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/
// Example 1: 
/*
Console
.
WriteLine
(
"Hello Example 1!"
)
;
*/
// Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
*/

// if (myName == "Luiz")

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
// These two lines of code will create the same output
// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// // Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
// Random rand = new Random();
// int toss = rand.Next(0,2);
// string coin = toss == 0 ? "heads" : "tails";
// // Console.WriteLine(toss); // debugging
// Console.WriteLine($"{coin}");

// string permission = "Admin|Manager";
// // string permission = "User";

// // int level = 55;
// int level = 56;
// // int level = 19;
// // int level = 20;

// if (permission.Contains("Admin") && level > 55) {
//     Console.WriteLine("Welcome, Super Admin user.");
// }

// if (permission.Contains("Admin") && level <= 55) {
//     Console.WriteLine("Welcome, Admin user.");
// }

// if (permission.Contains("Manager") && level >= 20) {
//     Console.WriteLine("Contact an Admin for access.");
// }

// if (permission.Contains("Manager") && level < 20) {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// if (!(permission.Contains("Manager") || permission.Contains("Admin"))) {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// bool flag = true;
// // int value = 10;
// int value = 0;
// // int value;

// if (flag)
// {
//     // int value = 10;
//     value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }
// Console.WriteLine($"Outside of code block: {value}");
// // error CS0103: The name 'value' does not exist in the current context
// // error CS0165: Use of unassigned local variable 'value'

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// bool found = false;
// int total = 0;

// foreach (int number in numbers)
// {
//     // int total; 
//     total += number;

//     if (number == 42)
//     {
//        // bool found = true;       
//        found = true;
//     }
// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

// int employeeLevel = 200;
// // int employeeLevel = 201;

// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         // title = "Junior Associate";
//         // break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0]) 
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

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }
// Cannot assign to 'name' because it is a 'foreach iteration variable'

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David") names[i] = "Sammy";
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

// FizzBuzz 

// for (int i = 1; i < 101; i++) {
//     Console.Write(i);
//     if (i % 3 == 0 && i % 5 == 0)   
//         Console.Write(" - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.Write(" - Fizz");
//     else if (i % 5 == 0)   
//         Console.Write(" - Buzz");
//     Console.Write("\n");
// }

/*
1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
23
24 - Fizz
25 - Buzz
26
27 - Fizz
28
29
30 - FizzBuzz
31
32
33 - Fizz
34
35 - Buzz
36 - Fizz
37
38
39 - Fizz
40 - Buzz
41
42 - Fizz
43
44
45 - FizzBuzz
46
47
48 - Fizz
49
50 - Buzz
51 - Fizz
52
53
54 - Fizz
55 - Buzz
56
57 - Fizz
58
59
60 - FizzBuzz
61
62
63 - Fizz
64
65 - Buzz
66 - Fizz
67
68
69 - Fizz
70 - Buzz
71
72 - Fizz
73
74
75 - FizzBuzz
76
77
78 - Fizz
79
80 - Buzz
81 - Fizz
82
83
84 - Fizz
85 - Buzz
86
87 - Fizz
88
89
90 - FizzBuzz
91
92
93 - Fizz
94
95 - Buzz
96 - Fizz
97
98
99 - Fizz
100 - Buzz
*/

// do-while 

// do
// {
//     // This code executes at least one time
// } while (true);

/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// Random random = new Random();
// int current = random.Next(1, 11);

// /*
// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);
// */

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

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

// You must use either the do-while statement or the while statement as an outer game loop.
// The hero and the monster will start with 10 health points.
// All attacks will be a value between 1 and 10.
// The hero will attack first.
// Print the amount of health the monster lost and their remaining health.
// If the monster's health is greater than 0, it can attack the hero.
// Print the amount of health the hero lost and their remaining health.
// Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
// Print the winner.

// int hero_health = 10;
// int monster_health = 10;
// int attack = 0;

// Random random = new Random();
// // Console.WriteLine("Monster " + monster_health + " " + attack);
// // Console.WriteLine("Hero " + hero_health + " " + attack);

// do {
//     attack = random.Next(1, 11);
//     monster_health -= attack; // hero first
//     // Console.WriteLine("Monster " + monster_health + " " + attack);
//     Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster_health} health.");
//     attack = 0;
//     if (monster_health > 0) {
//         attack = random.Next(1, 11);
//         hero_health -= attack;
//         // Console.WriteLine("Hero " + hero_health + " " + attack);
//         Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero_health} health.");
//         attack = 0;
//     }
// } while (monster_health > 0 && hero_health > 0);
// if (monster_health <= 0) 
//     Console.WriteLine("Hero Wins!");
// else 
//     Console.WriteLine("Monster Wins!");
/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/

// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);
/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

*/



// string? readResult;
// Console.WriteLine("Enter a number? ");
// readResult = Console.ReadLine();

// // capture user input in a string variable named readResult

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);

// Console.WriteLine(validNumber);
// Console.WriteLine(numericValue);


// capture user input in a string variable named readResult
/*
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
*/

// 1
/* 
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/

// 2
/*
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/

// 3
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Unsigned integral types:
// byte   : 0 to 255
// ushort : 0 to 65535
// uint   : 0 to 4294967295
// ulong  : 0 to 18446744073709551615

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Signed integral types:
// sbyte  : -128 to 127
// short  : -32768 to 32767
// int    : -2147483648 to 2147483647
// long   : -9223372036854775808 to 9223372036854775807

// Floating point types:
// float  : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
// double : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
// decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

// int[] data;
// data = new int[3];

// int[] data = new int[3];
// string shortenedString = "Hello World!";
// Console.WriteLine(shortenedString);

// int for most whole numbers
// decimal for numbers representing money
// bool for true or false values
// string for alphanumeric value

// byte: working with encoded data that comes from other computer systems or using different character sets.
// double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
// System.DateTime for a specific date and time value.
// System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.

// int first = 2;
// string second = "4";
// int result = first + second;
// // error CS0029: Cannot implicitly convert type 'string' to 'int'
// Console.WriteLine(result);

// int first = 2;
// string second = "4";
// string result = first + second; // 24
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// int: 3
// decimal: 3 // decimal myDecimal = myInt;

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal: 3.14
// int: 3  // int myInt = (int)myDecimal;

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// Decimal: 1.23456789
// Float  : 1.2345679

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message); // 57

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second); // TryParse()
// Console.WriteLine(sum); // 12

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result); // 35

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// 1
// 2

// string name = "Bob";
// Console.WriteLine(int.Parse(name));
// The input string 'Bob' was not in a correct format.

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// Measurement: 102
// if (int.TryParse(value, out result))

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Measurement: 102
// Measurement (w/ offset): 152

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Unable to report the measurement.

/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// Message: ABCDEF
// Total: 68.3
int result = 0;
float result2 = 0;
float total = 0;
string message = "";

for (int i = 0; i < values.Length; i++)
{
    if (int.TryParse(values[i], out result) || float.TryParse(values[i], out result2))
    {
        // Console.WriteLine(">" + values[i]);
        total += result + result2;
        result = 0; 
        result2 = 0;
    }
    else
    {
        // Console.WriteLine(values[i]);
        message += values[i];
    }

}
Console.WriteLine("Message: " + message);
Console.WriteLine("Total: " + total);
*/

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");
/*
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1;
decimal result2;
float result3;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
result1 = value1 / (int)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
result3 = (float)value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

// Divide value1 by value2, display the result as an int: 2
// Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
// Divide value3 by value1, display the result as a float: 0.35833335

// Solve for result1: Divide value1 by value2, display the result as an int
// Solve for result2: Divide value2 by value3, display the result as a decimal
// Solve for result3: Divide value3 by value1, display the result as a float

// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// // Convert.ToInt32() rounds up the way you would expect.
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Sorted...
// -- A11
// -- A13
// -- B12
// -- B14

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Sorted...
// -- A11
// -- A13
// -- B12
// -- B14

// Reversed...
// -- B14
// -- B12
// -- A13
// -- A11

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/*
Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13
*/

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Before: B14
// After: 
// Clearing 2 ... count: 4
// -- 
// -- 
// -- B12
// -- A13

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");
// if (pallets[0] != null)
//     Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Object reference not set to an instance of an object 

// Before: b14
// Clearing 2 ... count: 4
// -- 
// -- 
// -- B12
// -- A13

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Clearing 2 ... count: 4
// -- 
// -- 
// -- B12
// -- A13

// Resizing 6 ... count: 6
// -- 
// -- 
// -- B12
// -- A13
// -- C01
// -- C02

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/* 

Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13

Resizing 6 ... count: 6
-- 
-- 
-- B12
-- A13
-- C01
-- C02

Resizing 3 ... count: 3
-- 
-- 
-- B12

*/

// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);

// 321cba

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// 3,2,1,c,b,a

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

/*
3,2,1,c,b,a
3
2
1
c
b
a
*/

// string pangram = "The quick brown fox jumps over the lazy dog";
// // ehT kciuq nworb xof spmuj revo eht yzal god

// // split into words 
// string[] items = pangram.Split(' ');
// string temp = ""; 

// foreach (string item in items)
// {
//     char[] value = item.ToCharArray();
//         // Console.WriteLine(item);
//         Array.Reverse(value);
//         // Console.WriteLine(value);
//         temp += new string(value);
//         temp += " "; // append space
// }

// // reverse each word
// Console.WriteLine(temp); // ehT kciuq nworb xof spmuj revo eht yzal god 

/*
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);

*/

// ehT kciuq nworb xof spmuj revo eht yzal god

/* 

A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error

*/

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// // 4 chars
// string [] orders = orderStream.Split(","); 
// foreach (var order in orders) {
//     Console.Write(order);
//     if (order.Length != 4) {
//         Console.Write( " \t - Error");
//     } 
//     Console.Write("\n");
// }

// B123
// C234
// A345
// C15      - Error
// B177
// G3003    - Error
// C235
// B179

/* 

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}

A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error

*/

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result); // Hello World!

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);   // Hello World!
// Console.WriteLine("{0} {0} {0}!", first, second); // Hello Hello Hello!
// needs correct arg for "second"

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// Hello World!
// World Hello!
// Hello Hello Hello!

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");  // Price: $123.45 (Save $50.00)

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Measurement: 123,456.79 units

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");
// Measurement: 123,456.7891 units

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}"); // Tax rate: 36.79 %

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// Console.WriteLine(yourDiscount); // You saved $7.56 off the regular $67.55 price. 

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount); // You saved $7.56 off the regular $67.55 price. A discount of 11.19%!

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}"); // Invoice Number: 1201
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

/*
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
     Total Billed: $3,185.19
*/

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12));

/*

    Pad this
Pad this    

*/

// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

/* 

----Pad this
Pad this----

*/

// string paymentId = "769C";

//  var formattedLine = paymentId.PadRight(6);

//  Console.WriteLine(formattedLine); // 769C  

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);

// //  formattedLine = formattedLine + payeeName.PadRight(24);

// Console.WriteLine(formattedLine); // 769C  Mr. Stephen Ortega      

// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);
//  formattedLine += paymentAmount.PadLeft(10);

//  Console.WriteLine(formattedLine);

// Console.WriteLine("1234567890123456789012345678901234567890");
// 1234567890123456789012345678901234567890

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// 1234567890123456789012345678901234567890
// 769C  Mr. Stephen Ortega       $5,000.00

/*

Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00

*/
/*
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

string comparisonMessage = $"{currentProduct.PadRight(19)} {currentReturn:P2}" + "   " + $"{currentProfit:C2}\n{newProduct.PadRight(20)}{newReturn:P2}" + "   " + $"{newProfit:C2}";

string message = $"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.\n";

// Your logic here

Console.WriteLine(message);

Console.WriteLine("Here's a quick comparison:\n");

Console.WriteLine(comparisonMessage);
*/

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// 13
// 36

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// (inside the parentheses

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// inside the parentheses

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// between the tags

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// between the tags

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// set of parentheses

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// What if
// more than
// set of parentheses

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

// Searching THIS message: Help (find) the {opening symbols}
// Found WITHOUT using startPosition: (find) the {opening symbols}
// Found WITH using startPosition 5:  (find) the {opening symbols}

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// What if
// different symbols
// open symbol
// matching closing symbol

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);
// 123455000  3

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

// This is example data

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here
// string q = input.Replace("&trade", "&reg");
// // Console.WriteLine(q);
// output = "Quantity: " + q.Substring(5,45);
// quantity = "Output: " + input.Substring(35,4);

// Console.WriteLine(quantity);
// Console.WriteLine(output);

// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */ /*
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }

// Console.WriteLine(); */
// DisplayTimes();
// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     // for (int i = 0; i < times.Length; i++) 
//     // {
//     //     times[i] = ((times[i] + diff)) % 2400;
//     // }
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     // for (int i = 0; i < times.Length; i++) 
//     // {
//     //     times[i] = ((times[i] + diff)) % 2400;
//     // }
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes(); 
// /* Format and display medicine times */ /*
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }

// Console.WriteLine(); */

// // void DisplayTimes() 
// // {

// // }

// void DisplayTimes() 
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// }

// // void AdjustTimes() 
// // {

// // }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }
//
/*
Enter current GMT
-6
Current Medicine Schedule:
8:00 12:00 16:00 20:00 
Enter new GMT
+6
New Medicine Schedule:
20:00 0:00 4:00 8:00 
*/

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

// // string ipv4Input = "107.31.1.5";
// string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
// string[] address;

// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// if (ValidateLength() && ValidateZeroes() && ValidateRange()) 
// {
//     Console.WriteLine($"ip is a valid IPv4 address");
// } 
// else 
// {
//     Console.WriteLine($"ip is an invalid IPv4 address");
// }

// ValidateLength();
// ValidateZeroes();
// ValidateRange();

// foreach (string ip in ipv4Input)
// {
//     ValidateLength();
//     ValidateZeroes();
//     ValidateRange();

//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     if (validLength && validZeroes && validRange)
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     }
//     else
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// if (validLength && validZeroes && validRange)
// {
//     Console.WriteLine($"ip is a valid IPv4 address");
// }
// else
// {
//     Console.WriteLine($"ip is an invalid IPv4 address");
// }

// void ValidateLength() {}
// void ValidateZeroes() {}
// void ValidateRange() {}

// void ValidateLength()
// {
//     // string[] address = ipv4Input.Split(".");
//     // string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);
//     validLength = address.Length == 4;
// }

// void ValidateZeroes()
// {
//     // string[] address = ipv4Input.Split(".");

//     // foreach (string number in address) 
//     // {
//     //     if (number.Length > 1 && number.StartsWith("0")) 
//     //     {
//     //         validZeroes = false;
//     //     }
//     // }

//     foreach (string number in address)
//     {
//         if (number.Length > 1 && number.StartsWith("0"))
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange()
// {
//     // string[] address = ipv4Input.Split(".");

//     foreach (string number in address)
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255)
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

/*

string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
};

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
*/

// 107.31.1.5 is a valid IPv4 address
// 255.0.0.255 is a valid IPv4 address
// 555..0.555 is an invalid IPv4 address
// 255...255 is an invalid IPv4 address

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
// string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
// string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
// string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

// Console.WriteLine("A fortune teller whispers the following words:");
// string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
// for (int i = 0; i < 4; i++) 
// {
//     Console.Write($"{text[i]} {fortune[i]} ");
// }

// A fortune teller whispers the following words:
// You have much to look forward to. Today is a day to try new things! Whatever work you do is likely to succeed. This is an ideal time to accomplish your dreams!

// A fortune teller whispers the following words:
// You have much to appreciate. Today is a day to enjoy time with friends. Whatever work you do should align with your values. This is an ideal time to get in tune with nature.

// A fortune teller whispers the following words:
// You have much to fear. Today is a day to avoid major decisions. Whatever work you do may have unexpected outcomes. This is an ideal time to re-evaluate your life.

// tellFortune();
// luck = random.Next(100);
// tellFortune();
// luck = random.Next(100);
// tellFortune();

// void tellFortune()
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
//     Console.WriteLine("\n");
// }

// CountTo(5);

// void CountTo(int max)
// {
//     for (int i = 0; i < max; i++)
//     {
//         Console.Write($"${i}, ");
//     }
// }

// int[] schedule = { 800, 1200, 1600, 2000 };

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {

//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// DisplayAdjustedTimes(schedule, 6, -6);

// 800 -> 2000
// 1200 -> 0
// 1600 -> 400
// 2000 -> 800

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

// // Jenna, Ayesha, Carlos, Viktor, 
// // Robert, Vanya, 

// PrintCircleArea(12);

// void PrintCircleArea(int radius)
// {
//     double pi = 3.14159;
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// Area = 452.38896

// PrintCircleArea(12);
// double circumference = 2 * pi * radius;

// PrintCircleArea(12);

// void PrintCircleArea(int radius)
// {
//     double pi = 3.14159;
//     // double area = pi * (radius * radius);
//     // Console.WriteLine($"Area = {area}");
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// double pi = 3.14159;

// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// // double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// // Circle with radius 12
// // Area = 452.38896
// // Circumference = 75.39815999999999
// // Circle with radius 24
// // Area = 1809.55584
// // Circumference = 150.79631999999998

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// // inside Multiply method: 3 x 4 = 12
// // global statement: 3 x 4 = 0

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

// 1 2 3 4 5 
// 0 0 0 0 0 

// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// // SetHealth(status, false);
// // SetHealth(status, false);
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// // void SetHealth(string status, bool isHealthy) 

// void SetHealth(bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// Start: Healthy
// Middle: Unhealthy
// End: Healthy

// Start: Healthy
// Middle: Unhealthy
// End: Unhealthy

// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);

// // RSVP("Rebecca", 1, "none", true);
// // RSVP("Nadia", 2, "Nuts", true);
// // // RSVP("Linh", 2, "none", false);
// // RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
// // // RSVP("Tony", 1, "Jackfruit", true);
// // RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
// // RSVP("Noor", 4, "none", false);
// // RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// // void RSVP(string name, int partySize, string allergies, bool inviteOnly)
// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         // search guestList before adding rsvp

//         if (inviteOnly)
//         {
//             bool found = false;
//             foreach (string guest in guestList)
//             {
//                 if (guest.Equals(name))
//                 {
//                     found = true;
//                     break;
//                 }
//             }
//             if (!found)
//             {
//                 Console.WriteLine($"Sorry, {name} is not on the guest list");
//                 return;
//             }
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

// Sorry, Tony is not on the guest list

// Total RSVPs:
// Name: Rebecca,  Party Size: 1,  Allergies: none
// Name: Nadia,    Party Size: 2,  Allergies: Nuts
// Name: Linh,     Party Size: 2,  Allergies: none
// Name: Noor,     Party Size: 4,  Allergies: none
// Name: Jonte,    Party Size: 2,  Allergies: Stone fruit

// Sorry, Tony is not on the guest list

// Total RSVPs:
// Name: Rebecca,  Party Size: 1,  Allergies: none
// Name: Nadia,    Party Size: 2,  Allergies: Nuts
// Name: Linh,     Party Size: 2,  Allergies: none
// Name: Noor,     Party Size: 4,  Allergies: none
// Name: Jonte,    Party Size: 2,  Allergies: Stone fruit

// Sorry, Tony is not on the guest list

// Total RSVPs:
// Name: Rebecca,  Party Size: 1,  Allergies: none
// Name: Nadia,    Party Size: 2,  Allergies: Nuts
// Name: Linh,     Party Size: 2,  Allergies: none
// Name: Noor,     Party Size: 4,  Allergies: none
// Name: Jonte,    Party Size: 2,  Allergies: Stone fruit

// using System.ComponentModel.DataAnnotations;

// string[,] corporate =
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// // "contoso.com" - optional

// // usernamme = first 2 chars of first name; full last name 

// string emailAddress(string username, string domain = "contoso.com")
// {
//     return $"{username}@{domain}";
// }

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     // display internal email addresses
//     string first = $"{corporate[i, 0][0]}{corporate[i, 0][1]}".ToLower();
//     string last  = $"{corporate[i, 1]}".ToLower();
//     Console.WriteLine(emailAddress(first + last));
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//     // display external email addresses
//     string first = $"{external[i, 0][0]}{external[i, 0][1]}".ToLower();
//     string last  = $"{external[i, 1]}".ToLower();
//     Console.WriteLine(emailAddress(first + last, externalDomain));
// }

// robavin@contoso.com
// sibright@contoso.com
// kisinclair@contoso.com
// aakamath@contoso.com
// sadelucchi@contoso.com
// siali@contoso.com
// viashton@hayworth.com
// codysart@hayworth.com
// shlawrence@hayworth.com
// davaldes@hayworth.com

// void Update();

// int[] GetEnemyCoordinates(string enemyId);
// int[] GetDistanceFromHero(string enemyId);
// int[] GetHeroCoordinates();

// bool EnemyCanHitHero(string enemyId);
// int GetEnemyDamageOutput(string enemyId);
// void UpdateHeroHP(int damage);

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
// double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// if (TotalMeetsMinimum())
// {
//     total -= 5.00;
// }

// // total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// // Console.WriteLine($"Total: ${total}");
// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// // void GetDiscountedPrice(int itemIndex)
// // {
// //     // Calculate the discounted price of the item
// // }

// double GetDiscountedPrice(int itemIndex)
// {
//     // Calculate the discounted price of the item
//     // double result = items[itemIndex] * (1 - discounts[itemIndex]);
//     // return result;
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// // void TotalMeetsMinimum()
// // {
// //     // Check if the total meets the minimum
// // }

// bool TotalMeetsMinimum()
// {
//     // Check if the total meets the minimum
//     return total >= minimumSpend;
// }

// // void FormatDecimal(double input)
// // {
// //     // Format the double so only 2 decimal places are displayed
// // }

// string FormatDecimal(double input)
// {
//     // Format the double so only 2 decimal places are displayed
//     return input.ToString().Substring(0, 5);
// }

// // Total: $44.58

// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd) 
// {
//     int rate = 23500;
//     // 1 USD = 23500 VND
//     return (int) (rate * usd);
// }

// // $23.73 USD = $557655 VND
// // $557655 VND = $23.73 USD

// double VndToUsd(int vnd) 
// {
//     double rate = 23500;
//     return vnd / rate;
// }

// string input = "snake";

// Console.WriteLine(input);
// Console.WriteLine(ReverseWord(input));

// string ReverseWord(string word) 
// {
//     string result = "";

//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }

//     return result;
// }

// // snake
// // ekans

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach(string word in words) 
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }

// // there are snakes at the zoo
// // ereht era sekans ta eht ooz

// // int target = 60;
// // int target = 30;
// int target = 80; // No two coins make change
// int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
// // int[] result = TwoCoins(coins, target);
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0)
// {
//     Console.WriteLine("No two coins make change");
// }
// else
// {
//     // Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// // int[] TwoCoins(int[] coins, int target)

// int[,] TwoCoins(int[] coins, int target)
// {
//     int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++)
//     {
//         for (int next = curr + 1; next < coins.Length; next++)
//         {
//             if (coins[curr] + coins[next] == target)
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//                 // return new int[] { curr, next };
//             }
//             if (count == result.GetLength(0))
//             {
//                 return result;
//             }

//         }
//     }
//     if (count == 0)
//     {
//         return new int[0, 0];
//     }
//     return result;
//     // return (count == 0) ? new int[0,0] : result;
//     // return new int[0];
// }

// // Change found at positions 2 and 5

// // Change found at positions:
// // 0,3
// // 0,4
// // 1,3
// // 1,4
// // 3,6

// using System.Runtime;
// using Microsoft.VisualBasic;

// Random random = new Random();

// bool ShouldPlay() {
//     string? readResult = Console.ReadLine();
// #pragma warning disable CS8602 // Dereference of a possibly null reference.
//     if (readResult.ToLower() == "y") {
//         return true;
//     }
// #pragma warning restore CS8602 // Dereference of a possibly null reference.
//     return false;
// }

// string WinOrLose(int target, int roll) {
//     if (roll > target) {
//         return "You win!";
//     }
//     return "You loose!";
// }

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) 
//     {
//         var target = random.Next(1, 5);
//         var roll = random.Next(1, 6);

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target, roll));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

/*
- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups 
*/

// using System;

// string[] pettingZoo =
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// void PlanSchoolVisit(string schoolName, int groups = 6)
// {
//     RandomizeAnimals();
//     string[,] group = AssignGroup(groups);
//     // Console.WriteLine("School A");
//     Console.WriteLine(schoolName);
//     PrintGroup(group);
// }

// void RandomizeAnimals()
// {

//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++)
//     {
//         int r = random.Next(pettingZoo.Length);
//         string temp = pettingZoo[i];
//         pettingZoo[i] = pettingZoo[r];
//         pettingZoo[r] = temp;
//     }

// }

// string[,] AssignGroup(int groups = 6)
// {
//     string[,] result = new string[groups, pettingZoo.Length / groups];

//     int start = 0;

//     for (int i = 0; i < groups; i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = pettingZoo[start++];
//         }
//     }

//     return result;
// }

// void PrintGroup(string[,] group)
// {
//     for (int i = 0; i < group.GetLength(0); i++)
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < group.GetLength(1); j++)
//         {
//             Console.Write($"{group[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// // RandomizeAnimals(); // rand pettingZoo[]
// // // assign animals to subset-group
// // string[,] group = AssignGroup();
// // Console.WriteLine("School A");
// // PrintGroup(group); // print animal groups

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// // foreach(string animal in pettingZoo) 
// // {
// //     Console.WriteLine(animal);
// // }

// string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

// int studentCount = students.Length;

// Console.WriteLine("The final name is: " + students[studentCount]);

/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// string messageText = "";

// foreach (string name in names)
// {
//     if (name == "Sophia")
//         messageText = SophiaMessage();
//     else if (name == "Andrew")
//         messageText = AndrewMessage();
//     else if (name == "AllGreetings") 
//         // messageText = SophiaMessage();
//         // messageText = messageText + "\n\r" + AndrewMessage(); // not part of code block above
//         messageText = SophiaMessage() + "\n\r" + AndrewMessage();

//     Console.WriteLine(messageText + "\n\r");
// }

// bool pauseCode = true;
// while (pauseCode == true);

// static string SophiaMessage()
// {
//     return "Hello, my name is Sophia.";
// }

// static string AndrewMessage()
// {
//     return "Hi, my name is Andrew. Good to meet you.";
// }

// int productCount = 2000;
// string[,] products = new string[productCount, 2];

// LoadProducts(products, productCount);

// for (int i = 0; i < productCount; i++)
// {
//     string result;
//     result = Process1(products, i);

//     if (result != "obsolete")
//     {
//         result = Process2(products, i);
//     }
// }

// // Process3 message - processing product information for 'new' product
// // Expression - products[i,1] == "new";


// bool pauseCode = true;
// while (pauseCode == true) ;

// static void LoadProducts(string[,] products, int productCount)
// {
//     Random rand = new Random();

//     for (int i = 0; i < productCount; i++)
//     {
//         int num1 = rand.Next(1, 10000) + 10000;
//         int num2 = rand.Next(1, 101);

//         string prodID = num1.ToString();

//         if (num2 < 91)
//         {
//             products[i, 1] = "existing";
//         }
//         else if (num2 == 91)
//         {
//             products[i, 1] = "new";
//             prodID = prodID + "-n";
//         }
//         else
//         {
//             products[i, 1] = "obsolete";
//             prodID = prodID + "-0";
//         }

//         products[i, 0] = prodID;
//     }
// }

// static string Process1(string[,] products, int item)
// {
//     Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

//     return products[item, 1];
// }

// static string Process2(string[,] products, int item)
// {
//     Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
//     if (products[item, 1] == "new")
//         Process3(products, item);

//     return "continue";
// }

// static void Process3(string[,] products, int item)
// {
//     Console.WriteLine($"Process3 message - processing product information for 'new' product");
// }

// step through - 
// result = Process1(products, i);

// string? readResult;
// int startIndex = 0;
// bool goodEntry = false;

// int[] numbers = { 1, 2, 3, 4, 5 };

// // Display the array to the console.
// Console.Clear();
// Console.Write("\n\rThe 'numbers' array contains: { ");
// foreach (int number in numbers)
// {
//     Console.Write($"{number} ");
// }

// // To calculate a sum of array elements, 
// //  prompt the user for the starting element number.
// Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
// while (goodEntry == false)
// {
//     readResult = Console.ReadLine();
//     goodEntry = int.TryParse(readResult, out startIndex);

//     if (startIndex > 5)
//     {
//         goodEntry = false;
//         Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//     }
// }

// // Display the sum and then pause.
// // Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");
// Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

// Console.WriteLine("press Enter to exit");
// readResult = Console.ReadLine();

// // This method returns the sum of elements n through 5
// static int SumValues(int[] numbers, int n)
// {
//     int sum = 0;
//     for (int i = n; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return sum;
// }

// bool exit = false;
// var rand = new Random();
// int num1 = 5;
// int num2 = 5;

// do
// {
//     num1 = rand.Next(1, 11);
//     num2 = num1 + rand.Next(1, 51);

// } while (exit == false);

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
// int x = 5;

// ChangeValue(x);

// Console.WriteLine(x);

// void ChangeValue(int value) 
// {
//     value = 10;
// }

// int x = 5;
// x = ChangeValue(x);
// Console.WriteLine(x);

// int ChangeValue(int value) 
// {
//     value = 10;
//     return value;
// }

/*
try
{   
   // try code block - code that may generate an exception
}
catch
{   
   // catch code block - code to handle an exception
}
finally
{   
   // finally code block - code to clean up resources
}*/

/* 

try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{   
   // Step 5: the system transfers control to the first line of the catch code block
}

*/

/* 

Examples 
- ArrayTypeMismatchException
- DivideByZeroException
- FormatException
- IndexOutOfRangeException
- InvalidCastException
- NullReferenceException
- OverflowException
*/

// string[] names = { "Dog", "Cat", "Fish" };
// Object[] objs = (Object[])names;

// Object obj = (Object)13;
// objs[2] = obj; // ArrayTypeMismatchException occurs

// int number1 = 3000;
// int number2 = 0;
// Console.WriteLine(number1 / number2); // DivideByZeroException occurs

// int valueEntered;
// string userValue = "two";
// valueEntered = int.Parse(userValue); // FormatException occurs

// int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
// int[] values2 = new int[6];

// values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs

// object obj = "This is a string";
// int num = (int)obj; // InvalidCastException

// int[] values = null;
// for (int i = 0; i <= 9; i++)
//     values[i] = i * 2;

// string? lowCaseString = null;
// Console.WriteLine(lowCaseString.ToUpper());
// // NullReferenceException

// decimal x = 400;
// byte i;

// i = (byte)x; // OverflowException occurs
// Console.WriteLine(i);

// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// Console.WriteLine(float1 / float2);
// Console.WriteLine(number1 / number2); // divide zero 
// Console.WriteLine("Exit program");

// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try
// {
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }
// catch
// {
//     Console.WriteLine("An exception has been caught");
// }

// Console.WriteLine("Exit program");

// ∞
// An exception has been caught
// Exit program

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     WriteMessage();
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch {
//         Console.WriteLine("Exception caught in Process1");
//     }
// }

// // ∞
// // Exception caught in Process1
// // Exit program

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in Process1 {ex.Message}");
//     }
//     // catch (Exception ex)
//     // {
//     //     Console.WriteLine($"Exception caught in Process1 {ex.Message}");
//     // }
//     // ∞
//     // Exception caught in Process1 Attempted to divide by zero.
//     // Exit program
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     byte smallNumber;

//     // Console.WriteLine(float1 / float2);
//     // Console.WriteLine(number1 / number2);

//     // checked
//     // {
//     //     smallNumber = (byte)number1;
//     // }

//     try
//     {
//         Console.WriteLine(float1 / float2);
//         Console.WriteLine(number1 / number2);
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//         /*
//             ∞
//             Exception caught in WriteMessage: Attempted to divide by zero.
//             An exception has occurred
//             Exit program
//         */
//     }
//     checked
//     {
//         // smallNumber = (byte)number1;

//         try
//         {
//             smallNumber = (byte)number1;
//         }
//         catch (OverflowException ex)
//         {
//             Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//         }
//         /* 
//             ∞
//             Exception caught in WriteMessage: Attempted to divide by zero.
//             Exception caught in WriteMessage: Arithmetic operation resulted in an overflow.
//             Exit program        
//         */
//     }
// }

// // inputValues is used to store numeric values entered by a user
// string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

// foreach (string inputValue in inputValues)
// {
//     int numValue = 0;
//     try
//     {
//         numValue = int.Parse(inputValue);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid readResult. Please enter a valid number.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("The number you entered is too large or too small.");
//     }
//     catch(Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }

// try
// {
//     int num1 = int.MaxValue;
//     int num2 = int.MaxValue;
//     int result = num1 + num2;
//     Console.WriteLine("Result: " + result);

//     string str = null;
//     int length = str.Length;
//     Console.WriteLine("String Length: " + length);

//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);

//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (OverflowException ex)
// {
//     Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null." + ex.Message);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range." + ex.Message);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// }

// Console.WriteLine("Exiting program.");

// Error: The number is too large to be represented as an integer. Arithmetic operation resulted in an overflow.
// Error: The reference is null. Object reference not set to an instance of an object.
// Error: Index out of range. Index was outside the bounds of the array.
// Error: Cannot divide by zero. Attempted to divide by zero.
// Exiting program.

// Result: -2
// Error: The reference is null.Object reference not set to an instance of an object.
// Exiting program.

// try
// {
//     int num1 = int.MaxValue;
//     int num2 = int.MaxValue;
//     checked
//     {
//         int result = num1 + num2;
//         Console.WriteLine("Result: " + result);
//     }

// }
// catch (OverflowException ex)
// {
//     Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
// }

// try
// {
//     string? str = null;
//     int length = str.Length;

//     // if (str is not null)
//     // {
//     //     int length = str.Length;
//     //     Console.WriteLine("String Length: " + length);
//     // }
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null." + ex.Message);
// }

// try
// {
//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range." + ex.Message);
// }

// try
// {
//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// }

// Console.WriteLine("Exiting program.");

// throw exceptions - 
// ArgumentException or ArgumentNullException
// InvalidOperationException
// NotSupportedException
// IOException
// FormatException

// create exception object

// ArgumentException invalidArgumentException = new ArgumentException();

// customize exception 

// ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
// throw invalidArgumentException;

// throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");

// string[][] userEnteredValues = new string[][]
// {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
// };

// foreach (string[] userEntries in userEnteredValues)
// {
//     try
//     {
//         BusinessProcess1(userEntries);
//     }
//     catch (Exception ex)
//     {
//         if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }

// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);

//             // completes required calculations based on userValue
//             // ...
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//     }
// }

// FormatException: User input values in 'BusinessProcess1' must be valid integers

// re-throw 

// catch (Exception ex)
// {
//     // handle or partially handle the exception
//     // ...

//     // re-throw the original exception object for further handling down the call stack
//     throw;
// }

// catch (Exception ex)
// {
//     // handle or partially handle the exception
//     // ...

//     // create a new exception object that wraps the original exception
//     throw new ApplicationException("An error occurred", ex);
// }

// try
// {
//     OperatingProcedure1();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine("Exiting application.");
// }

// static void OperatingProcedure1()
// {
//     string[][] userEnteredValues = new string[][]
//     {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
//     };

//     foreach(string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             BusinessProcess1(userEntries);
//         }
//         catch (Exception ex)
//         {
//             if (ex.StackTrace.Contains("BusinessProcess1"))
//             {
//                 if (ex is FormatException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Corrective action taken in OperatingProcedure1");
//                 }
//                 else if (ex is DivideByZeroException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

//                     // re-throw the original exception
//                     throw;
//                 }
//                 else
//                 {
//                     // create a new exception object that wraps the original exception
//                     throw new ApplicationException("An error occurred - ", ex);
//                 }
//             }
//         }

//     }
// }

// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);

//             checked
//             {
//                 int calculatedValue = 4 / valueEntered;
//             }
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//         catch (DivideByZeroException)
//         {
//             DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
//             throw unexpectedDivideByZeroException;

//         }
//     }
// }

// FormatException: User input values in 'BusinessProcess1' must be valid integers
// Corrective action taken in OperatingProcedure1
// DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero
// Partial correction in OperatingProcedure1 - further action required
// DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero
// Exiting application.

// Prompt the user for the lower and upper bounds
// Console.Write("Enter the lower bound: ");
// int lowerBound = int.Parse(Console.ReadLine());

// Console.Write("Enter the upper bound: ");
// int upperBound = int.Parse(Console.ReadLine());

// decimal averageValue = 0;

// bool exit = false;

// do
// {
//     try
//     {

//         // Calculate the sum of the even numbers between the bounds
//         averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//         // Display the value returned by AverageOfEvenNumbers in the console
//         Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//         exit = true;
//     }
//     catch (ArgumentOutOfRangeException ex)
//     {
//         Console.WriteLine("An error has occurred.");
//         Console.WriteLine(ex.Message);
//         Console.WriteLine($"The upper bound must be greater than {lowerBound}");
//         // Console.Write($"Enter a new upper bound: ");
//         Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
//         string? userResponse = Console.ReadLine();

//         if (userResponse.ToLower().Contains("exit"))
//         {
//             exit = true;
//         }
//         else
//         {
//             exit = false;
//             upperBound = int.Parse(userResponse);
//         }

//         //  upperBound = int.Parse(Console.ReadLine());
//     }
// }
// while (exit == false);

// // Wait for user input
// Console.ReadLine();

// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {

//     if (lowerBound >= upperBound)
//     {
//         throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
//     }

//     int sum = 0;
//     int count = 0;
//     decimal average = 0;

//     for (int i = lowerBound; i <= upperBound; i++)
//     {
//         if (i % 2 == 0)
//         {
//             sum += i;
//             count++;
//         }
//     }

//     average = (decimal)sum / count;

//     return average;
// }

// The average of even numbers between 3 and 11 is 7.

// Enter the lower bound: 3
// Enter the upper bound: 3
// An error has occurred.
// ArgumentOutOfRangeException: upper bound must be greater than lower bound. (Parameter 'upperBound')
// The upper bound must be greater than 3
// Enter a new upper bound (or enter Exit to quit): 11
// The average of even numbers between 3 and 11 is 7.

// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };

// // string overallStatusMessage = "";

// // overallStatusMessage = Workflow1(userEnteredValues);

// // Workflow1(userEnteredValues);

// // if (overallStatusMessage == "operating procedure complete")

// try
// {
//     Workflow1(userEnteredValues);
//     Console.WriteLine("'Workflow1' completed successfully.");
// }
// // else
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     // Console.WriteLine(overallStatusMessage);
//     Console.WriteLine(ex.Message);
// }

// // static string Workflow1(string[][] userEnteredValues)
// static void Workflow1(string[][] userEnteredValues)
// {
//     // string operationStatusMessage = "good";
//     // string processStatusMessage = "";

//     foreach (string[] userEntries in userEnteredValues)
//     {
//         // processStatusMessage = Process1(userEntries);

//         // Process1(userEntries);

//         // if (processStatusMessage == "process complete")
//         try
//         {
//             Process1(userEntries);
//             Console.WriteLine("'Process1' completed successfully.");
//             Console.WriteLine();
//         }
//         catch (FormatException ex)
//         // else
//         {
//             Console.WriteLine("'Process1' encountered an issue, process aborted.");
//             // Console.WriteLine(processStatusMessage);
//             Console.WriteLine(ex.Message);
//             Console.WriteLine();
//             // operationStatusMessage = processStatusMessage;
//         }
//     }

//     // if (operationStatusMessage == "good")
//     // {
//     //     operationStatusMessage = "operating procedure complete";
//     // }

//     // return operationStatusMessage;
// }

// // static string Process1(String[] userEntries)
// static void Process1(String[] userEntries)
// {
//     // string processStatus = "clean";
//     // string returnMessage = "";
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);

//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
//                 // returnMessage = "Invalid data. User input values must be non-zero values.";
//                 // processStatus = "error";
//             }
//         }
//         else
//         {
//             throw new FormatException("Invalid data. User input values must be valid integers.");
//             // returnMessage = "Invalid data. User input values must be valid integers.";
//             // processStatus = "error";
//         }
//     }

//     // if (processStatus == "clean")
//     // {
//     //     returnMessage = "process complete";
//     // }

//     // return returnMessage;
// }

// // 'Process1' completed successfully.

// // 'Process1' encountered an issue, process aborted.
// // Invalid data. User input values must be valid integers.

// // 'Process1' encountered an issue, process aborted.
// // Invalid data. User input values must be non-zero values.

// // An error occurred during 'Workflow1'.
// // Invalid data. User input values must be non-zero values.

// // --

// // 'Process1' completed successfully.

// // 'Process1' encountered an issue, process aborted.
// // Invalid data. User input values must be valid integers.

// // An error occurred during 'Workflow1'.
// // Invalid data. User input values must be non-zero values.
