﻿//Shaun Aguirre-Reyes
//10/17/22
//2:50pm
//This is when the computer adds to numbers that the user inputted

Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){

Console.WriteLine("Lets add two numbers!");
Console.WriteLine("Enter your first number");
string numberOne = Console.ReadLine();

Console.WriteLine("Enter your second numnber");
string numberTwo = Console.ReadLine();

int num1 = Convert.ToInt32(numberOne);
int num2 = Convert.ToInt32(numberTwo);


Console.WriteLine("Your sum is:" + (num1 + num2));

Console.WriteLine("Would you like to try again?");
playAgain = Console.ReadLine();
if(playAgain == "yes"){
    Console.WriteLine("Lets play again");
}else{
    Console.WriteLine("Have a great day :)");
}

}

