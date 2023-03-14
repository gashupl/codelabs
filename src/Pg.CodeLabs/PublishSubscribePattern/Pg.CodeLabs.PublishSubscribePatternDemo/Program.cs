using Pg.CodeLabs.PublishSubscribePatternDemo;

Console.WriteLine("Welcome mortal!");

var john = new RealFan();
var mike = new BarcaFan();

var score = new Score();
score.OnChange += john.React;
score.OnChange += mike.React;
score.OnEndGame += john.Scream; 

score.RealScores();
score.RealScores();
score.RealScores();
score.EndGame(100); 

Console.WriteLine("Game over"); 
