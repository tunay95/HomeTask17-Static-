namespace HomeTask17_Static_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter Your Word : ");
            string Input = Console.ReadLine();

            Console.WriteLine(" Enter The part which You Want To Check : ");
            string Input2 = Console.ReadLine();

            Console.WriteLine(Input.CustomContains(Input2));



            Console.WriteLine(" Enter The Number : ");
            int InputNum = int.Parse(Console.ReadLine());
            Console.WriteLine(InputNum.IsPrime());




            Console.WriteLine(" Enter The Number : ");
            int InputNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine(InputNum2.IsPowOfTwo());
        }
    }
}