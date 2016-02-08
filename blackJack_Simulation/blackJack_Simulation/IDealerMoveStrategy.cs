using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    interface IDealerMoveStrategy
    {
        MoveAction Response(Hand hand);
    }
}
