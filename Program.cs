



//setting up the variables...
int time;
string getTime;
string myName;



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