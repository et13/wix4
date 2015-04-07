﻿//-----------------------------------------------------------------------
// <copyright file="RootPathProvider.cs" company="Outercurve Foundation">
//   Copyright (c) 2004, Outercurve Foundation.
//   This software is released under Microsoft Reciprocal License (MS-RL).
//   The license and further copyright text can be found in the file
//   LICENSE.TXT at the root directory of the distribution.
// </copyright>
// <summary>
//     Contains RootPathProvider to test update bundles in Burn.
// </summary>
//-----------------------------------------------------------------------

namespace WixTest.Tests.Burn.UpdateBundle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Nancy;

    public class RootPathProvider : IRootPathProvider
    {
        static public string RootPath { get; set; }
        public string GetRootPath()
        {
            return RootPathProvider.RootPath;
        }
    }
}
