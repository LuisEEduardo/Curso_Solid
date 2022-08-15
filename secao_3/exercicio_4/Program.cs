using Exercicio;

Produto celular = new Produto("Celular", 1500);
Produto perfume = new Produto("Perfume", 100);

IPromocao promocaoDiasMaes = new PromocaoDiasMaes();
IPromocao promocaoDiaNamorados = new PromocaoDiasNamorados();


Console.WriteLine($"Promoção dias das mães => R$ {promocaoDiasMaes.CalcularPromocao(celular)}");
Console.WriteLine($"Promoção dias das mães => R$ {promocaoDiasMaes.CalcularPromocao(perfume)}");

Console.WriteLine($"Promoção dias dos namorados => R$ {promocaoDiaNamorados.CalcularPromocao(celular)}");
Console.WriteLine($"Promoção dias dos namorados => R$ {promocaoDiaNamorados.CalcularPromocao(perfume)}");
