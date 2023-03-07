namespace Pg.CodeLabs.PublishSubscribePatternDemo
{
    //Sample subscriber
    internal class BarcaFan
    {
        public void React()
        {
            Console.WriteLine($"Oh no! Another one :(. We already lost {Match.Result} goal(s)!");
        }
    }
}
