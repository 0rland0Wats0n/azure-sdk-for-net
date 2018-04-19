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
    using System.Linq;

    /// <summary>
    /// The object that represents the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">Service provider:
        /// Microsoft.ServiceBus</param>
        /// <param name="resource">Resource on which the operation is
        /// performed: Invoice, etc.</param>
        /// <param name="operation">Operation type: Read, write, delete,
        /// etc.</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets service provider: Microsoft.ServiceBus
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; private set; }

        /// <summary>
        /// Gets resource on which the operation is performed: Invoice, etc.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; private set; }

        /// <summary>
        /// Gets operation type: Read, write, delete, etc.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; private set; }

    }
}
