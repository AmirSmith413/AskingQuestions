// --- Mauricio Review, good job!!!



//setting up the variables...
int time;
string getTime;
string myName;
string decision;
bool playAgain = true;

while(playAgain == true)
{
Console.WriteLine("What is your name?");

//user will type their name
myName = Console.ReadLine();
Console.WriteLine("What time did you wake up?");
//user will type the time they woke up
getTime = Console.ReadLine();

//the int will convert into a string
time = Convert.ToInt32(getTime);


//name and time will be displayed here
Console.WriteLine($"Your name is {myName} and you woke up at {time} o clock.");
Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
 decision = Console.ReadLine().ToUpper();
 //if the user wanted to try again, pressing "Y" will send them to the beginning
 if(decision == "Y")
    {
      playAgain = true;
    }
    else if(decision == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playAgain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    }   
}
