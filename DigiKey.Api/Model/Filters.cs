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
    /// Filters to narrow down the search results based on parameters.
    /// </summary>
    [DataContract]
    public partial class Filters : IEquatable<Filters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filters" /> class.
        /// </summary>
        /// <param name="taxonomyIds">A collection of Taxonomy Ids to filter on. Ids can be found in the initial search response. A a full list ids can be found from the Search Categories endpoint.</param>
        /// <param name="manufacturerIds">A collection of Manufacturer Ids to filter on. Ids can be found in the initial search response. A a full list ids can be found from the Search Manufactures endpoint.</param>
        /// <param name="parametricFilters">A collection of ParametricFilters. A ParametricFilter consists of a ParameterId and a ValueId. Those Ids can also be found in the Search response..</param>
        public Filters(List<int> taxonomyIds = default(List<int>), List<int> manufacturerIds = default(List<int>), List<ParametricFilter> parametricFilters = default(List<ParametricFilter>))
        {
            this.TaxonomyIds = taxonomyIds;
            this.ManufacturerIds = manufacturerIds;
            this.ParametricFilters = parametricFilters;
        }

        /// <summary>
        /// A collection of Taxonomy Ids to filter on. Ids can be found in the initial search response. A a full list ids can be found from the Search Categories endpoint
        /// </summary>
        /// <value>A collection of Taxonomy Ids to filter on. Ids can be found in the initial search response. A a full list ids can be found from the Search Categories endpoint</value>
        [DataMember(Name = "TaxonomyIds", EmitDefaultValue = false)]
        public List<int> TaxonomyIds { get; set; }

        /// <summary>
        /// A collection of Manufacturer Ids to filter on. Ids can be found in the initial search response. A a full list ids can be found from the Search Manufactures endpoint
        /// </summary>
        /// <value>A collection of Manufacturer Ids to filter on. Ids can be found in the initial search response. A a full list ids can be found from the Search Manufactures endpoint</value>
        [DataMember(Name = "ManufacturerIds", EmitDefaultValue = false)]
        public List<int> ManufacturerIds { get; set; }

        /// <summary>
        /// A collection of ParametricFilters. A ParametricFilter consists of a ParameterId and a ValueId. Those Ids can also be found in the Search response.
        /// </summary>
        /// <value>A collection of ParametricFilters. A ParametricFilter consists of a ParameterId and a ValueId. Those Ids can also be found in the Search response.</value>
        [DataMember(Name = "ParametricFilters", EmitDefaultValue = false)]
        public List<ParametricFilter> ParametricFilters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Filters {\n");
            sb.Append("  TaxonomyIds: ").Append(TaxonomyIds).Append("\n");
            sb.Append("  ManufacturerIds: ").Append(ManufacturerIds).Append("\n");
            sb.Append("  ParametricFilters: ").Append(ParametricFilters).Append("\n");
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
            return this.Equals(input as Filters);
        }

        /// <summary>
        /// Returns true if Filters instances are equal
        /// </summary>
        /// <param name="input">Instance of Filters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Filters input)
        {
            if (input == null)
                return false;

            return
               (
                    this.TaxonomyIds == input.TaxonomyIds ||
                    this.TaxonomyIds != null &&
                    this.TaxonomyIds.SequenceEqual(input.TaxonomyIds)
                ) &&
               (
                    this.ManufacturerIds == input.ManufacturerIds ||
                    this.ManufacturerIds != null &&
                    this.ManufacturerIds.SequenceEqual(input.ManufacturerIds)
                ) &&
               (
                    this.ParametricFilters == input.ParametricFilters ||
                    this.ParametricFilters != null &&
                    this.ParametricFilters.SequenceEqual(input.ParametricFilters)
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
                if (this.TaxonomyIds != null)
                    hashCode = hashCode * 59 + this.TaxonomyIds.GetHashCode();
                if (this.ManufacturerIds != null)
                    hashCode = hashCode * 59 + this.ManufacturerIds.GetHashCode();
                if (this.ParametricFilters != null)
                    hashCode = hashCode * 59 + this.ParametricFilters.GetHashCode();
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
