
//Program that takes a number and displays the appropriate squares and cubes up to the inputted number

System.Console.WriteLine("Welcome to Exponents program!");

bool continueProgram = true;

//Do while that keeps the program endlessly looping
do{
    
    //User input for variable that will be the max limit on loop
    int userInput = ValidateInteger();

    System.Console.WriteLine("Number\tSquared\tCubed");
    System.Console.WriteLine("=====\t=====\t=====");
    //For loop that squares and cubes all numbers up to userInput
    for(int i = 1; i <= userInput; i++){
        /* Try catch block implemented to catch if the program throws an overflow exception, 
        meaning the value goes beyond the limits of an integer data type
        */
        try{
            int square;
            int cubed;
            checked {
            square = i * i;

            cubed = i * i * i;
            }
            System.Console.WriteLine($"{i}\t{square}\t{cubed}");
        } 
        catch (OverflowException){
            System.Console.WriteLine("the square/cube of one or more values exceeds the limits of an integer data type");
            break;
        }
        
    }

    //Ask user to continue
    continueProgram = QuestionUser(continueProgram);
    System.Console.WriteLine("This is the continueProgram: " + continueProgram);



} while(continueProgram);

static bool QuestionUser(bool answer){
    while(true){
        System.Console.WriteLine("Would you like to continue? Please enter y/n");
        string choice = Console.ReadLine();
        if (choice == "y"){
            answer = true;
            break;
        } else if (choice == "n"){
            answer = false;
            break;
        } else {
            System.Console.WriteLine("Invalid response");
        }
    }
    return answer;
}
    
static int ValidateInteger(){
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