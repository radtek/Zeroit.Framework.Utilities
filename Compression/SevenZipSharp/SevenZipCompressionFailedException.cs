﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 01-01-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 01-01-2019
// ***********************************************************************
// <copyright file="SevenZipCompressionFailedException.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Runtime.Serialization;

namespace Zeroit.Framework.Utilities.SevenZip
{
  [Serializable]
  public class SevenZipCompressionFailedException : SevenZipException
  {
    public const string DefaultMessage = "The compression has failed for an unknown reason with code ";

    public SevenZipCompressionFailedException()
      : base("The compression has failed for an unknown reason with code ")
    {
    }

    public SevenZipCompressionFailedException(string message)
      : base("The compression has failed for an unknown reason with code ", message)
    {
    }

    public SevenZipCompressionFailedException(string message, Exception inner)
      : base("The compression has failed for an unknown reason with code ", message, inner)
    {
    }

    protected SevenZipCompressionFailedException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }
  }
}
