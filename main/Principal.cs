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

class Secundaria()
{
    public function ehPython()
    {
        string txt = Console.ReadLine();
        if (txt.Contains(';'))
            Console.Write("não ");
        Console.WriteLine("é Python");
    }

    static int Media(int a, int b)
    {
        //  (a + b)/2
    }
}

class Auxiliar(){ public void exibeOi() { Console.log('Oi'); }}