# Votaciones

##### La CONFECH, en su afán de agilizar el proceso de recuento de las votaciones, le ha encargado el desarrollo de un programa de registro de votación por universidades.

##### Primero, el programa debe solicitar al usuario ingresar la cantidad de universidades que participan en el proceso.

##### Luego, para cada una de las universidades, el usuario debe ingresar el nombre de la universidad y los votos de sus alumnos, que pueden ser: aceptar (A), rechazar (R), nulo (N) o blanco (B). El término de la votación se indica ingresando una X, tras lo cual se debe mostrar los totales de votos de la universidad, con el formato que se muestra en el ejemplo.

##### Finalmente, el programa debe mostrar el resultado de la votación, indicando la cantidad de universidades que aceptan, que rechazan y en las que hubo empate entre estas dos opciones.

```csharp
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

```