namespace Pg.CodeLabs.PublishSubscribePatternDemo
{
    //Sample subscriber
    internal class RealFan
    {
        public void React()
        {
            Console.WriteLine($"Yes. We are winning! We already have { Score.Result } goal(s)!"); 
        }

        public void Scream(int happinessLevel)
        {
            Console.WriteLine($"Aaaaarghhh... My happiness level: { happinessLevel } %");
        }
    }
}
