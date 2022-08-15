using Exercicio;

Produto celular = new Celular("Celular LG", 1000, new PromocaoDiasMaes());
var precoCelular = celular.PrecoVenda();
Console.WriteLine($"{celular.Nome} com desconto de {celular.DescontoPromocao()}% por {precoCelular}");

Produto perfume = new Perfume("Puro VooDoo", 300, new PromocaoDiasNamorados());
var precoPerfume = perfume.PrecoVenda();
Console.WriteLine($"{perfume.Nome} com desconto de {perfume.DescontoPromocao()}% por {precoPerfume}");
