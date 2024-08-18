
using System;
using System.Diagnostics;
using System.Threading;
//Part 1
// Get two inputs from the userds and store them in two variables and use and if statement to check if the two inputs are equal and print out a message to the console.
// Hint: You can use the == operator to check if two values are equal.

void CheckInputEqual()
{
    Console.WriteLine("Enter two variables: ");
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();

    if (input1 == input2)
    {
        Console.WriteLine($"{input1} = {input2}");
    }
    else
    {
        Console.WriteLine("Two variables aren't equal");
    }
};
// CheckInputEqual();




//Part 2
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than the second input and print out a message to the console.
// Hint: You can use the > operator to check if the first input is greater than the second input.

void CheckInputGreater()
{
    Console.WriteLine("Enter two variables are numbers: ");
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();

    double num1 = double.Parse(input1);
    double num2 = double.Parse(input2);


    if (num1 > num2)
    {
        Console.WriteLine($"{input1} > {input2}");
    }
    else
    {
        Console.WriteLine("the first input isn't greater than the second input!");
    }
}
// CheckInputGreater();


//Part 3
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than the second input and print out a message to the console.
// Hint: You can use the < operator to check if the first input is less than the second input.
void CheckInputLess()
{
    Console.WriteLine("Enter two variables are numbers: ");
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();

    double num1 = double.Parse(input1);
    double num2 = double.Parse(input2);


    if (num1 < num2)
    {
        Console.WriteLine($"{input1} < {input2}");
    }
    else
    {
        Console.WriteLine("the first input isn't less than the second input!");
    }
}
// CheckInputLess();

//Part 4
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is not equal to the second input and print out a message to the console.
// Hint: You can use the != operator to check if two values are not equal.

void CheckInputDifferent()
{
    Console.WriteLine("Enter two variables are numbers: ");
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();

    double num1 = double.Parse(input1);
    double num2 = double.Parse(input2);


    if (num1 != num2)
    {
        Console.WriteLine($"{input1} != {input2}");
    }
    else
    {
        Console.WriteLine("The case under consideration is not correct!");
    }
}
// CheckInputLess();

//Part 5
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than or equal to the second input and print out a message to the console.
// Hint: You can use the >= operator to check if the first input is greater than or equal to the second input.


void CheckInputGreaterThanOrEqual()
{
    Console.WriteLine("Enter two variables are numbers: ");
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();

    double num1 = double.Parse(input1);
    double num2 = double.Parse(input2);


    if (num1 >= num2)
    {
        Console.WriteLine($"{input1} >= {input2}");
    }
    else
    {
        Console.WriteLine("The first input isn't greater than or equal to the second input!");
    }
}

// CheckInputGreaterThanOrEqual();

//Part 6
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than or equal to the second input and print out a message to the console.
// Hint: You can use the <= operator to check if the first input is less than or equal to the second input.
void CheckInputLessThanOrEqual()
{
    Console.WriteLine("Enter two variables are numbers: ");
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();

    double num1 = double.Parse(input1);
    double num2 = double.Parse(input2);


    if (num1 <= num2)
    {
        Console.WriteLine($"{input1} <= {input2}");
    }
    else
    {
        Console.WriteLine("The first input isn't less than or equal to the second input!");
    }
}
// CheckInputLessThanOrEqual();


//Part 7
// Create a math quiz that asks the user a math question and checks if the user's answer is correct. If the user's answer is correct, print out a message to the console. If the user's answer is incorrect, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user's answer is correct.
void MathQuiz()
{
    Console.WriteLine("Calculate the result of this calculation: 345.34 / 234.54");
    Console.WriteLine("Enter your answer (Round the result to 2 decimal places): ");

    double num1 = 345.34D;
    double num2 = 234.54D;
    double calculate = Math.Round((num1 / num2), 2);

    string input1 = Console.ReadLine();

    double result = double.Parse(input1);


    if (calculate == result)
    {
        Console.WriteLine("Your answer is correct!");
    }
    else
    {
        Console.WriteLine($"Your answer is not correct! The result is: {calculate}");
    }
}
// MathQuiz();

//Part 8
// Create a program that asks the user for their age and checks if the user is old enough to vote. If the user is old enough to vote, print out a message to the console. If the user is not old enough to vote, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user is old enough to vote.
void CheckAgeToVote()
{
    Console.WriteLine("Enter your age: ");

    string input1 = Console.ReadLine();

    int age = int.Parse(input1);

    int specifiedAge = 18;

    if (age >= specifiedAge)
    {
        Console.WriteLine("You is old enough to vote!");

    }
    else
    {
        Console.WriteLine("You isn't old enough to vote!");
    }
}

// CheckAgeToVote();



