using Exercicio;

Pizzaria p1 = new Pizzaria(new PizzaFactory());

p1.CriarPizza("mussarela");
p1.CriarPizza("calabresa");

Console.ReadLine();
