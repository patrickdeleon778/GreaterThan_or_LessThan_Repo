bool playAgain = true;
bool playAgainResponse = true;

bool isNum1;
bool isNum2;

string? userAnswer;
string? input1;
string? input2;

int num1;
int num2;

    while(playAgain == true)
    {
        playAgainResponse = true;

        Console.Write("Input your first number: "); // This asks the user to input their first number

        //int num1 = Convert.ToInt32(Console.ReadLine()); // Converts the users first number into a integer with the Convert.ToInt32() method
            do
            {
                input1 = Console.ReadLine();
                isNum1 = int.TryParse(input1, out num1);

                if(isNum1 != true)
                {
                    Console.WriteLine($"{input1} is not a number. Enter a valid number. ");
                }
            }
            while(isNum1 != true);

        Console.Write("Input your second number: "); // This asks the user to input their second number

        //int num2 = Convert.ToInt32(Console.ReadLine()); // Converts the users second number into an integer
            do
            {
                input2 = Console.ReadLine();
                isNum2 = int.TryParse(input2, out num2);

                if(isNum2 != true)
                {
                    Console.WriteLine("PLEASE FOR THE LOVE OF GOD ENTER A NUMBER!");
                }
            }
            while(isNum2 != true);

        if (num1 == num2) // checks to see if the users 2 numbers are equal to each other
        {
            Console.WriteLine($"{num1} is equal to {num2}"); // if they are it will display this output
        }
        else if (num1 < num2) // checks to see if the users first number is less than the user's second number
        {
            Console.WriteLine($"{num1} is less than {num2}"); // if the users first number is less than the second number this output will display 
            Console.WriteLine($"{num2} is greater than {num1}"); // this output displays the opposite of the output above
        }
        else if (num1 > num2) // checks to see if the users first number is greater than the user's second number
        {
            Console.WriteLine($"{num1} is greater than {num2}"); // if the users first number is greater than the second number than this output will display
            Console.WriteLine($"{num2} is less than {num1}"); // this one will display the opposite of what the output is above
        }

        while(playAgainResponse == true)
            {
                Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

                userAnswer = Console.ReadLine().ToUpper();

                if(userAnswer == "Y")
                {
                    playAgain = true;
                    playAgainResponse = false;
                }
                else if(userAnswer == "N")
                {
                    playAgain = false;
                    playAgainResponse = false;
                }
                else
                {   
                    playAgain = false;
                    playAgainResponse = true;
                    Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");
                }
            }
    }




