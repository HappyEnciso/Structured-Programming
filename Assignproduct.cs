namespace Assingproduct;
class Assignproduct
{
    static void Main(string[] args)
    {
        //b * c
        //a = product of b and c
        Console.Write("b : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c : ");
        int c = Convert.ToInt32(Console.ReadLine());

        int a = b * c; //product

        Console.WriteLine("a : " + a);
    }
}