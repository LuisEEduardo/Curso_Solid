namespace Exercicio.Entity;

public class Transacao : ConectarBancoDados, ITrasacao, IRelatorio
{
    public void Executa()
    {
        Console.WriteLine("Processando transação ...");
    }

    public void Imprimir()
    {
        Console.WriteLine("Imprimindo ...");
    }
}