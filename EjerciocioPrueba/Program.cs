// See https://aka.ms/new-console-template for more information
using EjerciocioPrueba;
using System.Text.RegularExpressions;

//Console.WriteLine("Hola Mundo!");
//Console.WriteLine("Por favor ingrese su nombre");
//Console.ReadLine();
//Console.WriteLine("Presione Enter para salir");
//Console.ReadKey();

//Persona Alumno = new Persona ();


internal class Program
{
    //private static void Main(string[] args)
    //{
    //    string cuit;
    //    bool flag = false;


    //    while (flag == false)
    //    {
    //        Console.Write("Ingrese CUIT: ");
    //        cuit = Console.ReadLine();
    //        flag = ValidarCUIT(cuit);
    //    }
    //}

    //private static bool ValidarCUIT(string cuit)
    //{
    //    {
    //        string cleanedcuil = cuit;

    //        // Verificar longitud del CUIT
    //        if (cuit.Length != 11)
    //        {
    //            Console.WriteLine("La longitud debe ser de 11 digitos");
    //            return false;
    //        }
    //        // Verificar que todos los caracteres sean dígitos numéricos
    //        foreach (char c in cuit)
    //        {
    //            if (!char.IsDigit(c))
    //            {
    //                return false;
    //            }
    //        }

    //        // Obtener los dos primeros dígitos
    //        string firstTwoDigits = cleanedcuil.Substring(0, 2);

    //        // Verificar que los dos primeros dígitos sean válidos
    //        int firstTwoDigitsValue = Convert.ToInt32(firstTwoDigits);

    //        if (firstTwoDigitsValue != 20 && firstTwoDigitsValue != 27 && firstTwoDigitsValue != 23 && firstTwoDigitsValue != 30 && firstTwoDigitsValue !=33 && firstTwoDigitsValue !=34)
    //        {
    //            Console.WriteLine("El CUIT es inválido");
    //        }

    //        else

    //            Console.WriteLine("El CUIT es correcto");
    //        { return true; }



    //    }

    //    // Si todas las validaciones pasan, devuelve true
    //    return true;
    //}


    public static void Main()
    {
        Console.WriteLine("Ingrese un email");
        
        string email = Console.ReadLine();
        bool isValid = ValidateEmail(email);

        if (isValid == false)

            Console.WriteLine("El correo electrónico es inválido");
        else
        {
            return;
        }
        
    }

    public static bool ValidateEmail(string email)
    {
        // Expresión regular para validar el formato del correo electrónico
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        // Utilizar Regex.IsMatch para verificar si el correo electrónico coincide con el patrón
        return Regex.IsMatch(email, pattern);
    }



}