//Part 9
// Create a program that check whihc state a enemy is in based on their health points. If the enemy has 100 health points, print out a message to the console. If the enemy has 50 health points, print out a different message to the console. If the enemy has 25 health points, print out a different message to the console. If the enemy has 0 health points, print out a different message to the console.
// Hint: You can use an if-else statement to check the enemy's health points and print out a message based on the enemy's health points.
void checkStateEnemy()
{
    int healthPoints = 100;

    if (healthPoints == 100)
    {
        Console.WriteLine("The enemy is at its best!");

    }
    else if (healthPoints == 50)
    {
        Console.WriteLine("The enemy has only half its health remaining. Can attack!");

    }
    else if (healthPoints == 25)
    {
        Console.WriteLine("Weak enemies. Let's attack!");
    }
    else if (healthPoints == 0)
    {
        Console.WriteLine("The enemy is dead!");

    }
}
// checkStateEnemy();


//Part 10
// Create a program that checks if a user is eligible for a discount based on their age. If the user is 18 years old or older, print out a message to the console. If the user is younger than 18 years old, print out a different message to the console.
// Hint: You can use an if-else statement to check the user's age and print out a message based on the user's age.

void checkEligible()
{
    Console.WriteLine("Enter your age: ");
    string input = Console.ReadLine();

    int age = int.Parse(input);

    if (age >= 18)
    {
        Console.WriteLine("You are not eligible for a discount!");

    }
    else
    {
        Console.WriteLine("You are eligible for a discount!");

    }
}
// checkEligible();
////////////// Break , Continue Statements //////////////

//Part 1
// Create a program that counts from 1 to 20, but skips counting the number 5.
// Hint: Use a for loop to iterate through the numbers and a continue statement to skip the number 5.
void countNumber()
{
    for (int i = 1; i <= 20; i++)
    {
        if (i == 5)
        {
            continue;
        }
        Console.WriteLine(i);

    }

}
// countNumber();

//Part 2
// Create a program that prints the numbers from 1 to 10, but breaks the loop if the number 7 is encountered.
// Hint: Use a for loop to iterate through the numbers and a break statement to exit the loop when 7 is encountered.

void countNumberUntilSeven()
{
    for (int i = 1; i <= 10; i++)
    {
        if (i == 7)
        {
            break;
        }
        Console.WriteLine(i);

    }

}
// countNumberUntilSeven();


//Part 3
// Write a program to print all even numbers from 1 to 20, but skip printing the number 10.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 10.

void countEvenNumber()
{
    for (int i = 1; i <= 20; i++)
    {
        if (i % 2 == 0)
        {
            if (i == 10)
            {
                continue;
            }
            Console.WriteLine(i);
        }

    }

}
// countEvenNumber();

//Part 4
// Create a program that searches for the word "apple" in a list of fruits. If found, print "Apple found!"; otherwise, continue searching.
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement to check if the current fruit is "apple". Use a continue statement to continue searching if "apple" is not found.

string[] fruits = { "Apricot", "Damson", "Cherry", "Apple", "Peach", "Banana" };

void searchTheWord(string[] listfruits)
{
    foreach (string fruit in listfruits)
    {
        if (fruit.ToLower() == "apple")
        {
            Console.WriteLine("Apple found!");
            break;
        }
        continue;
    }
}
// searchTheWord(fruits);

//Part 5
// Write a program to count from 1 to 100, but skip counting by 10s.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip counting by 10s.

void count()
{
    var stopwatch = Stopwatch.StartNew();
    for (int i = 0; i <= 100; i++)
    {
        if (i % 10 == 0)
        {
            continue;
        }
        Console.WriteLine(i);

    }

}
// count();

//Part 6
// Create a program to print the letters of the alphabet from A to G, but skip printing the letter 'E'.
// Hint: Use a for loop to iterate through the alphabet and an if statement with a continue statement to skip printing 'E'.

List<string> alphabet = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

void printAlphabet(List<string> _alphabet)
{

    for (int i = 0; i <= _alphabet.Count; i++)
    {
        if (_alphabet[i].ToUpper() == "E")
        {
            continue;
        }
        Console.WriteLine(_alphabet[i]);
    }

}
// printAlphabet(alphabet);

//Part 7
// Write a program to find and print all prime numbers between 1 and 50, skipping non-prime numbers.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip non-prime numbers.

