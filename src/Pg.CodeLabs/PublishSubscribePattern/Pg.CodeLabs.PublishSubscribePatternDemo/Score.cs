using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg.CodeLabs.PublishSubscribePatternDemo
{
    /// <summary>
    /// Events publisher
    /// </summary>
    internal class Score
    {
        internal static int Result = 0; 

        public Action? OnChange { get; set; }

        public Action<int>? OnEndGame { get; set; }
        //Rise event
        public void RealScores()
        {
            Result++; 
            //Check if OnChange Action is set before invoking it
            if (OnChange != null)
            {
                //Invoke OnChange Action
                OnChange();
            }
        }

        public void EndGame(int happinessLevel)
        {
            
            if (OnEndGame != null)
            {
                OnEndGame(happinessLevel);
            }
        }
    }
}
