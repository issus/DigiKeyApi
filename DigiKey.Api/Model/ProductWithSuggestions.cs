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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace OriginalCircuit.DigiKey.Api.Model
{
    /// <summary>
    /// ProductWithSuggestions
    /// </summary>
    [DataContract]
    public partial class ProductWithSuggestions : IEquatable<ProductWithSuggestions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductWithSuggestions" /> class.
        /// </summary>
        /// <param name="product">product.</param>
        /// <param name="suggestedProducts">suggestedProducts.</param>
        public ProductWithSuggestions(ProductDetails product = default(ProductDetails), List<Product> suggestedProducts = default(List<Product>))
        {
            this.Product = product;
            this.SuggestedProducts = suggestedProducts;
        }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "Product", EmitDefaultValue = false)]
        public ProductDetails Product { get; set; }

        /// <summary>
        /// Gets or Sets SuggestedProducts
        /// </summary>
        [DataMember(Name = "SuggestedProducts", EmitDefaultValue = false)]
        public List<Product> SuggestedProducts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductWithSuggestions {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  SuggestedProducts: ").Append(SuggestedProducts).Append("\n");
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
            return this.Equals(input as ProductWithSuggestions);
        }

        /// <summary>
        /// Returns true if ProductWithSuggestions instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductWithSuggestions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductWithSuggestions input)
        {
            if (input == null)
                return false;

            return
               (
                    this.Product == input.Product ||
                   (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) &&
               (
                    this.SuggestedProducts == input.SuggestedProducts ||
                    this.SuggestedProducts != null &&
                    this.SuggestedProducts.SequenceEqual(input.SuggestedProducts)
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
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.SuggestedProducts != null)
                    hashCode = hashCode * 59 + this.SuggestedProducts.GetHashCode();
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
