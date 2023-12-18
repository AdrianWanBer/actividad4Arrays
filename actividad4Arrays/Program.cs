namespace actividad4Arrays
{
    class program
    {
        public static void Main(String[] args)
        {

            Random r = new Random();
            Console.WriteLine("¿Que tamaño quieres que tenga el vector? :");
            int tamañoVector = Convert.ToInt32(Console.ReadLine());

            int[] VectorNumeros = new int[tamañoVector];

            for (int i = 0; i < tamañoVector; i++)
            {
                int valorRandom = r.Next(1, 100);
                VectorNumeros[i] = valorRandom;

            }
            Array.Sort(VectorNumeros);
            for (int j = 0; j < tamañoVector; j++)
            {
                Console.WriteLine(VectorNumeros[j]);
            }

        }
    }
}
