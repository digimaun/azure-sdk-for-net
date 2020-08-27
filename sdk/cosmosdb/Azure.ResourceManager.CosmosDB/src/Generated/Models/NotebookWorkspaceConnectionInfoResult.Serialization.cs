// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class NotebookWorkspaceConnectionInfoResult
    {
        internal static NotebookWorkspaceConnectionInfoResult DeserializeNotebookWorkspaceConnectionInfoResult(JsonElement element)
        {
            Optional<string> authToken = default;
            Optional<string> notebookServerEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authToken"))
                {
                    authToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notebookServerEndpoint"))
                {
                    notebookServerEndpoint = property.Value.GetString();
                    continue;
                }
            }
            return new NotebookWorkspaceConnectionInfoResult(authToken.Value, notebookServerEndpoint.Value);
        }
    }
}