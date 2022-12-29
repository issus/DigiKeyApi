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
    /// This DTO takes the input from the V3 KeywordSearch and creates the Search2.0 request
    /// </summary>
    [DataContract]
    public partial class KeywordSearchRequest : IEquatable<KeywordSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordSearchRequest" /> class.
        /// </summary>
        /// <param name="keywords">Keywords to search on. Can be a description, partial part number, manufacturer part number, or a Digi-Key part  number. Keywords are required unless the Filters.TaxonomyIds is populated. An Empty string can be used when searching with Filters.TaxonomyIds.</param>
        /// <param name="recordCount">Number of products to return between 1 and 50..</param>
        /// <param name="recordStartPosition">The starting index of the records returned. This is used to paginate beyond 50 results..</param>
        /// <param name="filters">filters.</param>
        /// <param name="sort">sort.</param>
        /// <param name="requestedQuantity">The quantity of the product you are looking to purchase. This is used with the SortByUnitPrice SortOption as price  varies at differing quantities..</param>
        /// <param name="searchOptions">Filters the search results by the included SearchOption..</param>
        /// <param name="excludeMarketPlaceProducts">Used to exclude MarkPlace products from search results. Default is false.</param>
        public KeywordSearchRequest(string keywords = "", int? recordCount = default(int?), int? recordStartPosition = default(int?), Filters filters = default(Filters), SortParameters sort = default(SortParameters), int? requestedQuantity = default(int?), List<SearchOption> searchOptions = default(List<SearchOption>), bool? excludeMarketPlaceProducts = default(bool?))
        {
            this.Keywords = keywords;
            this.RecordCount = recordCount;
            this.RecordStartPosition = recordStartPosition;
            this.Filters = filters;
            this.Sort = sort;
            this.RequestedQuantity = requestedQuantity;
            this.SearchOptions = searchOptions;
            this.ExcludeMarketPlaceProducts = excludeMarketPlaceProducts;
        }

        /// <summary>
        /// Keywords to search on. Can be a description, partial part number, manufacturer part number, or a Digi-Key part  number. Keywords are required unless the Filters.TaxonomyIds is populated. An Empty string can be used when searching with Filters.TaxonomyIds
        /// </summary>
        /// <value>Keywords to search on. Can be a description, partial part number, manufacturer part number, or a Digi-Key part  number. Keywords are required unless the Filters.TaxonomyIds is populated. An Empty string can be used when searching with Filters.TaxonomyIds</value>
        [DataMember(Name = "Keywords", EmitDefaultValue = false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Number of products to return between 1 and 50.
        /// </summary>
        /// <value>Number of products to return between 1 and 50.</value>
        [DataMember(Name = "RecordCount", EmitDefaultValue = false)]
        public int? RecordCount { get; set; }

        /// <summary>
        /// The starting index of the records returned. This is used to paginate beyond 50 results.
        /// </summary>
        /// <value>The starting index of the records returned. This is used to paginate beyond 50 results.</value>
        [DataMember(Name = "RecordStartPosition", EmitDefaultValue = false)]
        public int? RecordStartPosition { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "Filters", EmitDefaultValue = false)]
        public Filters Filters { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "Sort", EmitDefaultValue = false)]
        public SortParameters Sort { get; set; }

        /// <summary>
        /// The quantity of the product you are looking to purchase. This is used with the SortByUnitPrice SortOption as price  varies at differing quantities.
        /// </summary>
        /// <value>The quantity of the product you are looking to purchase. This is used with the SortByUnitPrice SortOption as price  varies at differing quantities.</value>
        [DataMember(Name = "RequestedQuantity", EmitDefaultValue = false)]
        public int? RequestedQuantity { get; set; }

        /// <summary>
        /// Filters the search results by the included SearchOption.
        /// </summary>
        /// <value>Filters the search results by the included SearchOption.</value>
        [DataMember(Name = "SearchOptions", EmitDefaultValue = false)]
        public List<SearchOption> SearchOptions { get; set; }

        /// <summary>
        /// Used to exclude MarkPlace products from search results. Default is false
        /// </summary>
        /// <value>Used to exclude MarkPlace products from search results. Default is false</value>
        [DataMember(Name = "ExcludeMarketPlaceProducts", EmitDefaultValue = false)]
        public bool? ExcludeMarketPlaceProducts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeywordSearchRequest {\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
            sb.Append("  RecordStartPosition: ").Append(RecordStartPosition).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  RequestedQuantity: ").Append(RequestedQuantity).Append("\n");
            sb.Append("  SearchOptions: ").Append(SearchOptions).Append("\n");
            sb.Append("  ExcludeMarketPlaceProducts: ").Append(ExcludeMarketPlaceProducts).Append("\n");
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
            return this.Equals(input as KeywordSearchRequest);
        }

        /// <summary>
        /// Returns true if KeywordSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of KeywordSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeywordSearchRequest input)
        {
            if (input == null)
                return false;

            return
               (
                    this.Keywords == input.Keywords ||
                   (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) &&
               (
                    this.RecordCount == input.RecordCount ||
                   (this.RecordCount != null &&
                    this.RecordCount.Equals(input.RecordCount))
                ) &&
               (
                    this.RecordStartPosition == input.RecordStartPosition ||
                   (this.RecordStartPosition != null &&
                    this.RecordStartPosition.Equals(input.RecordStartPosition))
                ) &&
               (
                    this.Filters == input.Filters ||
                   (this.Filters != null &&
                    this.Filters.Equals(input.Filters))
                ) &&
               (
                    this.Sort == input.Sort ||
                   (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) &&
               (
                    this.RequestedQuantity == input.RequestedQuantity ||
                   (this.RequestedQuantity != null &&
                    this.RequestedQuantity.Equals(input.RequestedQuantity))
                ) &&
               (
                    this.SearchOptions == input.SearchOptions ||
                    this.SearchOptions != null &&
                    this.SearchOptions.SequenceEqual(input.SearchOptions)
                ) &&
               (
                    this.ExcludeMarketPlaceProducts == input.ExcludeMarketPlaceProducts ||
                   (this.ExcludeMarketPlaceProducts != null &&
                    this.ExcludeMarketPlaceProducts.Equals(input.ExcludeMarketPlaceProducts))
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
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.RecordCount != null)
                    hashCode = hashCode * 59 + this.RecordCount.GetHashCode();
                if (this.RecordStartPosition != null)
                    hashCode = hashCode * 59 + this.RecordStartPosition.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.RequestedQuantity != null)
                    hashCode = hashCode * 59 + this.RequestedQuantity.GetHashCode();
                if (this.SearchOptions != null)
                    hashCode = hashCode * 59 + this.SearchOptions.GetHashCode();
                if (this.ExcludeMarketPlaceProducts != null)
                    hashCode = hashCode * 59 + this.ExcludeMarketPlaceProducts.GetHashCode();
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
