using System;
using tpmodul5_103082400024;

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.sapaUse<string>("praktikan");

        DataGeneric<string> data = new DataGeneric<string>("1030824000024");
        data.PrintData();

    }
}
