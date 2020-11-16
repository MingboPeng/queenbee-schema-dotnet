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
        /// Enum Recipe for value: recipe
        /// </summary>
        [EnumMember(Value = "recipe")]
        Recipe = 1,

        /// <summary>
        /// Enum Plugin for value: plugin
        /// </summary>
        [EnumMember(Value = "plugin")]
        Plugin = 2

    }

}
