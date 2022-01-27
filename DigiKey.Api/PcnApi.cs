using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DigiKey.Api.Client;
using DigiKey.Api.Model;
using System.Threading.Tasks;

namespace DigiKey.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PcnApi : BaseApi, IPcnApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PcnApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PcnApi()
        {
        }

        /// <summary>
        /// This returns all change notifications for the given DigiKey product. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve change notifications for.</param>
        /// <returns>Task of PcnResponse</returns>
        public async Task<PcnResponse> ProductChangeNotifications(string digiKeyPartNumber)
        {
             ApiResponse<PcnResponse> localVarResponse = await ProductChangeNotificationsWithHttpInfo(digiKeyPartNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This returns all change notifications for the given DigiKey product. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve change notifications for.</param>
        /// <returns>Task of ApiResponse (PcnResponse)</returns>
        public async Task<ApiResponse<PcnResponse>> ProductChangeNotificationsWithHttpInfo(string digiKeyPartNumber)
        {
            // verify the required parameter 'digiKeyPartNumber' is set
            if (digiKeyPartNumber == null)
                throw new ApiException(400, "Missing required parameter 'digiKeyPartNumber' when calling PcnApi->ProductChangeNotifications");
            // verify the required parameter 'authorization' is set
            
            var path = $"/ChangeNotifications/v3/Products/{digiKeyPartNumber}";
            RestResponse response = await MakeGetRequest(path);

            int statusCode = (int)response.StatusCode;

            if (ApiClient.ExceptionFactory != null)
            {
                Exception exception = ApiClient.ExceptionFactory("CategoriesById", response);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PcnResponse>(statusCode, response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
               ApiClient.Instance.Deserialize<PcnResponse>(response));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPcnApi
    {
        /// <summary>
        /// This returns all change notifications for the given DigiKey product.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve change notifications for.</param>
        /// <returns>Task of PcnResponse</returns>
        Task<PcnResponse> ProductChangeNotifications(string digiKeyPartNumber);

        /// <summary>
        /// This returns all change notifications for the given DigiKey product.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiKeyPartNumber">The product to retrieve change notifications for.</param>
        /// <returns>Task of ApiResponse (PcnResponse)</returns>
        Task<ApiResponse<PcnResponse>> ProductChangeNotificationsWithHttpInfo(string digiKeyPartNumber);
    }
}
