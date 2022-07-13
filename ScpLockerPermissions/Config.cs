// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace ScpLockerPermissions
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets items that can open scp pedestal lockers.
        /// </summary>
        [Description("Items that can open scp pedestal lockers.")]
        public List<ItemType> CanOpenPedestal { get; set; } = new()
        {
            ItemType.KeycardScientist,
            ItemType.KeycardGuard,
        };
    }
}