bool checkPrime(int num)
{
    if (num < 2)
    {
        return false;
    }

    for (int i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;



}
// Console.WriteLine(checkPrime(4));

void primeNumber()
{

    for (int i = 1; i <= 50; i++)
    {
        if (checkPrime(i))
        {
            Console.WriteLine(i);
        }
    }
}
// primeNumber();

//Part 8
// Create a program to print the numbers from 1 to 10, but skip printing the number 3.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 3.

void countWithoutThree()
{
    for (int i = 1; i <= 10; i++)
    {
        if (i == 3)
        {
            continue;
        }
        Console.WriteLine(i);

    }

}
// countWithoutThree();

//Part 9
// Write a program to search for the number 20 in an array of integers. If found, print its index; otherwise, continue searching.
// Hint: Use a for loop to iterate through the array and an if statement to check if the current element is 20. Use a continue statement to continue searching if 20 is not found.
List<int> integerNums = new List<int>() { 1, 2, 20, 21, 40, 41, 80, 81 };
void searchTwenty(List<int> _integerNums)
{
    for (int i = 0; i <= _integerNums.Count; i++)
    {
        if (_integerNums[i] != 20)
        {
            continue;
        }
        Console.WriteLine(_integerNums[i]);

    }

}
// searchTwenty(integerNums);

//Part 10
// Create a program that prints the names of different fruits, but skips printing the name "banana".
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement with a continue statement to skip printing "banana".
void printFruitWithoutBanana(string[] listfruits)
{
    foreach (string fruit in listfruits)
    {
        if (fruit.ToLower() == "banana")
        {
            continue;
        }
        Console.WriteLine(fruit);

    }
}
// printFruitWithoutBanana(fruits);



////////////// Extra Challenges //////////////

/*
Part 11

ABC Company pays its sales agents on a commission basis. 
Each agent is paid 10% commission for monthly sales above or equal to $10,000 and 5% commission for monthly sales below $10,000.

Write a program to accept the monthly sales of a particular agent and based on the amount, determine and print out the commission earned.

Example:
Enter the monthly sales: 12000
Commission earned: $1200.00

*/
double commission()
{
    Console.WriteLine("Enter the monthly sales: ");
    string input = Console.ReadLine();

    double monthlySales = double.Parse(input);

    double commissionAbove = 0.1;

    double commissionBelow = 0.05;

    int KPI = 10000;

    double commissionEarned;

    if (monthlySales >= KPI)
    {
        commissionEarned = Math.Round(monthlySales * commissionAbove, 2);


    }
    else
    {
        commissionEarned = Math.Round(monthlySales * commissionBelow, 2);
    }

    return commissionEarned;
}
// Console.WriteLine($"Commission earned: {commission()}");

/*
Part 12

Write a program that generates two integers between 0 and 100 inclusive and prompts the user to enter the sum of these 2 integers. The program reports if the answer is correct or wrong (program will also print the correct answer if the user's answer is wrong).

Hint: You need to use the random module.

Example:
Enter the sum of 43 and 58: 100
Correct!

 */

void calculateSum()
{
    Random random = new Random();
    int randomNum = random.Next(0, 100);
    int num1 = randomNum;
    int num2 = randomNum;

    Console.WriteLine($"Enter result of: {num1} + {num2}");

    string input = Console.ReadLine();

    int result = int.Parse(input);

    if ((num1 + num2) == result)
    {
        Console.WriteLine("Congratulation!!! Result is correct!");
    }
    else
    {
        Console.WriteLine($"Unfortunately!!! The correct result should be: {num1 + num2}");

    }


}
// calculateSum();
/*
 Part 13

The grade that you get for a module depends on your marks. The table below shows the grade for each range of marks.

Marks   |   Grade   |   Comment
---------------------------------
>= 85   |     A+    |  Excellent!
>= 80   |     A     |  Well done.
>= 75   |     B+    |
>= 70   |     B     |
>= 65   |     C+    |
>= 60   |     C     |
>= 55   |     D+    |
>= 50   |     D     |
< 50    |     F     |  See me.

Write a program that asks for a student’s marks, then displays the correct grade and the corresponding comment (if any).

Example:
Enter student's marks: 82
Grade: A
Comment: Well done.
 
 */
void theGrade()
{
    Console.WriteLine($"Enter student's marks: ");

    string input = Console.ReadLine();

    int marks = int.Parse(input);

    string grade = "";
    string comment = "";

    if (marks >= 85)
    {
        grade = "A+";
        comment = "Excellent!";

    }
    else if (marks >= 80 && marks < 85)
    {
        grade = "A";
        comment = "Well done.";
    }
    else if (marks >= 75 && marks < 80)
    {
        grade = "B+";
    }
    else if (marks >= 70 && marks < 75)
    {
        grade = "B";
    }
    else if (marks >= 65 && marks < 70)
    {
        grade = "C+";
    }
    else if (marks >= 60 && marks < 65)
    {
        grade = "C";
    }
    else if (marks >= 55 && marks < 60)
    {
        grade = "D+";
    }
    else if (marks >= 50 && marks < 55)
    {
        grade = "D";
    }
    else
    {
        grade = "F";
        comment = "See me.";
    }

    Console.WriteLine($"Grade: {grade}\n Comment: {comment}");
}

// theGrade();


/*
 Part 14

 A guard in a computer game acts as follows:

If sees_player == False, he will wait

If sees_player == True:
    - If dist_from_player <= 1, he will attack
    - If 2 <= dist_from_player <= 4, he will advance
    - If dist_from_player >= 5, he will wait

Write a program that shows how the guard will act.

Example:
sees_player = True
dist_from_player = 3

The guard will advance.

 
 */

void theGuard()
{

    bool sees_player = true;
    int dist_from_player = 3;

    if (sees_player == false)
    {
        Console.WriteLine("The guard will wait.");
    }
    else
    {
        if (dist_from_player <= 1)
        {
            Console.WriteLine("The guard will attack.");

        }
        else if (dist_from_player >= 2 && dist_from_player <= 4)
        {
            Console.WriteLine("The guard will advance.");

        }
        else if (dist_from_player >= 5)
        {
            Console.WriteLine("The guard will wait.");

        }
    }

}
// theGuard();