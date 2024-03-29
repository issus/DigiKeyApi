/* 
 * PartSearch Api
 *
 * Search for products and retrieve details and pricing.
 *
 * OpenAPI spec version: v3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;


namespace OriginalCircuit.DigiKey.Api.Model
{
    /// <summary>
    /// Combination of a parameter Id and Value Id. Used for filtering search results.
    /// </summary>
    [DataContract]
    public partial class PidVid : IEquatable<PidVid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PidVid" /> class.
        /// </summary>
        /// <param name="parameterId">The Id of the parameter..</param>
        /// <param name="valueId">The Id of the value..</param>
        /// <param name="_parameter">The name of the parameter..</param>
        /// <param name="value">The name of the value..</param>
        public PidVid(int? parameterId = default(int?), string valueId = default(string), string _parameter = default(string), string value = default(string))
        {
            this.ParameterId = parameterId;
            this.ValueId = valueId;
            this.Parameter = _parameter;
            this.Value = value;
        }

        /// <summary>
        /// The Id of the parameter.
        /// </summary>
        /// <value>The Id of the parameter.</value>
        [DataMember(Name = "ParameterId", EmitDefaultValue = false)]
        public int? ParameterId { get; set; }

        /// <summary>
        /// The Id of the value.
        /// </summary>
        /// <value>The Id of the value.</value>
        [DataMember(Name = "ValueId", EmitDefaultValue = false)]
        public string ValueId { get; set; }

        /// <summary>
        /// The name of the parameter.
        /// </summary>
        /// <value>The name of the parameter.</value>
        [DataMember(Name = "Parameter", EmitDefaultValue = false)]
        public string Parameter { get; set; }

        /// <summary>
        /// The name of the value.
        /// </summary>
        /// <value>The name of the value.</value>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PidVid {\n");
            sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
            sb.Append("  ValueId: ").Append(ValueId).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PidVid);
        }

        /// <summary>
        /// Returns true if PidVid instances are equal
        /// </summary>
        /// <param name="input">Instance of PidVid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PidVid input)
        {
            if (input == null)
                return false;

            return
               (
                    this.ParameterId == input.ParameterId ||
                   (this.ParameterId != null &&
                    this.ParameterId.Equals(input.ParameterId))
                ) &&
               (
                    this.ValueId == input.ValueId ||
                   (this.ValueId != null &&
                    this.ValueId.Equals(input.ValueId))
                ) &&
               (
                    this.Parameter == input.Parameter ||
                   (this.Parameter != null &&
                    this.Parameter.Equals(input.Parameter))
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
                if (this.ParameterId != null)
                    hashCode = hashCode * 59 + this.ParameterId.GetHashCode();
                if (this.ValueId != null)
                    hashCode = hashCode * 59 + this.ValueId.GetHashCode();
                if (this.Parameter != null)
                    hashCode = hashCode * 59 + this.Parameter.GetHashCode();
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
