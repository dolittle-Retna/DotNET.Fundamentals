/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Dolittle.DependencyInversion.Strategies
{
    /// <summary>
    /// Represents an <see cref="IActivationStrategy"/> that gets activated through a callback to a <see cref="System.Type"/>
    /// </summary>
    public class TypeCallback : IActivationStrategy
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeCallback"/>
        /// </summary>
        /// <param name="target">The callback target</param>
        public TypeCallback(Func<System.Type> target)
        {
            Target = target;
        }

        /// <summary>
        /// Gets the target
        /// </summary>
        public Func<System.Type> Target {  get; }

        /// <inheritdoc/>
        public System.Type GetTargetType()
        {
            return Target.Method.ReturnType;
        }
    }
}