// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the SubResourceModel1 data model. </summary>
    public partial class SubResourceModel1Data : SubResource
    {
        /// <summary> Initializes a new instance of SubResourceModel1Data. </summary>
        public SubResourceModel1Data()
        {
        }

        /// <summary> Initializes a new instance of SubResourceModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="foo"></param>
        internal SubResourceModel1Data(string id, string foo) : base(id)
        {
            Foo = foo;
        }

        public string Foo { get; set; }
    }
}
