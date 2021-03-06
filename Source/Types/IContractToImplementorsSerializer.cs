/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace Dolittle.Types
{
    /// <summary>
    /// Defines a serializes that is capable of serializing <see cref="IContractToImplementorsMap"/>
    /// to and from <see cref="string"/>
    /// </summary>
    public interface IContractToImplementorsSerializer
    {
        /// <summary>
        /// Serializes a map represented as a dictionary of enumerables to a string
        /// </summary>
        /// <param name="map">Map to serialize</param>
        /// <returns>Serialized string</returns>
        string SerializeMap(IDictionary<Type, IEnumerable<Type>> map);

        /// <summary>
        /// Serializes a collection of types represented used in the mapping contractors
        /// </summary>
        /// <param name="types">Types to serialize</param>
        /// <returns>Serialized string</returns>
        string SerializeTypes(IEnumerable<Type> types);

        /// <summary>
        /// Deserializes a map from a string into a dictionary of enumerables
        /// </summary>
        /// <param name="serializedMap">Serialized string to deserialize</param>
        /// <returns>Map</returns>
        IDictionary<Type, IEnumerable<Type>> DeserializeMap(string serializedMap);

        /// <summary>
        /// Deserializes a map from a string into a dictionary of enumerables
        /// </summary>
        /// <param name="serializedTypes">Serialized string to deserialize</param>
        /// <returns>Types</returns>
        IEnumerable<Type> DeserializeTypes(string serializedTypes);
    }
}