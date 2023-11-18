namespace Learning_3;

public class ThirdTask
{
    
    public void TotalNumber()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= inputNumber; i++)
        {
            sum = sum + i;
            Console.WriteLine(i);
        }
        Console.WriteLine(sum);
    }
}