// See https://aka.ms/new-console-template for more information
//Console.WriteLine("ingresa la clave");
//string? clave = Console.ReadLine();

//while (clave != "667788")

//{ Console.WriteLine("la clave es incorrecta");
//clave = Console.ReadLine();

//}
//Console.WriteLine("la clave es la correcta");
//do    clave = Console.ReadLine();

//} while (clave != "667788");

//Console.WriteLine("la clave es correcta");//

// 2 y 3

int numm;
int cont = 0;
double suma = 0;

Console.WriteLine("ingrese un numero:");

int num;

do
{
    num = int.Parse(Console.ReadLine());
  
    if (num < 0)
    {
        suma = suma + num;
        cont = cont + 1;
    }
    

} while ( num < 0);
Console.WriteLine("correcto el numero es positivo");

Console.WriteLine("el promedio es: " + suma/cont);


//4 y 5.

/*int numm;
int cont = 0;
double suma = 0;

Console.WriteLine("ingrese un numero:");

string? num = Console.ReadLine();

do
{
    num = Console.ReadLine();
    numm = int.Parse(num);
    suma = suma + numm;
    cont = cont + 1;



} while (numm < 999);
Console.WriteLine(" usted ingreso un numero mator de 3 cifras ");
Console.WriteLine("el promedio es: ",(suma / cont)); */













