using System;
using System.Collections.Generic;
using System.Text;

namespace Opfa.Core
{
    internal class Stage
    {
        internal Board MyBoard { get; set; }

        internal Stage() 
        {
            MyBoard = new Board();
        }

        public void Tick()
        {

        }

        public bool IsDecided()
        {
            return true;
        }        
    }
}
