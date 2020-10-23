/* 
 * Queenbee Recipe Schema
 *
 * Documentation for Queenbee recipe schema.
 *
 * The version of the OpenAPI document: 1.6.6
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK.Model
{
    /// <summary>
    /// A Task Reference
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(TaskReference), "TaskReference")]
    [JsonSubtypes.KnownSubType(typeof(TaskFileReference), "TaskFileReference")]
    [JsonSubtypes.KnownSubType(typeof(TaskPathReference), "TaskPathReference")]
    [JsonSubtypes.KnownSubType(typeof(TaskFolderReference), "TaskFolderReference")]
    public partial class TaskReferenceBase : BaseReference,  IEquatable<TaskReferenceBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskReferenceBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskReferenceBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskReferenceBase" /> class.
        /// </summary>
        /// <param name="name">The name of the task to pull output data from. (required).</param>
        /// <param name="variable">The name of the variable. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        public TaskReferenceBase
        (
           string name, string variable, // Required parameters
            Dictionary<string, string> annotations= default // Optional parameters
        ) : base(annotations: annotations)// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for TaskReferenceBase and cannot be null");
            // to ensure "variable" is required (not null)
            this.Variable = variable ?? throw new ArgumentNullException("variable is a required property for TaskReferenceBase and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "_TaskReferenceBase";
        }
        
        /// <summary>
        /// The name of the task to pull output data from.
        /// </summary>
        /// <value>The name of the task to pull output data from.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; } 
        /// <summary>
        /// The name of the variable.
        /// </summary>
        /// <value>The name of the variable.</value>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public string Variable { get; set; } 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }  = "_TaskReferenceBase";
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskReferenceBase {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>TaskReferenceBase object</returns>
        public static TaskReferenceBase FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<TaskReferenceBase>(json, JsonSetting.AnyOfConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>TaskReferenceBase object</returns>
        public TaskReferenceBase DuplicateTaskReferenceBase()
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
            return this.Equals(input as TaskReferenceBase);
        }

        /// <summary>
        /// Returns true if TaskReferenceBase instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskReferenceBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskReferenceBase input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // Type (string) pattern
            Regex regexType = new Regex(@"^_TaskReferenceBase$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
