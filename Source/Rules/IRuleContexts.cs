﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Dolittle.Rules
{
    /// <summary>
    /// Defines a system for managing <see cref="IRuleContext">rule contexts</see>
    /// </summary>
    public interface IRuleContexts
    {
        /// <summary>
        /// Get a <see cref="IRuleContext"/> for a given instance
        /// </summary>
        /// <param name="instance">Instance to get for</param>
        /// <returns><see cref="IRuleContext"/> to use</returns>
        IRuleContext GetFor(object instance);
    }
}
