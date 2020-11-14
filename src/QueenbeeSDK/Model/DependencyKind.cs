/* 
 * Queenbee Queenbee Schema
 *
 * Documentation for Queenbee queenbee schema.
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK
{
    /// <summary>
    /// Dependency kind.
    /// </summary>
    /// <value>Dependency kind.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DependencyKind
    {
        /// <summary>
        /// Enum Recipekind for value: recipe_kind
        /// </summary>
        [EnumMember(Value = "recipe_kind")]
        Recipekind = 1,

        /// <summary>
        /// Enum Operatorkind for value: operator_kind
        /// </summary>
        [EnumMember(Value = "operator_kind")]
        Operatorkind = 2

    }

}