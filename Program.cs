using System.ComponentModel.Design;
using System.Reflection.Emit;

int numero, mayor, menor;

Console.WriteLine("Ingrese un número positivo (0 para salir):");
numero = Convert.ToInt32(Console.ReadLine());

mayor = numero;
menor = numero;

do
{
    Console.WriteLine("Ingrese un número positivo (0 para salir):");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }

        if (numero < menor)
        {
            menor = numero;
        }
    }

} while (numero != 0);

if (mayor != int.MinValue && menor != int.MaxValue)
{
    Console.WriteLine("El número mayor ingresado es: {0}", mayor);
    Console.WriteLine("El número menor ingresado es: {0}", menor);
}
else
{
    Console.WriteLine("No se ingresaron números positivos.");
}

// Adivinar e numero que esta pensando 

Console.WriteLine("1. Piensa o anota un numero positivo");
Console.WriteLine("2. Multiplica ese numero por 2");
Console.WriteLine("3. Ahora sumale 8 al resultado que obtuviste");
Console.WriteLine("4. Multiplica ese resultado por 5");
Console.WriteLine("Ahora escribe el resultado final y te dire el numero que pensaste");
string resultadoStr = Console.ReadLine();

int numero = int.Parse(resultadoStr.Substring(0, resultadoStr.Length - 1));
numero -= 4;

Console.WriteLine("¡¡Tu numero es {0}!!", numero);



// Contador de palabras

Console.WriteLine("Ingrese una frase: ");
string frase = Console.ReadLine();

int numeroPalabras = 0;
int i = 0;
while (i < frase.Length)
{
    // Saltar espacios en blanco
    while (i < frase.Length && Char.IsWhiteSpace(frase[i]))
    {
        i++;
    }


    if (i < frase.Length)
    {
        numeroPalabras++;
        while (i < frase.Length && !Char.IsWhiteSpace(frase[i]))
        {
            i++;
        }
    }
}

// Contar vocales
int numeroVocales = 0;
foreach (char caracter in frase)
{
    if ("aeiouáéíóú".Contains(char.ToLower(caracter)))
    {
        numeroVocales++;
    }
}

Console.WriteLine("Número de palabras: {0}", numeroPalabras);
Console.WriteLine("Número de vocales: {0}", numeroVocales);


//Programa para comprobar si una palabra es un palíndromo

// Ingreso de la palabra
Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();

// Convertir la palabra a minúsculas
palabra = palabra.ToLower();

// Invertir la palabra
string palabraInvertida = "";
for (int i = palabra.Length - 1; i >= 0; i--)
{
    palabraInvertida += palabra[i];
}

// Comparar la palabra original con la invertida
bool esPalindromo = palabra == palabraInvertida;

// Mostrar el resultado
if (esPalindromo)
{
    Console.WriteLine("¡La palabra '{0}' es un palíndromo!", palabra);
}
else
{
    Console.WriteLine("La palabra '{0}' no es un palíndromo.", palabra);
}