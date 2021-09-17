﻿// <copyright file="Config.cs" company="lokinmodar">
// Copyright (c) lokinmodar. All rights reserved.
// Licensed under the Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International Public License license.
// </copyright>

using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Dalamud.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace Echoglossian
{
  public class Config : IPluginConfiguration
  {
    public int Lang { get; set; } = 16;

    public int FontSize = 20;

    public bool ShowInCutscenes = true;

    public bool TranslateBattleTalk = true;
    public bool TranslateTalk = true;
    public bool TranslateToast = true;
    public bool TranslateNPCNames = true;
    public bool TranslateErrorToast = true;
    public bool TranslateQuestToast = true;
    public bool TranslateAreaToast = true;
    public bool TranslateClassChangeToast = true;
    public bool TranslateScreenInfoToast = true;
    public bool TranslateYesNoScreen = true;
    public bool TranslateCutSceneSelectString = true;
    public bool TranslateSelectString = true;
    public bool TranslateSelectOk = true;
    public bool TranslateToDoList = true;
    public bool UseImGui = false;

    public int ChosenTransEngine = 0;

    public Vector2 ImGuiWindowPosCorrection = Vector2.Zero;
    public Vector2 ImGuiToastWindowPosCorrection = Vector2.Zero;
    public float ImGuiWindowWidthMult = 0.85f;
    public float ImGuiToastWindowWidthMult = 1.20f;
    public Vector4 OverlayTextColor = Vector4.Zero;

    public int Version { get; set; } = 0;
  }
}