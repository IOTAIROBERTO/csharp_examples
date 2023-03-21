tipoRetorno nombreMetodo (tipoDato ListaDeParametros)
{
    //Enunciados que se ejecutarán
}

void nombreMetodo (tipoDato ListaDeParametros)
{
    //Enunciados que se ejecutarán
}

/////////////////////////////////////////////////////////////////////////////////////////
void Imprimir()
{
    Console.WriteLine("HolaNundo!");
}

/////////////////////////////////////////////////////////////////////////////////////////
void Imprimir(string mensaje)
{
    Console.WriteLine(mensaje);
}

Imprimir("Hola desde la invocación al método!...");

/////////////////////////////////////////////////////////////////////////////////////////
string Imprimir(string mensaje)
{
    Console.WriteLine(mensaje);
    return mensaje + "Hola desde el método!..."; 
}

string cadenaDevuelta =  Imprimir("invocando desde otra parte... ");
//el return en cadenaDevuelta será:  invocando desde otra parte... Hola desde el método!"


/////////////////////////////////////////////////////////////////////////////////////////
int SumaNumeros(int x, int y)
{
    return x + y;
}
int numResultado = SumaNumeros(5 + 6);
Console.WriteLine(numResultado);
//// Se imprimirá en la variable numResultado, en Console.Writeline: 11
