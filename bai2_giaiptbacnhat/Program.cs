internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int intA, intB;
        double X;
        Console.WriteLine(" Chuong Trinh Giai Phuong Trinh Bac 1 ");
        Console.WriteLine(" aX + b = 0 ");
        Console.Write(" Nhap a: ");
        intA = Convert.ToInt32(Console.ReadLine());
        Console.Write(" {0}", "Nhap b: ");
        intB = Convert.ToInt32(Console.ReadLine());
        if (intA == 0 && intB == 0)
        {
            Console.WriteLine(" Phuong Trinh Co Vo So Nghiem ");
        }
        else if (intA == 0 && intB != 0)
        {
            Console.WriteLine(" Phuong Trinh Vo Nghiem ");
        }
        else
        {
            X = (double)-intB / intA;
            Console.WriteLine(" Phuong Trinh Co 1 Nghiem Duy Nhat x = {0} ", X);
        }
    }
}