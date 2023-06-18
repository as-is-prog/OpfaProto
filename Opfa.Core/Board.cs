using System;
using System.Collections.Generic;
using System.Text;
using Opfa.Core.Data;

namespace Opfa.Core
{
    internal class Board
    {
        public IList<IList<BoardEvent>> RecentEvents { get; } = new List<IList<BoardEvent>>();
        public IList<IList<MapCell>> MapCells { get; } = new List<IList<MapCell>>();
        public IList<Actor> Actors { get; } = new List<Actor>();

        internal Board()
        {
            
        }

    }
}
