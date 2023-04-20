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

//Do While
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

int numm;
int cont = 0;
double suma = 0;

Console.WriteLine("ingrese un numero:");

int num;

do
{
    num = int.Parse(Console.ReadLine());

    if (num > 0)
    {
        suma = suma + num;
        cont = cont + 1;

    }
} while ( num < 999);

Console.WriteLine("El numero supera las 3 cifras");

Console.WriteLine("el promedio es: " + suma / cont);


//While 1 y 2 

Console.WriteLine("ingrese valor:");
string? val = Console.ReadLine();
int valor = int.Parse(val);
int suma = 0;
int cont = 0;
while (valor > 0)
{
    suma = suma + valor;

   Console.WriteLine("ingrese valor");
   val = Console.ReadLine();
   valor = int.Parse(val);
    cont = cont + 1;
}

Console.WriteLine("la suma total de los valores es:" + suma);
Console.WriteLine("el promedio de los valores es:" + suma / cont); 


// 3


List<string?> nombres = new List<string?>();

{
    while (nombres is not null)
    {
        Console.WriteLine("Ingrese in nombre:");
        nombres.Add(Console.ReadLine());
     
    }

 }
   
Console.WriteLine("la cantidad de nombres ingresados es de:" + nombres.Count);

// 4

Console.WriteLine("ingrese el costo:");
string? costo = Console.ReadLine();
double Costo = double.Parse(costo);
Console.WriteLine("ingrese el total:");
string? total = Console.ReadLine();
double Total = double.Parse(total);

double sumacosto = 0;
double sumatotal = 0;

while (Costo != 0) 

{
    Console.WriteLine("ingrese el costo:");
     costo = Console.ReadLine();
     Costo = double.Parse(costo);
    Console.WriteLine("ingrese el total:");
     total = Console.ReadLine();
     Total = double.Parse(total);
    
    sumacosto = sumacosto + Costo;
    sumatotal = sumatotal + Total;
}

Console.WriteLine("Total adeudado:" + (sumacosto + sumatotal));

// 5

string? productos;
Console.WriteLine("ingrese la cantdad de productos de la compra:");
productos = Console.ReadLine();
int cantproductos = int.Parse(productos);
Console.WriteLine("ingrese el total:");
string total = Console.ReadLine();
double Total = double.Parse(total);
Console.WriteLine("ingrese el costo de cada producto:");
string costo = Console.ReadLine();
double Costo = double.Parse(costo);
double sumaCosto = 0;
int contCostos = 0;
while (contCostos <= cantproductos)
{
    Console.WriteLine("ingrese el costo de cada producto:");
    costo = Console.ReadLine();
    Costo = double.Parse(costo);
    sumaCosto += Costo;
    contCostos = contCostos + 1;
}

Console.WriteLine("total adeudado:" + (sumaCosto + Total));

// For 1

Console.WriteLine("se le solicita ingregar 5 valores");
int valoressumados = 0;
string? valor = "";


for (int contvalores = 0; contvalores < 5; contvalores++)
{

    Console.WriteLine("Ingrese los valores: ");
    valor = Console.ReadLine();
    int valores = int.Parse(valor);

    valoressumados = valoressumados + valores;

}
Console.WriteLine("la suma de valores es:" + valoressumados);

//2

int sumanum = 0;
string? num = "";

for (int contnum = 0; contnum < 8; contnum++)
{

    Console.WriteLine("Ingrese 8 numeros aleatorios:");
    num = Console.ReadLine();
    int numero = int.Parse(num);

    sumanum = sumanum + numero;
  

}
Console.WriteLine("el promedio es:" + (sumanum / 8));


// 3

Console.WriteLine("Debera ingresar los datos solicitados");
double sumaCosto = 0;
double sumaTotal = 0;

for (int contnum = 0; contnum < 5; contnum++)
{
    Console.WriteLine("ingrese el total:");
    string total = Console.ReadLine();
    double Total = double.Parse(total);
    Console.WriteLine("ingrese el costo de cada producto:");
    string costo = Console.ReadLine();
    double Costo = double.Parse(costo);

    sumaCosto += Costo;
    sumaTotal += Total;
}

Console.WriteLine("total adeudado:" + (sumaCosto + sumaTotal));

//4

int mayor = 0;
List<string?> numeros = new List<string?>();

{
    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine("Ingrese numeros aleatorios:");
        numeros.Add(Console.ReadLine());

       if (i < i+1)
        {
            mayor = i + 1;

        }
        else
        {
            mayor = i;
        }

    }

}

Console.WriteLine("el mayor es:" + mayor);


// 5






