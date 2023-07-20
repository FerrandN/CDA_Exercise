using PackageFigure;

Cercle c = new Cercle(1,2,3);

Rectangle r = new Rectangle(4, 5, 6, 7);

Figures listFigures = new Figures(8, 9);



listFigures.Add(c);
listFigures.Add(r);

listFigures.AccepterVisiteur(new VisiteurDeFigurePourConsole());
