namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        string palabra, inverso, caracter;
        int i;
        Console.WriteLine("Ingrese palabra");
         palabra = Convert.ToString(Console.ReadLine());
       // palabra = "anitalavalatina";
        i = palabra.Length;
        inverso = "";
        for (int x = i-1; x >= 0; x--)
        {
            caracter = palabra.Substring(x,1);
            inverso = inverso + caracter;
        }
        if(palabra == inverso)
        {
            Console.WriteLine("Es palindroma");
        }
        else
        {
            Console.WriteLine("No es palindroma");
        }
        Console.ReadKey();


    }
}