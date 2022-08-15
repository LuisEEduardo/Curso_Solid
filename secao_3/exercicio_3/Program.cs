using Exercicio;

ICalculaImpostoPais calculo = new CalcularImpostoBrasil();
calculo.TotolRenda = 1000;
calculo.TotolDeducao = 100;

CalcularImposto calcularImposto = new CalcularImposto();
var valorTotalImposto = calcularImposto.Calcular(calculo);

Console.WriteLine($"Brasil R$ {valorTotalImposto}");

