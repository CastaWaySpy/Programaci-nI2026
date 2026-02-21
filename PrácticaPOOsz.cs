//Sergio Zea 0907-25-12821

Console.WriteLine("Operación de valores (para visualizar los valores en ASCII, ulitiza números del 33 en adelante)");

Console.WriteLine("Ingresa el primer valor");
int val1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el segundo valor");
int val2 = int.Parse(Console.ReadLine());

//Operación suma
int suma = val1 + val2;
Console.WriteLine("Suma " + suma);

//Operación resta
int resta = val1 - val2;
Console.WriteLine("Resta " + resta);

//Operación multiplicación
int multi = val1 * val2;
Console.WriteLine("Multiplicación " + multi);

//Operación división
int div = val1 / val2;
Console.WriteLine("División " + div);

//ASCII
char letra1 = Convert.ToChar(val1);
char letra2 = Convert.ToChar(val2);
Console.WriteLine("ASCII "+letra1 + " y "+ letra2);
