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
    /// Defines values for EncodingCaptureDescription.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncodingCaptureDescription
    {
        [EnumMember(Value = "Avro")]
        Avro,
        [EnumMember(Value = "AvroDeflate")]
        AvroDeflate
    }
    internal static class EncodingCaptureDescriptionEnumExtension
    {
        internal static string ToSerializedValue(this EncodingCaptureDescription? value)
        {
            return value == null ? null : ((EncodingCaptureDescription)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EncodingCaptureDescription value)
        {
            switch( value )
            {
                case EncodingCaptureDescription.Avro:
                    return "Avro";
                case EncodingCaptureDescription.AvroDeflate:
                    return "AvroDeflate";
            }
            return null;
        }

        internal static EncodingCaptureDescription? ParseEncodingCaptureDescription(this string value)
        {
            switch( value )
            {
                case "Avro":
                    return EncodingCaptureDescription.Avro;
                case "AvroDeflate":
                    return EncodingCaptureDescription.AvroDeflate;
            }
            return null;
        }
    }
}
