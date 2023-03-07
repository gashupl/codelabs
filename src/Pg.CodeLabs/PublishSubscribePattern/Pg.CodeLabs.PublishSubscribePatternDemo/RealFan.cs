namespace Pg.CodeLabs.PublishSubscribePatternDemo
{
    //Sample subscriber
    internal class RealFan
    {
        public void React()
        {
            Console.WriteLine($"Yes. We are winning! We already have { Match.Result } goal(s)!"); 
        }
    }
}
