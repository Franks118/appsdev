// See https://aka.ms/new-console-template for more information
Console.Write("Enter three numbers: ");
string input = Console.ReadLine();
//indexing


int index1 = input.IndexOf(' ');
int index2 = input.LastIndexOf(' ');

int num1;
int num2;
int num3;



//initiate the numbers for comparison
num1 = Convert.ToInt32(input.Substring(0, index1));
num2 = Convert.ToInt32(input.Substring(index1 + 1, index2 - index1));
num3 = Convert.ToInt32(input.Substring(index2 + 1));


if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("number 1 is the largest");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("number 2 is the largest");
}
else
{
    Console.WriteLine("number 3 is the largest");
}
