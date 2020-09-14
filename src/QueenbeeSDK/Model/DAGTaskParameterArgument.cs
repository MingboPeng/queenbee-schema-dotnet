/* 
 * Queenbee Recipe Schema
 *
 * Schema documentation for Queenbee Recipes
 *
 * The version of the OpenAPI document: 1.16.3
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


namespace QueenbeeSDK.Model
{
    /// <summary>
    /// Input argument for a DAG task.  The name must correspond to an input parameter from the template function the task refers to.
    /// </summary>
    [DataContract]
    public partial class DAGTaskParameterArgument :  IEquatable<DAGTaskParameterArgument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskParameterArgument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGTaskParameterArgument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskParameterArgument" /> class.
        /// </summary>
        /// <param name="name">Name of the argument variable (required).</param>
        /// <param name="from">The previous task or global workflow variable to pull this argument from.</param>
        /// <param name="value">The fixed value for this task argument.</param>
        public DAGTaskParameterArgument
        (
           string name, // Required parameters
           AnyOf<InputParameterReference,TaskParameterReference,ItemParameterReference> from= default, string value= default// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGTaskParameterArgument and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.From = from;
            this.Value = value;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Name of the argument variable
        /// </summary>
        /// <value>Name of the argument variable</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The previous task or global workflow variable to pull this argument from
        /// </summary>
        /// <value>The previous task or global workflow variable to pull this argument from</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        [JsonProperty("from")]
        public AnyOf<InputParameterReference,TaskParameterReference,ItemParameterReference> From { get; set; } 
        /// <summary>
        /// The fixed value for this task argument
        /// </summary>
        /// <value>The fixed value for this task argument</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        [JsonProperty("value")]
        public string Value { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGTaskParameterArgument {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.ConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAGTaskParameterArgument object</returns>
        public static DAGTaskParameterArgument FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGTaskParameterArgument>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGTaskParameterArgument object</returns>
        public DAGTaskParameterArgument DuplicateDAGTaskParameterArgument()
        {
            return FromJson(this.ToJson());
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DAGTaskParameterArgument);
        }

        /// <summary>
        /// Returns true if DAGTaskParameterArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGTaskParameterArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGTaskParameterArgument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
