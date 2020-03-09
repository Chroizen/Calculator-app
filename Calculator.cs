    class Program
    {
        static void Main(string[] args)
        {
		Console.Title = "Aplikasi ngitung";

            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
			
			Console.WriteLine("\ntekan tombol ash mbuh");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
		static int Pengurangan(int a, int b)
        {
            return a - b;
        }

    }
} 