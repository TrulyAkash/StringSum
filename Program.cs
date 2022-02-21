class Program
{
    static void Main(string[] args)
    {
        int num, rem, sum = 0, temp;
          
        Console.WriteLine("\n >>>> To Find the sum a number <<<< ");
        Console.Write("\n Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        while (num > 0)
        {
            rem = num % 10;   
            sum = sum  + rem;
            num = num / 10;
            
        }
        Console.WriteLine("\n The Sum of Number is: {0} \n", sum);
       
    }
}