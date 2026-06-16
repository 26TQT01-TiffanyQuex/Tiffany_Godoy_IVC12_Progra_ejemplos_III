internal class Program
{
    private static void Main(string[] args)
    {
        int comparador;
        bool ExisteRepetido= false;
        int[] numerosEnteros = new int[15];

        for (int indice = 0; indice < numerosEnteros.Length; indice++)
        {
            Console.WriteLine("Digite el número "+(indice+1)+":");
            numerosEnteros[indice] = Convert.ToInt32(Console.ReadLine());
        }
        for (int indice = 0; indice < numerosEnteros.Length; indice++)
        {
            for (comparador = indice + 1; comparador < 15; comparador++)
            {
                if (numerosEnteros[indice] == numerosEnteros[comparador]);
                {
                    ExisteRepetido = true;
                }
            }

        }
        if (ExisteRepetido = true)
        {
            Console.WriteLine("Sí existe al menos un repetido");
        }
        else
        {
            Console.WriteLine("No esxiste ningún repetido");
        }
    }
}