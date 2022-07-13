// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace ScpLockerPermissions
{
    using System.Linq;
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using MapGeneration.Distributors;

    /// <summary>
    /// General event handlers.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">The <see cref="Plugin{TConfig}"/> class reference.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnInteractingLocker(InteractingLockerEventArgs)"/>
        public void OnInteractingLocker(InteractingLockerEventArgs ev)
        {
            if (plugin.Config.CanOpenPedestal is not null &&
                ev.Locker is PedestalScpLocker &&
                ev.Player.Items.Any(item => plugin.Config.CanOpenPedestal.Contains(item.Type)))
                ev.IsAllowed = true;
        }
    }
}