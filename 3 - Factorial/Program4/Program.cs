static int fact(int num)
{
    if (num == 0 || num == 1)
    {
        return 1;
    }
    if (num < 0)
    {
        return -1;
    }
    return num * fact(num - 1);
}
while (true) {
    int num, fac;
    Console.Write("Please enter a number : ");
    num = int.Parse(Console.ReadLine());
    fac = fact(num);
    Console.WriteLine("Factorial Of " + num + " = " + fac);
}
