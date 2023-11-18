namespace Learning_3;

public class FifthTask
{
    public void Perkalian()
    {
        Console.WriteLine("Masukan angka yang anda ingin kalikan : ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Berapa kali angka yang anda masukan ingin di kalikan : ");
        int totalData = int.Parse(Console.ReadLine());

        for (int i = 1; i <= totalData; i++)
        {
            int perkalian = inputNumber * i;
            Console.WriteLine(perkalian);
        }

    }
}