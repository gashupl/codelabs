using Pg.CodeLabs.PublishSubscribePatternDemo;

Console.WriteLine("Welcome mortal!");

var john = new RealFan();
var mike = new BarcaFan();

var score = new Match();
score.OnChange += john.React;
score.OnChange += mike.React;

score.RealScores();
score.RealScores();
score.RealScores();

Console.WriteLine("Game over"); 
