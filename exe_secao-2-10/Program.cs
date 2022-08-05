using Exercicio.Entity;

var peixe = new Peixe("peixe");
var ave = new Ave("ave");

Console.WriteLine(peixe.Tipo);
peixe.Mover();

Console.WriteLine(ave.Tipo);
ave.Mover();
