﻿using UnityEngine;
using Verse;

// ReSharper disable All

namespace RedistHeat
{
    public static class ResourceBank
    {
        // ===== AirNet.xml ===== //
        public static string CurrentConnectionChannel = "RedistHeat_CurrentConnectionChannel";
        public static string CurrentConnectedNetTemp  = "RedistHeat_CurrentConnectedNetTemp".Translate();
        public static string LowerNetTemperature      = "RedistHeat_LowerNetTemperature".Translate();
        public static string UpperNetTemperature      = "RedistHeat_UpperNetTemperature".Translate();
        public static string CycleLayerLabel          = "RedistHeat_CycleLayerLabel".Translate();
        public static string CycleLayerDesc           = "RedistHeat_CycleLayerDesc".Translate();
        public static string CycleLayerMote           = "RedistHeat_CycleLayerMote";

        // ===== TempControl.xml ===== //
        public static string StringState              = "RedistHeat_State".Translate();
        public static string StringWorking            = "RedistHeat_Working".Translate();
        public static string StringNotWorking         = "RedistHeat_NotWorking".Translate();

        public static string StringWorkingDucts       = "RedistHeat_WorkingDucts".Translate();

        public static string StringExposeDuct         = "RedistHeat_MustExposeDuct".Translate();
        public static string StringExposeBoth         = "MustPlaceVentWithFreeSpaces".Translate();
        public static string StringExposeHot          = "RedistHeat_MustExposeHotSide".Translate();
        public static string StringExposeCold         = "RedistHeat_MustExposeColdSide".Translate();
        public static string StringAttachToCooler     = "RedistHeat_MustPlaceBackSideOnCooler".Translate();

        // ==== Vent.xml ==== //
        public static string StringToggleAirflowLabel = "RedistHeat_CommandToggleLockLabel".Translate();
        public static string StringToggleAirflowDesc  = "RedistHeat_CommandToggleLockDesc".Translate();

        // === Gizmo icons === //
        public static readonly Texture2D UILock       = ContentFinder< Texture2D >.Get( "UI/Commands/Forbidden", true );
        public static readonly Texture2D UILower      = ContentFinder< Texture2D >.Get( "UI/Commands/Lower", true );
        public static readonly Texture2D UIUpper      = ContentFinder< Texture2D >.Get( "UI/Commands/Upper", true );
    }
}