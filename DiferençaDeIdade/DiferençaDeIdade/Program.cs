using System;
public class DiferençaDeIdade
{
    public static void Main(string[] args)
    {
        int idade = 64;
        bool isSolteiro = false;

        if (idade >= 18 && idade <= 65 && isSolteiro)
        {
            Console.WriteLine("És adulto e solteiro");
        }
        else if (idade >= 18 && idade <= 65 && !isSolteiro)
        {
            Console.WriteLine("És adulto e casado");
        }
        else if (idade >= 65)
        {
            Console.WriteLine("És sénior");
        }
        else
        {
            Console.WriteLine("És menor de idade");
        }
    }
}