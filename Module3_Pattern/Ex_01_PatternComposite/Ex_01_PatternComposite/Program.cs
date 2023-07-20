using Expression;

Addition a = new Addition(new Addition(new Nombre(5), new Nombre(6)), new Nombre(7));
Console.WriteLine(a.Formate());
