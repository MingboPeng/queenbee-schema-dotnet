/* 
 * Queenbee Schema with Inheritance
 *
 * Documentation for Queenbee schema.
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
    /// An array output.
    /// </summary>
    [DataContract(Name = "StepArrayOutput")]
    public partial class StepArrayOutput : FunctionStringOutput, IEquatable<StepArrayOutput>, IValidatableObject
    {
        /// <summary>
        /// Type of items in this array. All the items in an array must be from the same type.
        /// </summary>
        /// <value>Type of items in this array. All the items in an array must be from the same type.</value>
        [DataMember(Name="items_type", EmitDefaultValue=false)]
        public ItemType ItemsType { get; set; } = ItemType.String;
        /// <summary>
        /// Initializes a new instance of the <see cref="StepArrayOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepArrayOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "StepArrayOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StepArrayOutput" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="itemsType">Type of items in this array. All the items in an array must be from the same type..</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="path">Path to the output artifact relative to where the function command is executed. (required).</param>
        public StepArrayOutput
        (
            string name, string path, List<object> value, // Required parameters
            Dictionary<string, string> annotations= default, string description= default, ItemType itemsType= ItemType.String // Optional parameters
        ) : base(name: name, annotations: annotations, description: description, path: path)// BaseClass
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for StepArrayOutput and cannot be null");
            this.ItemsType = itemsType;

            // Set non-required readonly properties with defaultValue
            this.Type = "StepArrayOutput";
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public List<object> Value { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "StepArrayOutput";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("StepArrayOutput:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ItemsType: ").Append(ItemsType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StepArrayOutput object</returns>
        public static StepArrayOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepArrayOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepArrayOutput object</returns>
        public virtual StepArrayOutput DuplicateStepArrayOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateStepArrayOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override FunctionStringOutput DuplicateFunctionStringOutput()
        {
            return DuplicateStepArrayOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepArrayOutput);
        }

        /// <summary>
        /// Returns true if StepArrayOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of StepArrayOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepArrayOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && base.Equals(input) && 
                (
                    this.ItemsType == input.ItemsType ||
                    (this.ItemsType != null &&
                    this.ItemsType.Equals(input.ItemsType))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ItemsType != null)
                    hashCode = hashCode * 59 + this.ItemsType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^StepArrayOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}