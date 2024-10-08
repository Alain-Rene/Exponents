﻿
//Program that takes a number and displays the appropriate squares and cubes up to the inputted number

System.Console.WriteLine("Welcome to Exponents program!");

bool continueProgram = true;

//Do while that keeps the program endlessly looping
do{
    
    //User input for variable that will be the max limit on loop
    int userInput = ValidateInteger();

    System.Console.WriteLine("{0,10} {1,10} {2,10}", "Number", "Square", "Cube");
    
    //For loop that squares and cubes all numbers up to userInput
    for(int i = 1; i <= userInput; i++){
        /* Try catch block implemented to catch if the program throws an overflow exception, 
        meaning the value goes beyond the limits of an integer data type
        */
        try{
            int square;
            int cubed;

            //Checked which checks if the program is squared or not
            checked {
            square = i * i;

            cubed = i * i * i;
            }
            System.Console.WriteLine("{0,10} {1,10} {2,10}", i, square, cubed);
        } 
        catch (OverflowException){
            System.Console.WriteLine("the square/cube of one or more values exceeds the limits of an integer data type");
            break;
        }
    }

    //Ask user to continue
    continueProgram = QuestionUser(continueProgram);



} while(continueProgram);

static bool QuestionUser(bool answer){
    while(true){
        //Method that asks user if they would like to continue
        System.Console.WriteLine("Would you like to continue? Please enter y/n");
        string choice = Console.ReadLine();
        if (choice == "y"){
            answer = true;
            break;
        } 
        else if (choice == "n"){
            answer = false;
            break;
        } 
        else {
            System.Console.WriteLine("Invalid response");
        }
    }
    return answer;
}
    
static int ValidateInteger(){
    //Method that validates the user's input
    int input;
    while (true){
        Console.WriteLine("Please enter a positive integer:");
        input = int.Parse(Console.ReadLine());

        if (input <= 0){
            System.Console.WriteLine("Invalid response.");
        } 
        else {
            break;
        }
    }
   
   return input;

}