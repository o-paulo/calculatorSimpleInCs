using System;

class Aula08{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("{0} digite o primeiro valor: ", nome);
        v1 = Convert.ToInt32(Console.ReadLine()); // Primeiro formato para converter um valor de string para int é usando Convert.ToInt32()

        Console.Write("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine()); // Segundo formato possivel é utilizando int.Parse()

        soma = v1 + v2;

        Console.Write("A soma entre {0} e {1} é: {2} ", v1, v2, soma);
    }
}