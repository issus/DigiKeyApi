using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;


namespace OriginalCircuit.DigiKey.Api.Model
{
    /// <summary>
    /// Error with API input.
    /// </summary>
    [DataContract]
    public partial class ApiValidationError : IEquatable<ApiValidationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiValidationError" /> class.
        /// </summary>
        /// <param name="field">The field that generated the error..</param>
        /// <param name="message">The error message that was generated. This often explains how to fix your API input to be valid..</param>
        public ApiValidationError(string field = default(string), string message = default(string))
        {
            this.Field = field;
            this.Message = message;
        }

        /// <summary>
        /// The field that generated the error.
        /// </summary>
        /// <value>The field that generated the error.</value>
        [DataMember(Name = "Field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// The error message that was generated. This often explains how to fix your API input to be valid.
        /// </summary>
        /// <value>The error message that was generated. This often explains how to fix your API input to be valid.</value>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiValidationError {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiValidationError);
        }

        /// <summary>
        /// Returns true if ApiValidationError instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiValidationError input)
        {
            if (input == null)
                return false;

            return
               (
                    this.Field == input.Field ||
                   (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) &&
               (
                    this.Message == input.Message ||
                   (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
