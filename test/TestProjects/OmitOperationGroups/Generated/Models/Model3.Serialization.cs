// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace OmitOperationGroups.Models
{
    public partial class Model3 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static Model3 DeserializeModel3(JsonElement element)
        {
            Optional<string> f = default;
            Optional<string> g = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("f"))
                {
                    f = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("g"))
                {
                    g = property.Value.GetString();
                    continue;
                }
            }
            return new Model3(f.Value, g.Value);
        }
    }
}
