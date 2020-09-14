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
    /// Output parameter for a DAG task.  The name must correspond to an output parameter from the template function the task refers to.
    /// </summary>
    [DataContract]
    public partial class DAGTaskOutputParameter :  IEquatable<DAGTaskOutputParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskOutputParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAGTaskOutputParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DAGTaskOutputParameter" /> class.
        /// </summary>
        /// <param name="name">The name of the output variable (required).</param>
        public DAGTaskOutputParameter
        (
           string name// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DAGTaskOutputParameter and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The name of the output variable
        /// </summary>
        /// <value>The name of the output variable</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DAGTaskOutputParameter {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// <returns>DAGTaskOutputParameter object</returns>
        public static DAGTaskOutputParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAGTaskOutputParameter>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAGTaskOutputParameter object</returns>
        public DAGTaskOutputParameter DuplicateDAGTaskOutputParameter()
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
            return this.Equals(input as DAGTaskOutputParameter);
        }

        /// <summary>
        /// Returns true if DAGTaskOutputParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of DAGTaskOutputParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAGTaskOutputParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
