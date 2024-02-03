class Program
{
    static void Main(string[] args)
    {
        //Solicitar al usuario la cantidad de universidades
        Console.WriteLine("Ingrese la cantidad de universidades que participan en el proceso: ");
        int cantidadUniversidades = int.Parse(Console.ReadLine());

        //Variables para almacenar los totales de votos
        int totalAceptadas = 0;
        int totalRechazadas = 0;
        int totalEmpates = 0;

        //Recorrer cada universidad
        for (int i = 1; i <= cantidadUniversidades; i++)
        {
            //Solicitar el nombre de la universidad
            Console.WriteLine("Ingrese el nombre de la universidad {0}: ", i);
            string nombreUniversidad = Console.ReadLine();

            //Variables para almacenar los votos de la universidad
            int votosAceptados = 0;
            int votosRechazados = 0;
            int votosNulos = 0;
            int votosBlancos = 0;

            //Leer los votos de la universidad
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese un voto (A: Aceptar, R: Rechazar, N: Nulo, B: Blanco, X: Terminar): ");
                string voto = Console.ReadLine();

                switch (voto.ToUpper())
                {
                    case "A":
                        votosAceptados++;
                        break;
                    case "R":
                        votosRechazados++;
                        break;
                    case "N":
                        votosNulos++;
                        break;
                    case "B":
                        votosBlancos++;
                        break;
                    case "X":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Voto inválido. Intente de nuevo.");
                        break;
                }
            }

            //Mostrar los totales de votos de la universidad
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Universidad: {0}", nombreUniversidad);
            Console.WriteLine("Votos Aceptados: {0}", votosAceptados);
            Console.WriteLine("Votos Rechazados: {0}", votosRechazados);
            Console.WriteLine("Votos Nulos: {0}", votosNulos);
            Console.WriteLine("Votos Blancos: {0}", votosBlancos);
            Console.WriteLine("----------------------------------------");

            //Actualizar los totales generales
            if (votosAceptados > votosRechazados)
            {
                totalAceptadas++;
            }
            else if (votosRechazados > votosAceptados)
            {
                totalRechazadas++;
            }
            else
            {
                totalEmpates++;
            }
        }

        //Mostrar el resultado de la votación
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Resultado de la votación:");
        Console.WriteLine("Universidades que aceptan: {0}", totalAceptadas);
        Console.WriteLine("Universidades que rechazan: {0}", totalRechazadas);
        Console.WriteLine("Universidades con empate: {0}", totalEmpates);
        Console.WriteLine("----------------------------------------");
    }
}
