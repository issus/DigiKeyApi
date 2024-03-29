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
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace OriginalCircuit.DigiKey.Api.Model
{
    /// <summary>
    /// SortDirection enum
    /// </summary>
    /// <value>SortDirection enum</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum SortDirection
    {

        /// <summary>
        /// Enum Ascending for value: Ascending
        /// </summary>
        [EnumMember(Value = "Ascending")]
        Ascending = 1,

        /// <summary>
        /// Enum Descending for value: Descending
        /// </summary>
        [EnumMember(Value = "Descending")]
        Descending = 2
    }

}
