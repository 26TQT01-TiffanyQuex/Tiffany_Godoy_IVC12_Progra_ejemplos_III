internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADÉMICOS\nNombre: Tiffany Godoy" + "\nGrado : IV C" +
           "\nClave: 12");

        string[] color = new string[9];
        color[1] = "café";
        color[2] = "lila";
        color[3] = "rojo";
        color[4] = "naranja";
        color[5] = "amarillo";
        color[6] = "verde";
        color[7] = "morado";
        color[8] = "negro";

        Console.WriteLine("ingrese un número del 1 al 8");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("color: " + color[i-1]);
    }
}