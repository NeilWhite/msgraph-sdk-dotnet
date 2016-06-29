// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Open Type Extension.
    /// </summary>
    [DataContract]
    public partial class OpenTypeExtension : Extension
    {
    
        /// <summary>
        /// Gets or sets extension name.
        /// </summary>
        [DataMember(Name = "extensionName", EmitDefaultValue = false, IsRequired = false)]
        public string ExtensionName { get; set; }
    
    }
}

