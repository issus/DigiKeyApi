using DigiKey.Api.Client;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiKey.Api
{
    public enum LocaleSite
    {
        US, CA, JP, UK, DE, AT, BE, DK, FI, GR, IE, IT, LU, NL, NO, PT, ES, KR, HK, SG, CN, TW, AU, FR, IN, NZ, SE, MX, CH, IL, PL, SK, SI, LV, LT, EE, CZ, HU, BG, MY, ZA, RO, TH, PH
    }

    public enum LocaleLanguage
    {
        EN, JA, DE, FR, KO, ZHS, ZHT, IT, ES, HE, NL, SV, PL, FI, DA, NO
    }

    public enum LocaleCurrency
    {
        USD, CAD, JPY, GBP, EUR, HKD, SGD, TWD, KRW, AUD, NZD, INR, DKK, NOK, SEK, ILS, CNY, PLN, CHF, CZK, HUF, RON, ZAR, MYR, THB, PHP
    }

    public abstract class BaseApi
    {
        internal async Task<RestResponse> MakeGetRequest(string path, Dictionary<string, string> pathParams = null,
            List<KeyValuePair<string, string>> queryParams = null, Dictionary<string, string> headerParams = null)
        {
            if (headerParams == null)
            {
                headerParams = new Dictionary<string, string>();
            }

            headerParams.Add("accepts", "application/json, text/json");

            // make the HTTP request
            return await ApiClient.Instance.CallApi(path,
                Method.Get, queryParams, null, headerParams, pathParams);
        }

        internal async Task<RestResponse> MakePostRequest(string path, object body, Dictionary<string, string> pathParams = null,
            List<KeyValuePair<string, string>> queryParams = null, Dictionary<string, string> headerParams = null)
        {
            if (headerParams == null)
            {
                headerParams = new Dictionary<string, string>();
            }

            headerParams.Add("accepts", "application/json, text/json");

            // make the HTTP request
            return await ApiClient.Instance.CallApi(path,
                Method.Post, queryParams, body, headerParams, pathParams);
        }
    }
}
