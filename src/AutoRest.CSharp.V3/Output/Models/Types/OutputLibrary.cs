// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.V3.Input;
using AutoRest.CSharp.V3.Output.Builders;

namespace AutoRest.CSharp.V3.Output.Models.Types
{
    internal class OutputLibrary
    {
        private readonly CodeModel _codeModel;
        private readonly BuildContext _context;
        private Dictionary<Schema, ISchemaType>? _models;
        private Client[]? _clients;

        public OutputLibrary(CodeModel codeModel, BuildContext context)
        {
            _codeModel = codeModel;
            _context = context;
        }

        public IEnumerable<ISchemaType> Models => SchemaMap.Values;

        public Client[] Clients => _clients ??= BuildClients();

        public ISchemaType FindTypeForSchema(Schema schema)
        {
            return SchemaMap[schema];
        }

        private Dictionary<Schema, ISchemaType> SchemaMap => _models ??= BuildModels();

        private Client[] BuildClients()
        {
            var clientBuilder = new ClientBuilder(_context);

            return _codeModel.OperationGroups.Select(clientBuilder.BuildClient).ToArray();
        }

        private Dictionary<Schema, ISchemaType> BuildModels()
        {
            var allSchemas = _codeModel.Schemas.Choices.Cast<Schema>()
                .Concat(_codeModel.Schemas.SealedChoices)
                .Concat(_codeModel.Schemas.Objects);

            return allSchemas.ToDictionary(schema => schema, BuildModel);
        }

        private ISchemaType BuildModel(Schema schema) => schema switch
        {
            SealedChoiceSchema sealedChoiceSchema => (ISchemaType)new EnumType(sealedChoiceSchema, _context),
            ChoiceSchema choiceSchema => new EnumType(choiceSchema, _context),
            ObjectSchema objectSchema => new ObjectType(objectSchema, _context),
            _ => throw new NotImplementedException()
        };
    }
}