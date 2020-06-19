// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class FullBackupDetailsInternal
    {
        internal static FullBackupDetailsInternal DeserializeFullBackupDetailsInternal(JsonElement element)
        {
            string status = default;
            string statusDetails = default;
            KeyVaultServiceError error = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            string jobId = default;
            string azureStorageBlobContainerUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = KeyVaultServiceError.DeserializeKeyVaultServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageBlobContainerUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStorageBlobContainerUri = property.Value.GetString();
                    continue;
                }
            }
            return new FullBackupDetailsInternal(status, statusDetails, error, startTime, endTime, jobId, azureStorageBlobContainerUri);
        }
    }
}