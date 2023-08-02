string text = "";
char caracter;
int n = 0;

Console.WriteLine("Ingresa el texto");
text = Console.ReadLine();
Console.WriteLine("Ingresa el caracter que desea contar");
caracter = char.Parse(Console.ReadLine());
// 1° metodo
foreach(var c in text)
{
    if(c == caracter)
    {
        n++;
    }
}
// 2° metodo
n = text.Where(c => c == caracter).Count(); 
//
Console.WriteLine("El caracter '" + caracter + "' esta contado " + n);
