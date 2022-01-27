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


namespace DigiKey.Api.Model
{
    /// <summary>
    /// PriceBreak of a product. Note that all pricing when keyword searching is cached catalog pricing.
    /// </summary>
    [DataContract]
    public partial class PriceBreak : IEquatable<PriceBreak>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceBreak" /> class.
        /// </summary>
        /// <param name="breakQuantity">Price tiers based on the available quantities of the product..</param>
        /// <param name="unitPrice">Price of a single unit of the product at this break..</param>
        /// <param name="totalPrice">Price of BreakQuantity units of the product..</param>
        public PriceBreak(int? breakQuantity = default(int?), double? unitPrice = default(double?), double? totalPrice = default(double?))
        {
            this.BreakQuantity = breakQuantity;
            this.UnitPrice = unitPrice;
            this.TotalPrice = totalPrice;
        }

        /// <summary>
        /// Price tiers based on the available quantities of the product.
        /// </summary>
        /// <value>Price tiers based on the available quantities of the product.</value>
        [DataMember(Name = "BreakQuantity", EmitDefaultValue = false)]
        public int? BreakQuantity { get; set; }

        /// <summary>
        /// Price of a single unit of the product at this break.
        /// </summary>
        /// <value>Price of a single unit of the product at this break.</value>
        [DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Price of BreakQuantity units of the product.
        /// </summary>
        /// <value>Price of BreakQuantity units of the product.</value>
        [DataMember(Name = "TotalPrice", EmitDefaultValue = false)]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceBreak {\n");
            sb.Append("  BreakQuantity: ").Append(BreakQuantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
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
            return this.Equals(input as PriceBreak);
        }

        /// <summary>
        /// Returns true if PriceBreak instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceBreak to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceBreak input)
        {
            if (input == null)
                return false;

            return
               (
                    this.BreakQuantity == input.BreakQuantity ||
                   (this.BreakQuantity != null &&
                    this.BreakQuantity.Equals(input.BreakQuantity))
                ) &&
               (
                    this.UnitPrice == input.UnitPrice ||
                   (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) &&
               (
                    this.TotalPrice == input.TotalPrice ||
                   (this.TotalPrice != null &&
                    this.TotalPrice.Equals(input.TotalPrice))
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
                if (this.BreakQuantity != null)
                    hashCode = hashCode * 59 + this.BreakQuantity.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.TotalPrice != null)
                    hashCode = hashCode * 59 + this.TotalPrice.GetHashCode();
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
