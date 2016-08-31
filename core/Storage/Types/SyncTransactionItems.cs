﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SyncTransactionItems.cs" company="SoftChains">
//   Copyright 2016 Dan Gershony
//   //  Licensed under the MIT license. See LICENSE file in the project root for full license information.
//   //  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
//   //  EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
//   //  OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Nako.Storage.Types
{
    #region Using Directives

    using System.Collections.Generic;

    #endregion

    public class SyncTransactionItems
    {
        #region Public Properties

        public List<SyncTransactionItemInput> Inputs { get; set; }

        public List<SyncTransactionItemOutput> Outputs { get; set; }

        #endregion
    }
}