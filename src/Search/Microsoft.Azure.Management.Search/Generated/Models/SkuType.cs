// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuType
    {
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "standard2")]
        Standard2
    }
}
