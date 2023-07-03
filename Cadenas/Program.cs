/*string? str = null;
string str3 = System.String.Empty;
string str4 = "";
string str5 = " ";


//tipo y salida
Console.WriteLine($"str5: {str5}");
Console.WriteLine(str5.GetType());

//Concatenacion
string str1 = ("Hola buenos dias,");
string str2 = ("Estoy programando en C#");
Console.WriteLine(str1 + " " + str2);


//Literales
//Caracteres escapados -> \n \r \t
//Tabulador
string columns = ("Column 1 \tColumn 2\tColumn 3");
Console.WriteLine(columns);
//Salto de linea
string content = ("Contenido1 \nContenido1");
Console.WriteLine(content);
//Salto de fila
string rows = ("contenido1 contenido1\r\ncontenido2 contenido2\r\nRow 3");
Console.WriteLine(rows);


//interpolación
var persona = (nombre: "Leonel", apellido: "Girett", edad: "30", lenguaje: "C#");
Console.WriteLine($"Hola mi nombre es, {persona.nombre}, tengo {persona.edad} años");


//Arrays
string[] names = new string[2];
names[0] = "Leonel Girett";
names[1] = "Belen Gonzalez";

foreach (string name in names) { 
    Console.WriteLine(name);
}
Console.WriteLine("\n");
Console.WriteLine("FOR CLASICO");
for (int i = 0; i < names.Length; i++) {
    Console.WriteLine(names[i]);
}

int[] numbers = { 4, 6, 5, 2, 3, 1 };
//Array original
foreach (var number in numbers) {
    Console.WriteLine(number);
}
Console.WriteLine("\n");
Console.WriteLine("*** Array Ordenada***");

Array.Sort(numbers);
foreach (int i in numbers) {
    Console.WriteLine(i);
}
*/

// Mas tipo de Arrays
int[,] miArray = new int[2,2]; //1 2
                               //3 4

miArray[0, 0] = 1;
miArray[0, 1] = 2;
miArray[1, 0] = 3;
miArray[1, 1] = 4;

for (int i = 0; i < 2; i++) {
     for (int j = 0; j < 2; j++)
    {
        Console.Write(miArray[i, j] + " ");
    }
     Console.WriteLine("");
}

