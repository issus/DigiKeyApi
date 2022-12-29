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
    /// Products Category
    /// </summary>
    [DataContract]
    public partial class Category : IEquatable<Category>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="categoryId">Gets or Sets CategoryId.</param>
        /// <param name="parentId">The Id of the Partent Category if the given category is a child of another category.</param>
        /// <param name="name">Gets or Sets Name.</param>
        /// <param name="productCount">Gets or Sets ProductCount.</param>
        /// <param name="children">List of Child Categories.</param>
        public Category(int? categoryId = default(int?), int? parentId = default(int?), string name = default(string), long? productCount = default(long?), List<Category> children = default(List<Category>))
        {
            this.CategoryId = categoryId;
            this.ParentId = parentId;
            this.Name = name;
            this.ProductCount = productCount;
            this.Children = children;
        }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        /// <value>Gets or Sets CategoryId</value>
        [DataMember(Name = "CategoryId", EmitDefaultValue = false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// The Id of the Partent Category if the given category is a child of another category
        /// </summary>
        /// <value>The Id of the Partent Category if the given category is a child of another category</value>
        [DataMember(Name = "ParentId", EmitDefaultValue = false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <value>Gets or Sets Name</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProductCount
        /// </summary>
        /// <value>Gets or Sets ProductCount</value>
        [DataMember(Name = "ProductCount", EmitDefaultValue = false)]
        public long? ProductCount { get; set; }

        /// <summary>
        /// List of Child Categories
        /// </summary>
        /// <value>List of Child Categories</value>
        [DataMember(Name = "Children", EmitDefaultValue = false)]
        public List<Category> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductCount: ").Append(ProductCount).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return this.Equals(input as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="input">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category input)
        {
            if (input == null)
                return false;

            return
               (
                    this.CategoryId == input.CategoryId ||
                   (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) &&
               (
                    this.ParentId == input.ParentId ||
                   (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) &&
               (
                    this.Name == input.Name ||
                   (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
               (
                    this.ProductCount == input.ProductCount ||
                   (this.ProductCount != null &&
                    this.ProductCount.Equals(input.ProductCount))
                ) &&
               (
                    this.Children == input.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(input.Children)
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
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProductCount != null)
                    hashCode = hashCode * 59 + this.ProductCount.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
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
