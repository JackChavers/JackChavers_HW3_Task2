// Jack Chavers
// HW 3 Tutor

using System.ComponentModel.Design;

Random rnd = new Random();
int num1 = rnd.Next(0, 51);
int num2 = rnd.Next(0, 51);
int answer = num1 + num2;
int userInputInt;
do
{
    string message = string.Format($"{num1}+{num2}=?");
    Console.Write(message);
    string userInputStr = Console.ReadLine();
    userInputInt = Convert.ToInt32(userInputStr);
    if (userInputInt == answer)
    {
        message = "Congratulations! you get the right answer!";
        Console.WriteLine(message);
        break;
    }
    else
    {
        message = "Sorry, please try again!";
        Console.WriteLine(message);
    }







}
while (true);