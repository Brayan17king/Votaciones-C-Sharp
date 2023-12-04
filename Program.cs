internal class Program
{
    private static void Main(string[] args)
    {
        bool salir = true;
        while (salir)
        {
            Console.Clear();
            Console.Write("Ingrese el numero de universidades: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < opcion; i++)
            {
                int a = 0;
                int r = 0;
                int b = 0;
                int n = 0;

                int ua = 0;
                int ur = 0;
                int ub = 0;

                Console.Write("Universidad: ");
                string universidad = Console.ReadLine();
                string x = string.Empty;
                bool loop = true;
                while (loop)
                {
                    Console.Write("Voto: ");
                    string opc = Console.ReadLine().ToLower();

                    if (opc == "a")
                    {
                        a += 1;
                    }
                    else if (opc == "r")
                    {
                        r += 1;
                    }
                    else if (opc == "b")
                    {
                        b += 1;
                    }
                    else if (opc == "n")
                    {
                        n += 1;
                    }
                    else if (opc == "x")
                    {
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("Votol no valido");
                    }
                }
                Console.WriteLine($"{universidad} : {a} aceptan : {r} rechazan : {i} blanco : {n} nulos\n");
                if (a > r)
                {
                    ua += 1;
                }
                else if (r > a)
                {
                    ur += 1;
                }
                else if (r < b || a < b)
                {
                    ub += 1;
                }
                Console.WriteLine($"Universidades que aceptan : {ua}");
                Console.WriteLine($"Universidades que aceptan : {ur}");
                Console.WriteLine($"Universidades que aceptan : {ub}");
                Console.ReadLine();
                salir = false;
            }
        }
    }
}
