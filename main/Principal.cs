using System;
using EventArgs;
using Errors;
using Data.SQL.Client;

class Principal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Commit 3 - Jo�o");
        Console.WriteLine("Commit 4 - Jo�o");
        Console.WriteLine("Commit 5 - Jo�o");
        Console.WriteLine("Commit 6 - Jo�o");
        Console.WriteLine("Commit 7 - Jo�o");
        Console.WriteLine("Commit 10 - Jo�o");

        int a, b;
        if (a > b)
            Console.WriteLine(a);
        else
            if(b < a)
                Console.WriteLine(b);
            else
                Console.WriteLine("Iguais");
    }


}

class Secundaria
{
    public function ehPython()
    {
        string txt = Console.ReadLine();
        if (txt.Contains(';'))
            Console.Write("não ");
        Console.WriteLine("é Python");
    }

    public int MediaDeDoisNumeros(int a, int b)
    {
        double media = 0;
        media = a + b / 2;
        return media;
    }

    public void Escreve()
    {
        Console.WriteLine("Henrique - Commit função média");
        Console.WriteLine("Commit 2 - Henrique");
        Console.WriteLine("Commit 8 - Henrique");
        Console.WriteLine("Commit 9 - Henrique");
    }

    public int SomaDeDoisNumeros(int a, int b)
    {
        double soma = 0;
        soma = a + b;
        return soma;
    }
}

class Auxiliar
{
    char nada;
    public metodoAleatorio()
    {
        return nada;
    }
}