// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TokenCharacterKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenCharacterKind
    {
        [EnumMember(Value = "letter")]
        Letter,
        [EnumMember(Value = "digit")]
        Digit,
        [EnumMember(Value = "whitespace")]
        Whitespace,
        [EnumMember(Value = "punctuation")]
        Punctuation,
        [EnumMember(Value = "symbol")]
        Symbol
    }
}