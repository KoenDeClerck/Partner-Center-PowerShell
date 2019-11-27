// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// An InvoiceSection resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InvoiceSection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the InvoiceSection class.
        /// </summary>
        public InvoiceSection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InvoiceSection class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The name of the InvoiceSection.</param>
        public InvoiceSection(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the InvoiceSection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

    }
}