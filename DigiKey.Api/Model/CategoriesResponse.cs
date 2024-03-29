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
    /// Response model for Categories call.
    /// </summary>
    [DataContract]
    public partial class CategoriesResponse : IEquatable<CategoriesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesResponse" /> class.
        /// </summary>
        /// <param name="productCount">Count of Products.</param>
        /// <param name="categories">List of Categories.</param>
        public CategoriesResponse(int? productCount = default(int?), List<Category> categories = default(List<Category>))
        {
            this.ProductCount = productCount;
            this.Categories = categories;
        }

        /// <summary>
        /// Count of Products
        /// </summary>
        /// <value>Count of Products</value>
        [DataMember(Name = "ProductCount", EmitDefaultValue = false)]
        public int? ProductCount { get; set; }

        /// <summary>
        /// List of Categories
        /// </summary>
        /// <value>List of Categories</value>
        [DataMember(Name = "Categories", EmitDefaultValue = false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoriesResponse {\n");
            sb.Append("  ProductCount: ").Append(ProductCount).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(input as CategoriesResponse);
        }

        /// <summary>
        /// Returns true if CategoriesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoriesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoriesResponse input)
        {
            if (input == null)
                return false;

            return
               (
                    this.ProductCount == input.ProductCount ||
                   (this.ProductCount != null &&
                    this.ProductCount.Equals(input.ProductCount))
                ) &&
               (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                if (this.ProductCount != null)
                    hashCode = hashCode * 59 + this.ProductCount.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
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
