using System;

namespace GameStatuses
{
    [Flags]
    enum GameStatuses
    {
        Draw,
        Player1Wins,
        Player2Wins
    }
}