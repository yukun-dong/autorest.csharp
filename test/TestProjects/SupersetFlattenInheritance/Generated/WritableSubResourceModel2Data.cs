// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the WritableSubResourceModel2 data model. </summary>
    public partial class WritableSubResourceModel2Data
    {
        /// <summary> Initializes a new instance of WritableSubResourceModel2Data. </summary>
        public WritableSubResourceModel2Data()
        {
        }

        /// <summary> Initializes a new instance of WritableSubResourceModel2Data. </summary>
        /// <param name="id"></param>
        /// <param name="idPropertiesId"></param>
        /// <param name="foo"></param>
        internal WritableSubResourceModel2Data(string id, string idPropertiesId, string foo)
        {
            Id = id;
            IdPropertiesId = idPropertiesId;
            Foo = foo;
        }

        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> Gets or sets the id properties id. </summary>
        public string IdPropertiesId { get; set; }
        /// <summary> Gets or sets the foo. </summary>
        public string Foo { get; set; }
    }
}