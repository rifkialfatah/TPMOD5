using System;

    
namespace TP_MODUL5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<string> data = new DataGeneric<string>("103022400057");

            data.PrintData();

            Console.ReadLine();
        }
    }

    class DataGeneric<T>
    {
        public T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}