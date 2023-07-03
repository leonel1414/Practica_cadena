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
*/

//interpolación
var persona = (nombre: "Leonel", apellido: "Girett", edad: "30", lenguaje: "C#");
Console.WriteLine($"Hola mi nombre es, {persona.nombre}, tengo {persona.edad} años");
