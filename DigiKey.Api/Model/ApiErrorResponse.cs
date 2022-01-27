using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace DigiKey.Api.Model
{
    /// <summary>
    /// Common response model returned for any type of HTTP exception.
    /// </summary>
    [DataContract]
    public partial class ApiErrorResponse : IEquatable<ApiErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiErrorResponse" /> class.
        /// </summary>
        /// <param name="statusCode">The HttpStatusCode of the error..</param>
        /// <param name="errorMessage">The message provided by the error handler..</param>
        /// <param name="errorDetails">The details of the error..</param>
        /// <param name="requestId">The Id of the request that triggered the error. If contacting API Support, please include the RequestId..</param>
        /// <param name="validationErrors">The list of validation errors(if applicable)..</param>
        public ApiErrorResponse(int? statusCode = default(int?), string errorMessage = default(string), string errorDetails = default(string), string requestId = default(string), List<ApiValidationError> validationErrors = default(List<ApiValidationError>))
        {
            this.StatusCode = statusCode;
            this.ErrorMessage = errorMessage;
            this.ErrorDetails = errorDetails;
            this.RequestId = requestId;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// The version of the error handler.
        /// </summary>
        /// <value>The version of the error handler.</value>
        [DataMember(Name = "ErrorResponseVersion", EmitDefaultValue = false)]
        public string ErrorResponseVersion { get; private set; }

        /// <summary>
        /// The HttpStatusCode of the error.
        /// </summary>
        /// <value>The HttpStatusCode of the error.</value>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// The message provided by the error handler.
        /// </summary>
        /// <value>The message provided by the error handler.</value>
        [DataMember(Name = "ErrorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of the error.
        /// </summary>
        /// <value>The details of the error.</value>
        [DataMember(Name = "ErrorDetails", EmitDefaultValue = false)]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// The Id of the request that triggered the error. If contacting API Support, please include the RequestId.
        /// </summary>
        /// <value>The Id of the request that triggered the error. If contacting API Support, please include the RequestId.</value>
        [DataMember(Name = "RequestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of validation errors(if applicable).
        /// </summary>
        /// <value>The list of validation errors(if applicable).</value>
        [DataMember(Name = "ValidationErrors", EmitDefaultValue = false)]
        public List<ApiValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiErrorResponse {\n");
            sb.Append("  ErrorResponseVersion: ").Append(ErrorResponseVersion).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as ApiErrorResponse);
        }

        /// <summary>
        /// Returns true if ApiErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiErrorResponse input)
        {
            if (input == null)
                return false;

            return
               (
                    this.ErrorResponseVersion == input.ErrorResponseVersion ||
                   (this.ErrorResponseVersion != null &&
                    this.ErrorResponseVersion.Equals(input.ErrorResponseVersion))
                ) &&
               (
                    this.StatusCode == input.StatusCode ||
                   (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) &&
               (
                    this.ErrorMessage == input.ErrorMessage ||
                   (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) &&
               (
                    this.ErrorDetails == input.ErrorDetails ||
                   (this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(input.ErrorDetails))
                ) &&
               (
                    this.RequestId == input.RequestId ||
                   (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) &&
               (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.ErrorResponseVersion != null)
                    hashCode = hashCode * 59 + this.ErrorResponseVersion.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ErrorDetails != null)
                    hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
