﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using AutoRest.CSharp.V3.Pipeline.Generated;

namespace AutoRest.CSharp.V3.ClientModel
{
    internal class ClientEnum : ClientModel, ISchemaTypeProvider
    {
        public ClientEnum(Schema schema, string name, IEnumerable<ClientEnumValue> values, bool isStringBased = false)
        {
            Schema = schema;
            Name = name;
            Values = new List<ClientEnumValue>(values);
            IsStringBased = isStringBased;
        }

        public bool IsStringBased { get; }
        public Schema Schema { get; }
        public override string Name { get; }
        public IList<ClientEnumValue> Values { get; }
    }
}
