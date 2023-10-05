// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------------------------------------");



Console.WriteLine("--------------------- Matriz Aleatoria --------------------");
// Se requiere: 
// Crear una función llamada RandomArray() que devuelva una matriz de enteros​

// Crea una matriz vacía que contenga 10 valores enteros.​
int[] array = new int[10];

// Recorre la matriz y asigna a cada índice un valor entero aleatorio entre 5 y 25.​
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(5, 26); // Genera un número aleatorio entre 5 y 25 (excluido el 26. el ultimo número).
}

// * Imprime todos los valores.
Console.WriteLine("Matriz generada aleatoriamente:");
foreach (int number in array)
{
    Console.Write($"{number} ");
}
// Imprime los valores mínimo y máximo de la matriz.​
Console.Write($"\nValor Min --> {array.Min()}  -  Valor Max --> {array.Max()}.");


// Imprime la suma de todos los valores.​
Console.WriteLine($"\nSuma de los valores--> {array.Sum()}");





Console.WriteLine("--------------------- Lanzamiento de Moneda --------------------");

static string TossCoin()
{
    // 1. Imprime "¡Tirando una moneda!".
    Console.WriteLine("¡Tirando una moneda!");

    // 2. Lanza una moneda al azar y obtén un resultado ("Cara" o "Cruz").
    Random random = new Random();
    int randomNumber = random.Next(2); // Genera un número aleatorio 0 o 1.

    string result = (randomNumber == 0) ? "Cara" : "Cruz";

    // 3. Imprime el resultado.
    Console.WriteLine(result);

    // 4. Devuelve el resultado.
    return result;
}
TossCoin();


Console.WriteLine("--------------------- Lanzamiento de Varias Moneda --------------------");
static double TossMultipleCoins(int num)
{
    int headsCount = 0;
    // Random random = new Random();

    // Realiza el lanzamiento de monedas num veces y cuenta las cabezas.
    for (int i = 0; i < num; i++)
    {
        string result = TossCoin(); // Llama a la función TossCoin previamente definida.
        if (result == "Cara")
        {
            headsCount++;
        }
    }

    // Calcula la relación entre lanzamientos de cara y lanzamientos totales.
    double ratio = (double)headsCount / num;

    // Imprime los resultados en la consola.
    Console.WriteLine($"Lanzamientos de cara: {headsCount}");
    Console.WriteLine($"Lanzamientos totales: {num}");
    Console.WriteLine($"Relación entre caras y lanzamientos: {(ratio*100).ToString("F2")}%");

    // Devuelve la relación como un valor de tipo double.
    return ratio;
}

TossMultipleCoins(57);





Console.WriteLine("--------------------- Nombres --------------------");
static List<string> Nombres()
{
    // 1. Crea una lista con los valores Todd, Tiffany, Charlie, Ginebra, Sydney.
    List<string> nombres = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };

    // Imprime la lista original en consola.
    Console.WriteLine("Lista original:");
    ImprimirLista(nombres);

    // 2. Filtra los nombres de más de 5 caracteres y los imprime en consola.
    List<string> nombresFiltrados = nombres.Where(nombre => nombre.Length > 5).ToList();
    Console.WriteLine("Nombres con más de 5 caracteres:");
    ImprimirLista(nombresFiltrados);

    // 3. Baraja la lista y la devuelve en el nuevo orden.
    Random random = new Random();
    List<string> listaBarajada = nombres.OrderBy(item => random.Next()).ToList();
    Console.WriteLine("Lista de Nombres Barajada:");
    ImprimirLista(listaBarajada);

    return nombres;
}

static void ImprimirLista(List<string> lista)
{
    foreach (string nombre in lista)
    {
        Console.WriteLine($"- {nombre}");
    }
}

Nombres();