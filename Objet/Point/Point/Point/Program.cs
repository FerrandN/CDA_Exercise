using Point;

Points p = new Points(2,5);
Points pSymmetric = p.DuplicateSymmetricallyOrigin();
Console.WriteLine(pSymmetric.ParticularToString());
Points pSymmetricAxeAbs = p.DuplicateSymmetricallyAbscisse();
Console.WriteLine(pSymmetricAxeAbs.ParticularToString());
Points pSymmetricAxeOrd = p.DuplicateSymmetricallyOrdonnee();
Console.WriteLine(pSymmetricAxeOrd.ParticularToString());
Points pDuplicate = new Points(p);

Console.WriteLine(p.ParticularToString());

Console.WriteLine(p.Move(5, 8));
Console.WriteLine(p.ParticularToString());

p.SwapParticular();
Console.WriteLine(p.ParticularToString());


