using bouteille3;

bouteille bottle = new bouteille();

bouteille otherBottle = new bouteille(bottle);

//bottle state
bottle.State();
//bottle is closed, we try to fill it
Console.WriteLine(bottle.Fill(30));
//same but with full
Console.WriteLine(bottle.FullFill());

//same but we try to empty it
Console.WriteLine(bottle.Empty(30));
Console.WriteLine(bottle.FullEmpty());
bottle.State();

//close the already closed bottle
bottle.Close();
bottle.State();

//open the bottle
bottle.Open();

bottle.State();

//try to fill too much
bottle.Fill(250);
//try to empty too much
bottle.Empty(250);
bottle.State();

//try to full fill
bottle.FullFill();
bottle.State();

//try to full empty
bottle.FullEmpty();
bottle.State();

//try to fill a bit
bottle.Fill(50);
//try to empty a bit
bottle.Empty(25);
bottle.State();

//try to close the bottle
bottle.Close();
bottle.State();