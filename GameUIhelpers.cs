﻿// <copyright file="GameUIhelpers.cs" company="lokinmodar">
// Copyright (c) lokinmodar. All rights reserved.
// Licensed under the Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International Public License license.
// </copyright>

using System.Collections.Generic;
using System.Linq;

using Lumina.Excel;

using Lumina.Excel.Sheets;

namespace Echoglossian
{
  public partial class Echoglossian
  {
    public HashSet<string> UiElementsLabels = new();

    public void ParseUi()
    {
      ExcelSheet<Addon> uiStuffz = DManager.GetExcelSheet<Addon>(ClientStateInterface.ClientLanguage);

      var addonList = uiStuffz?.ToList();

      PluginLog.Debug($"Addon list: {uiStuffz?.Count.ToString()}");
      if (uiStuffz != null)
      {
        foreach (var a in uiStuffz)
        {
          this.UiElementsLabels.Add(a.Text.ToString());
          PluginLog.Debug($"Sheet row: {a.RowId}: {a.Text.ToString()}");
        }
      }
    }
  }
}
