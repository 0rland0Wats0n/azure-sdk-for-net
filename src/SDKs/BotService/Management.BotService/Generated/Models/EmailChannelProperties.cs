// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the Email channel.
    /// </summary>
    public partial class EmailChannelProperties
    {
        /// <summary>
        /// Initializes a new instance of the EmailChannelProperties class.
        /// </summary>
        public EmailChannelProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailChannelProperties class.
        /// </summary>
        /// <param name="emailAddress">The email address</param>
        /// <param name="password">The password for the email address</param>
        /// <param name="isEnabled">Whether this channel is enabled for the
        /// bot</param>
        public EmailChannelProperties(string emailAddress, string password, bool isEnabled)
        {
            EmailAddress = emailAddress;
            Password = password;
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the email address
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the password for the email address
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets whether this channel is enabled for the bot
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EmailAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EmailAddress");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
