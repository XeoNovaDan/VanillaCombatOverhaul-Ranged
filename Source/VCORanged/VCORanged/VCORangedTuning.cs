﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine;
using Verse;
using RimWorld;
using HarmonyLib;

namespace VCORanged
{

    public static class VCORangedTuning
    {

        public const float AccuracyScorePerDistance = -0.6f;
        public const float AccuracyScoreWeather = -16;
        public const float AccuracyScoreCoveringGas = -16;
        public const float AccuracyScoreCover = 16;
        public const float AccuracyScoreProne = -8;
        public const float AccuracyScoreDarkness = -8;
        public const float AccuracyScoreCloseRange = 8;
        public const float AccuracyScorePerTargetSize = 8;
        public const float AccuracyScoreExecution = 40;

        public const float MaxDistForAccuracyBonus = 6;

        public const float RecoilPerDamageAmount = 0.15f;

    }

}
