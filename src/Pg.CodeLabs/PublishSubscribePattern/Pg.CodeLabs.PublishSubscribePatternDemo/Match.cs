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
    internal class Match
    {
        internal static int Result = 0; 

        public Action? OnChange { get; set; }

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
    }
}
