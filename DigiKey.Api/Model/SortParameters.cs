using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;


namespace OriginalCircuit.DigiKey.Api.Model
{
    /// <summary>
    /// Sort on the specified field in ascending or descending order.
    /// </summary>
    [DataContract]
    public partial class SortParameters : IEquatable<SortParameters>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SortOption
        /// </summary>
        [DataMember(Name = "SortOption", EmitDefaultValue = false)]
        public SortOption? SortOption { get; set; }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "Direction", EmitDefaultValue = false)]
        public SortDirection? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SortParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortParameters" /> class.
        /// </summary>
        /// <param name="sortOption">sortOption(required).</param>
        /// <param name="direction">direction(required).</param>
        /// <param name="sortParameterId">The ParameterId of the parameter to sort on. The ParameterId can be found in the Search response. This is only used with SortByParameter..</param>
        public SortParameters(SortOption? sortOption = default(SortOption), SortDirection? direction = default(SortDirection), int? sortParameterId = default(int?))
        {
            // to ensure "sortOption" is required(not null)
            if (sortOption == null)
            {
                throw new InvalidDataException("sortOption is a required property for SortParameters and cannot be null");
            }
            else
            {
                this.SortOption = sortOption;
            }
            // to ensure "direction" is required(not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for SortParameters and cannot be null");
            }
            else
            {
                this.Direction = direction;
            }
            this.SortParameterId = sortParameterId;
        }



        /// <summary>
        /// The ParameterId of the parameter to sort on. The ParameterId can be found in the Search response. This is only used with SortByParameter.
        /// </summary>
        /// <value>The ParameterId of the parameter to sort on. The ParameterId can be found in the Search response. This is only used with SortByParameter.</value>
        [DataMember(Name = "SortParameterId", EmitDefaultValue = false)]
        public int? SortParameterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SortParameters {\n");
            sb.Append("  SortOption: ").Append(SortOption).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  SortParameterId: ").Append(SortParameterId).Append("\n");
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
            return this.Equals(input as SortParameters);
        }

        /// <summary>
        /// Returns true if SortParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SortParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortParameters input)
        {
            if (input == null)
                return false;

            return
               (
                    this.SortOption == input.SortOption ||
                   (this.SortOption != null &&
                    this.SortOption.Equals(input.SortOption))
                ) &&
               (
                    this.Direction == input.Direction ||
                   (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) &&
               (
                    this.SortParameterId == input.SortParameterId ||
                   (this.SortParameterId != null &&
                    this.SortParameterId.Equals(input.SortParameterId))
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
                if (this.SortOption != null)
                    hashCode = hashCode * 59 + this.SortOption.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.SortParameterId != null)
                    hashCode = hashCode * 59 + this.SortParameterId.GetHashCode();
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
