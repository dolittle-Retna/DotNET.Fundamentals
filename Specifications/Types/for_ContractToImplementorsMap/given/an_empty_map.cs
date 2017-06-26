﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Machine.Specifications;

namespace doLittle.Types.Specs.for_ContractToImplementorsMap.given
{
    public class an_empty_map
    {
        protected static ContractToImplementorsMap map;

        Establish context = () => map = new ContractToImplementorsMap();
    }
}