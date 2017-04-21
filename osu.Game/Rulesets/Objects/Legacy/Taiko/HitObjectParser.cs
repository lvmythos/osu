﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using OpenTK;
using osu.Game.Audio;
using osu.Game.Rulesets.Objects.Types;
using System.Collections.Generic;

namespace osu.Game.Rulesets.Objects.Legacy.Taiko
{
    /// <summary>
    /// A HitObjectParser to parse legacy osu!taiko Beatmaps.
    /// </summary>
    internal class HitObjectParser : Legacy.HitObjectParser
    {
        protected override HitObject CreateHit(Vector2 position, bool newCombo)
        {
            return new Hit
            {
                NewCombo = newCombo,
            };
        }

        protected override HitObject CreateSlider(Vector2 position, bool newCombo, List<Vector2> controlPoints, double length, CurveType curveType,
                                          int repeatCount, List<SampleInfo> headSamples, List<SampleInfo> tailSamples, List<List<SampleInfo>> repeatSamples)
        {
            return new Slider
            {
                NewCombo = newCombo,
                ControlPoints = controlPoints,
                Distance = length,
                CurveType = curveType,
                RepeatCount = repeatCount,
                HeadSamples = headSamples,
                TailSamples = tailSamples,
                RepeatSamples = repeatSamples
            };
        }

        protected override HitObject CreateSpinner(Vector2 position, double endTime)
        {
            return new Spinner
            {
                EndTime = endTime
            };
        }
    }
}
