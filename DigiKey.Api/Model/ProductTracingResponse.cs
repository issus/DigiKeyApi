/* 
 * ProductTracing Api
 *
 * Search for products and retrieve details and pricing.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;

namespace OriginalCircuit.DigiKey.Api.Model
{
    /// <summary>
    /// ProductTracingResponse
    /// </summary>
    [DataContract]
    public partial class ProductTracingResponse :  IEquatable<ProductTracingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTracingResponse" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="customerPurchaseOrder">customerPurchaseOrder.</param>
        /// <param name="customerReference">customerReference.</param>
        /// <param name="countryOfOrigin">countryOfOrigin.</param>
        /// <param name="dateCode">dateCode.</param>
        /// <param name="detailId">detailId.</param>
        /// <param name="invoiceId">invoiceId.</param>
        /// <param name="lotCode">lotCode.</param>
        /// <param name="manufacturerProductNumber">manufacturerProductNumber.</param>
        /// <param name="digiKeyProductNumber">digiKeyProductNumber.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="salesOrderId">salesOrderId.</param>
        /// <param name="tracingId">tracingId.</param>
        public ProductTracingResponse(string description = default(string), string customerPurchaseOrder = default(string), string customerReference = default(string), string countryOfOrigin = default(string), string dateCode = default(string), int? detailId = default(int?), long? invoiceId = default(long?), string lotCode = default(string), string manufacturerProductNumber = default(string), string digiKeyProductNumber = default(string), int? quantity = default(int?), long? salesOrderId = default(long?), string tracingId = default(string))
        {
            this.Description = description;
            this.CustomerPurchaseOrder = customerPurchaseOrder;
            this.CustomerReference = customerReference;
            this.CountryOfOrigin = countryOfOrigin;
            this.DateCode = dateCode;
            this.DetailId = detailId;
            this.InvoiceId = invoiceId;
            this.LotCode = lotCode;
            this.ManufacturerProductNumber = manufacturerProductNumber;
            this.DigiKeyProductNumber = digiKeyProductNumber;
            this.Quantity = quantity;
            this.SalesOrderId = salesOrderId;
            this.TracingId = tracingId;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CustomerPurchaseOrder
        /// </summary>
        [DataMember(Name="CustomerPurchaseOrder", EmitDefaultValue=false)]
        public string CustomerPurchaseOrder { get; set; }

        /// <summary>
        /// Gets or Sets CustomerReference
        /// </summary>
        [DataMember(Name="CustomerReference", EmitDefaultValue=false)]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or Sets CountryOfOrigin
        /// </summary>
        [DataMember(Name="CountryOfOrigin", EmitDefaultValue=false)]
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// Gets or Sets DateCode
        /// </summary>
        [DataMember(Name="DateCode", EmitDefaultValue=false)]
        public string DateCode { get; set; }

        /// <summary>
        /// Gets or Sets DetailId
        /// </summary>
        [DataMember(Name="DetailId", EmitDefaultValue=false)]
        public int? DetailId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceId
        /// </summary>
        [DataMember(Name="InvoiceId", EmitDefaultValue=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets LotCode
        /// </summary>
        [DataMember(Name="LotCode", EmitDefaultValue=false)]
        public string LotCode { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerProductNumber
        /// </summary>
        [DataMember(Name="ManufacturerProductNumber", EmitDefaultValue=false)]
        public string ManufacturerProductNumber { get; set; }

        /// <summary>
        /// Gets or Sets DigiKeyProductNumber
        /// </summary>
        [DataMember(Name="DigiKeyProductNumber", EmitDefaultValue=false)]
        public string DigiKeyProductNumber { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets SalesOrderId
        /// </summary>
        [DataMember(Name="SalesOrderId", EmitDefaultValue=false)]
        public long? SalesOrderId { get; set; }

        /// <summary>
        /// Gets or Sets TracingId
        /// </summary>
        [DataMember(Name="TracingId", EmitDefaultValue=false)]
        public string TracingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductTracingResponse {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CustomerPurchaseOrder: ").Append(CustomerPurchaseOrder).Append("\n");
            sb.Append("  CustomerReference: ").Append(CustomerReference).Append("\n");
            sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append("\n");
            sb.Append("  DateCode: ").Append(DateCode).Append("\n");
            sb.Append("  DetailId: ").Append(DetailId).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  LotCode: ").Append(LotCode).Append("\n");
            sb.Append("  ManufacturerProductNumber: ").Append(ManufacturerProductNumber).Append("\n");
            sb.Append("  DigiKeyProductNumber: ").Append(DigiKeyProductNumber).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SalesOrderId: ").Append(SalesOrderId).Append("\n");
            sb.Append("  TracingId: ").Append(TracingId).Append("\n");
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
            return this.Equals(input as ProductTracingResponse);
        }

        /// <summary>
        /// Returns true if ProductTracingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductTracingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductTracingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CustomerPurchaseOrder == input.CustomerPurchaseOrder ||
                    (this.CustomerPurchaseOrder != null &&
                    this.CustomerPurchaseOrder.Equals(input.CustomerPurchaseOrder))
                ) && 
                (
                    this.CustomerReference == input.CustomerReference ||
                    (this.CustomerReference != null &&
                    this.CustomerReference.Equals(input.CustomerReference))
                ) && 
                (
                    this.CountryOfOrigin == input.CountryOfOrigin ||
                    (this.CountryOfOrigin != null &&
                    this.CountryOfOrigin.Equals(input.CountryOfOrigin))
                ) && 
                (
                    this.DateCode == input.DateCode ||
                    (this.DateCode != null &&
                    this.DateCode.Equals(input.DateCode))
                ) && 
                (
                    this.DetailId == input.DetailId ||
                    (this.DetailId != null &&
                    this.DetailId.Equals(input.DetailId))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.LotCode == input.LotCode ||
                    (this.LotCode != null &&
                    this.LotCode.Equals(input.LotCode))
                ) && 
                (
                    this.ManufacturerProductNumber == input.ManufacturerProductNumber ||
                    (this.ManufacturerProductNumber != null &&
                    this.ManufacturerProductNumber.Equals(input.ManufacturerProductNumber))
                ) && 
                (
                    this.DigiKeyProductNumber == input.DigiKeyProductNumber ||
                    (this.DigiKeyProductNumber != null &&
                    this.DigiKeyProductNumber.Equals(input.DigiKeyProductNumber))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.SalesOrderId == input.SalesOrderId ||
                    (this.SalesOrderId != null &&
                    this.SalesOrderId.Equals(input.SalesOrderId))
                ) && 
                (
                    this.TracingId == input.TracingId ||
                    (this.TracingId != null &&
                    this.TracingId.Equals(input.TracingId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CustomerPurchaseOrder != null)
                    hashCode = hashCode * 59 + this.CustomerPurchaseOrder.GetHashCode();
                if (this.CustomerReference != null)
                    hashCode = hashCode * 59 + this.CustomerReference.GetHashCode();
                if (this.CountryOfOrigin != null)
                    hashCode = hashCode * 59 + this.CountryOfOrigin.GetHashCode();
                if (this.DateCode != null)
                    hashCode = hashCode * 59 + this.DateCode.GetHashCode();
                if (this.DetailId != null)
                    hashCode = hashCode * 59 + this.DetailId.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.LotCode != null)
                    hashCode = hashCode * 59 + this.LotCode.GetHashCode();
                if (this.ManufacturerProductNumber != null)
                    hashCode = hashCode * 59 + this.ManufacturerProductNumber.GetHashCode();
                if (this.DigiKeyProductNumber != null)
                    hashCode = hashCode * 59 + this.DigiKeyProductNumber.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.SalesOrderId != null)
                    hashCode = hashCode * 59 + this.SalesOrderId.GetHashCode();
                if (this.TracingId != null)
                    hashCode = hashCode * 59 + this.TracingId.GetHashCode();
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
