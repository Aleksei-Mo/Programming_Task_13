// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("This programm finds the third digit of the entered number.");
Console.Write("Please enter your number: "); // enter our number
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter target position of digit which you want to find: ");// enter position of digit. Default value =3
int position = Convert.ToInt32(Console.ReadLine());
char result = FindDigitPosition (number,position);
Console.WriteLine("The desired digit of your number is "+ result);




char FindDigitPosition (int yourNumber, int targetDigitPosition)// function to find number of digit
{
char targetDigitStr=' ';
string yourNumberStr=Convert.ToString(yourNumber); // convert input number to string variable
int numberOfDigit=yourNumberStr.Length; // determine number of digit of the entered number
if (numberOfDigit<targetDigitPosition-1)
{
    Console.WriteLine("Error! The target digit is not available. Check entered number.");

}
else
{
    targetDigitStr=yourNumberStr[targetDigitPosition-1];// find a target digit
}
return targetDigitStr;
}
