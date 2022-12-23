/*
 * Ejercicio 1
 * Tabla de Multiplicar con el Bucle While
 
 */
/*
int t = 0;
int resul;
Console.WriteLine("Escrbe el numero que deseas para crear tu tabla de multiplicacion");
int numero_a_multplicar = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nTabla de Multiplicar del numero : { numero_a_multplicar }");

while (t < 10)
{
    t++;
    resul = t * numero_a_multplicar;
    Console.WriteLine($"\n { numero_a_multplicar } X { t } = { resul }");

}*/

/*
 * Ejercicio 2 - Do while
 * Escribe un programa que realice estos pasos:
    1- Reciba al menos un número por consola
    2- Determine si el número es positivo o negativo
    3- Presente un contador para cada tipo (positivo y negativo).
 */
/*
Console.WriteLine("Ingrese un Numero");
int d = Convert.ToInt32(Console.ReadLine());

do
{
    d--;
    if(d > 0)
    {
        Console.WriteLine($" {d} -- Positivo");
    }
    else if(d < 0)
    {
        Console.WriteLine($" {d} -- Negativo");
    }

} 
while (d >= 0);

*/


/*
 * Ejercicio 3 FOR
 * Escribe un programa que realice estos pasos:
    Reciba 3 datos:
    ancho
    alto
    relleno o no
 
 */

//Caso Rectangulo

int alto, ancho, relleno, x, y;

Console.Write("Ingrese el Alto del rectangulo: ");
alto = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el Ancho del rectangulo: ");
ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

relleno = alto * ancho;

if(alto != ancho)
{
    for (x = 1; x <= alto; x++)
    {
        for (y = 1; y <= ancho; y++)
        {
            Console.Write("* ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine($"\nEl total de * en el relleno del rectangulo es de: { relleno } ");
}
else
{
    Console.WriteLine("\nDebes de ingresar valores distintos en el Alto y el Ancho para poder formar un rectangulo a cambio formaste un cuandro");

    for (x = 1; x <= alto; x++)
    {
        for (y = 1; y <= ancho; y++)
        {
            Console.Write("* ");
        }
        Console.WriteLine(" *");
    }
    Console.WriteLine($"\nEl total de * en el relleno del Cuadrado es de: {relleno} ");
    Console.ReadLine();
}


Console.ReadLine();