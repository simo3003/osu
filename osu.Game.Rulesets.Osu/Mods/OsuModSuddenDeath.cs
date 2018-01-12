﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System;
using System.Linq;
using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModSuddenDeath : ModSuddenDeath
    {
        public override Type[] IncompatibleMods => base.IncompatibleMods.Concat(new[] { typeof(OsuModAutopilot) }).ToArray();
    }
}