﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

// Disable "missing XML comment" warning for the experimental package.
// While nice to have, documentation is not required for this experimental package.
#pragma warning disable CS1591

using System.Collections.Generic;

namespace Microsoft.MixedReality.Toolkit.Data
{
    /// <summary>
    /// Interface for processing dispatched commands related to the bound data.
    /// </summary>
    /// <remarks>
    /// When an interactable object is instantiated, particularly those in a data bound collection, there is generally a
    /// need to invoke commands, such as those initiated by a user action, that must be tied to the specific data that is bound to
    /// that instantiated object. In particular, some form of unique identifier must be provided that differentiates each item in a list of items.
    ///
    /// This interface provides such as mechanism.
    /// </remarks>
    public interface IDataController
    {
        /// <summary>
        /// Process the specified command with the specified bound datum and optional parameters.
        /// </summary>
        /// <param name="command">Which command to issue, as a string.</param>
        /// <param name="data">A data reference specifying the data to be acted upon, usually a unique identifier.</param>
        /// <param name="optionalParameters">Optional parameters, or null if none.</param>
        void ProcessCommand(string command, object data, Dictionary<string, object> optionalParameters);
    }
}
#pragma warning restore CS1591