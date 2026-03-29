using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul5_103082400024
{
    public class DataGeneric<T>
    {
        T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah : {data}");
        }
    }
}
