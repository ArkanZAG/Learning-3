namespace Learning_3;

public class FourthTask
{
    public void AverageNumber()
    {
        int inputNumber = 0;
        Console.WriteLine("Please type how many number you would like to input : ");
        int totalData = int.Parse(Console.ReadLine());
        Console.WriteLine("Please type in the number : ");
        int sum = 0;

        for (int i = 0; i < totalData; i++)
        {
            inputNumber = Convert.ToInt32(Console.ReadLine());
            sum = sum + inputNumber;
        }

        int avg = sum / totalData;
        
        Console.WriteLine("The total number according to the inputed numbers are : " + sum);
        Console.WriteLine("The average number according to the inputed numbers are : " + avg);
        
    }
}