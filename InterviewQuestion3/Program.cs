//IT IS SIMPLE CALCULATOR PLEASE ADD Substraction and Division action to calculator. Please fix issue with line 19th.


using InterviewQuestion3;

Console.WriteLine("Enter the action to be performed");
Console.WriteLine("Press 1 for Addition\n");
int action = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 1st value");
int input_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd value");
int input_2 = Convert.ToInt32(Console.ReadLine());
int result = 0;
switch (action)
{
    case 1:
        {
            //PLEASE DO NOT MODIFY LINE BELOW. INSTEAD MODIFY CODE SOMEWHERE ELSE TO FIX ISSUE
            result = ActionMaker.Addition(input_1, input_2);
            break;
        }
   
    default:
        Console.WriteLine("You enetered something wrong");
        break;
}
Console.WriteLine("RESULT: {0}", result);
Console.ReadKey();  
          
 

