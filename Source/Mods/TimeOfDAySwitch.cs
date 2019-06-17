﻿using Harmony;
using Multiplayer.API;
using Verse;

namespace Multiplayer.Compat
{
    /// <summary>Time of day switches by merthsoft</summary>
    /// <see href="https://bitbucket.org/merthsoft/timeofdayswitch"/>
    [MpCompatFor("Time-of-Day Switches")]
    class TimeOfDAySwitch
    {
        public TimeOfDAySwitch(ModContentPack mod)
        {
            MP.RegisterSyncMethod(AccessTools.Method("TimerSwitches.TimeOfDaySwitch:SetState"));
        }
    }
}
