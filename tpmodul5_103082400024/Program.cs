using System;

public class HaloGeneric
{
    public void sapaUse<T>(T X)
    {
        Console.WriteLine($"Halo user {X}");
    }

    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.sapaUse<string>("praktikan");
    }
}