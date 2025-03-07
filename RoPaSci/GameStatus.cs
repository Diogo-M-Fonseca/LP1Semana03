using System;

namespace GameStatuses
{
    [Flags]
    enum GameStatus
    {
        Draw,
        Player1Wins,
        Player2Wins
    }
}