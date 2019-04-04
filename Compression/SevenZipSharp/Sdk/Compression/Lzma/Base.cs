﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 01-01-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 01-01-2019
// ***********************************************************************
// <copyright file="Base.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.Utilities.SevenZip.Sdk.Compression.Lzma
{
  internal abstract class Base
  {
    public const uint kAlignMask = 15;
    public const uint kAlignTableSize = 16;
    public const int kDicLogSizeMin = 0;
    public const uint kEndPosModelIndex = 14;
    public const uint kMatchMaxLen = 273;
    public const uint kMatchMinLen = 2;
    public const int kNumAlignBits = 4;
    public const uint kNumFullDistances = 128;
    public const int kNumHighLenBits = 8;
    public const uint kNumLenSymbols = 272;
    public const uint kNumLenToPosStates = 4;
    public const int kNumLenToPosStatesBits = 2;
    public const uint kNumLitContextBitsMax = 8;
    public const uint kNumLitPosStatesBitsEncodingMax = 4;
    public const int kNumLowLenBits = 3;
    public const uint kNumLowLenSymbols = 8;
    public const int kNumMidLenBits = 3;
    public const uint kNumMidLenSymbols = 8;
    public const uint kNumPosModels = 10;
    public const int kNumPosSlotBits = 6;
    public const int kNumPosStatesBitsEncodingMax = 4;
    public const int kNumPosStatesBitsMax = 4;
    public const uint kNumPosStatesEncodingMax = 16;
    public const uint kNumPosStatesMax = 16;
    public const uint kNumRepDistances = 4;
    public const uint kNumStates = 12;
    public const uint kStartPosModelIndex = 4;

    public static uint GetLenToPosState(uint len)
    {
      len -= 2U;
      if (len < 4U)
        return len;
      return 3;
    }

    public struct State
    {
      public uint Index;

      public void Init()
      {
        this.Index = 0U;
      }

      public void UpdateChar()
      {
        if (this.Index < 4U)
          this.Index = 0U;
        else if (this.Index < 10U)
          this.Index -= 3U;
        else
          this.Index -= 6U;
      }

      public void UpdateMatch()
      {
        this.Index = this.Index < 7U ? 7U : 10U;
      }

      public void UpdateRep()
      {
        this.Index = this.Index < 7U ? 8U : 11U;
      }

      public void UpdateShortRep()
      {
        this.Index = this.Index < 7U ? 9U : 11U;
      }

      public bool IsCharState()
      {
        return this.Index < 7U;
      }
    }
  }
}
