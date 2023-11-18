namespace Learning_3;

public class SecondTask
{
    private int sum = 0;
    
    public void TotalNumber()
    {
        for (int i = 1; i <= 10; i++)
        {
            sum = sum + i;
        }
        
        Console.WriteLine(sum);
    }
}