// <auto-generated>
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for KeyType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeyType
    {
        [EnumMember(Value = "PrimaryKey")]
        PrimaryKey,
        [EnumMember(Value = "SecondaryKey")]
        SecondaryKey
    }
    internal static class KeyTypeEnumExtension
    {
        internal static string ToSerializedValue(this KeyType? value)
        {
            return value == null ? null : ((KeyType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this KeyType value)
        {
            switch( value )
            {
                case KeyType.PrimaryKey:
                    return "PrimaryKey";
                case KeyType.SecondaryKey:
                    return "SecondaryKey";
            }
            return null;
        }

        internal static KeyType? ParseKeyType(this string value)
        {
            switch( value )
            {
                case "PrimaryKey":
                    return KeyType.PrimaryKey;
                case "SecondaryKey":
                    return KeyType.SecondaryKey;
            }
            return null;
        }
    }
}
