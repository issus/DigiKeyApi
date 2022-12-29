using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using OriginalCircuit.DigiKey.Api.Client;
using OriginalCircuit.DigiKey.Api.Model;
using System.Threading.Tasks;

namespace OriginalCircuit.DigiKey.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PackageTypeByQuantityApi : BaseApi, IPackageTypeByQuantityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageTypeByQuantityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PackageTypeByQuantityApi()
        {
        }

        /// <summary>
        /// Provide a part number and quantity to receive product information such as pricing, available quantity, and the best  packaging type for the requested quantity of the product.  For example, given a requested quantity larger than a standard reel, this will return information about the  standard tape and reel as well as either cut tape or DKR depending on the provided preference.  Made for Cut Tape, Tape and Reel, and Digi-Reel products only. Other packaging types can be searched for, but  results may vary.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States. 
        /// </summary>
        /// <exception cref="OriginalCircuit.DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">A part number. Can be either Digi-Key or Manufacturer, but some manufacturer part  numbers are ambiguous and will not be found. A DKR part number will override a CT packagingPreference.</param>
        /// <param name="requestedQuantity">The quantity of the product that you are interested in. This will be used to determined  the quantity to purchase in standard tape and reel, and also in your part preference for the remainder.</param>
        /// <returns>PackageTypeByQuantityResponse</returns>
        public async Task<PackageTypeByQuantityResponse> PackageTypeByQuantity(string digiKeyPartNumber, int? requestedQuantity)
        {
             ApiResponse<PackageTypeByQuantityResponse> localVarResponse = await PackageTypeByQuantityWithHttpInfo(digiKeyPartNumber, requestedQuantity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Provide a part number and quantity to receive product information such as pricing, available quantity, and the best  packaging type for the requested quantity of the product.  For example, given a requested quantity larger than a standard reel, this will return information about the  standard tape and reel as well as either cut tape or DKR depending on the provided preference.  Made for Cut Tape, Tape and Reel, and Digi-Reel products only. Other packaging types can be searched for, but  results may vary.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States. 
        /// </summary>
        /// <exception cref="OriginalCircuit.DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">A part number. Can be either Digi-Key or Manufacturer, but some manufacturer part  numbers are ambiguous and will not be found. A DKR part number will override a CT packagingPreference.</param>
        /// <param name="requestedQuantity">The quantity of the product that you are interested in. This will be used to determined  the quantity to purchase in standard tape and reel, and also in your part preference for the remainder.</param>
        /// <returns>ApiResponse of PackageTypeByQuantityResponse</returns>
        public async Task<ApiResponse<PackageTypeByQuantityResponse>> PackageTypeByQuantityWithHttpInfo(string digiKeyPartNumber, int? requestedQuantity)
        {
            // verify the required parameter 'digiKeyPartNumber' is set
            if (digiKeyPartNumber == null)
                throw new ApiException(400, "Missing required parameter 'digiKeyPartNumber' when calling PackageTypeByQuantityApi->PackageTypeByQuantity");
            // verify the required parameter 'requestedQuantity' is set
            if (requestedQuantity == null)
                throw new ApiException(400, "Missing required parameter 'requestedQuantity' when calling PackageTypeByQuantityApi->PackageTypeByQuantity");
            
            var path = $"/PackageTypeByQuantity/v3/Products/{digiKeyPartNumber}";
            
            var queryParams = new List<KeyValuePair<string, string>>();
            if (requestedQuantity != null) queryParams.Add(new KeyValuePair<string, string>("RequestedQuantity", requestedQuantity.ToString())); // query parameter

            RestResponse response = await MakeGetRequest(path, queryParams: queryParams);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("PackageTypeByQuantity", response);
                if (exception != null && !(statusCode == 429 && !ApiClient.Instance.ThrowRateLimitExceptions)) throw exception;
            }

            return new ApiResponse<PackageTypeByQuantityResponse>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<PackageTypeByQuantityResponse>(response));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPackageTypeByQuantityApi
    {
        /// <summary>
        /// Provide a part number and quantity to receive product information such as pricing, available quantity, and the best  packaging type for the requested quantity of the product.  For example, given a requested quantity larger than a standard reel, this will return information about the  standard tape and reel as well as either cut tape or DKR depending on the provided preference.  Made for Cut Tape, Tape and Reel, and Digi-Reel products only. Other packaging types can be searched for, but  results may vary.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="OriginalCircuit.DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">A part number. Can be either Digi-Key or Manufacturer, but some manufacturer part  numbers are ambiguous and will not be found. A DKR part number will override a CT packagingPreference.</param>
        /// <param name="requestedQuantity">The quantity of the product that you are interested in. This will be used to determined  the quantity to purchase in standard tape and reel, and also in your part preference for the remainder.</param>
        /// <returns>Task of PackageTypeByQuantityResponse</returns>
        Task<PackageTypeByQuantityResponse> PackageTypeByQuantity(string digiKeyPartNumber, int? requestedQuantity);

        /// <summary>
        /// Provide a part number and quantity to receive product information such as pricing, available quantity, and the best  packaging type for the requested quantity of the product.  For example, given a requested quantity larger than a standard reel, this will return information about the  standard tape and reel as well as either cut tape or DKR depending on the provided preference.  Made for Cut Tape, Tape and Reel, and Digi-Reel products only. Other packaging types can be searched for, but  results may vary.  Locale information is required in the headers for accurate pricing and currencies. Locale defaults to United  States.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="OriginalCircuit.DigiKey.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">A part number. Can be either Digi-Key or Manufacturer, but some manufacturer part  numbers are ambiguous and will not be found. A DKR part number will override a CT packagingPreference.</param>
        /// <param name="requestedQuantity">The quantity of the product that you are interested in. This will be used to determined  the quantity to purchase in standard tape and reel, and also in your part preference for the remainder.</param>
        /// <returns>Task of ApiResponse (PackageTypeByQuantityResponse)</returns>
        Task<ApiResponse<PackageTypeByQuantityResponse>> PackageTypeByQuantityWithHttpInfo(string digiKeyPartNumber, int? requestedQuantity);
    }
}
