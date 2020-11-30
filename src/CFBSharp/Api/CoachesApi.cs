/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.3.1
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using CFBSharp.Client;
using CFBSharp.Model;

namespace CFBSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoachesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Coaching records and history
        /// </summary>
        /// <remarks>
        /// Coaching history
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>ICollection&lt;InlineResponse200&gt;</returns>
        ICollection<InlineResponse200> GetCoaches (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null);

        /// <summary>
        /// Coaching records and history
        /// </summary>
        /// <remarks>
        /// Coaching history
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;InlineResponse200&gt;</returns>
        ApiResponse<ICollection<InlineResponse200>> GetCoachesWithHttpInfo (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Coaching records and history
        /// </summary>
        /// <remarks>
        /// Coaching history
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>Task of ICollection&lt;InlineResponse200&gt;</returns>
        System.Threading.Tasks.Task<ICollection<InlineResponse200>> GetCoachesAsync (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null);

        /// <summary>
        /// Coaching records and history
        /// </summary>
        /// <remarks>
        /// Coaching history
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;InlineResponse200&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<InlineResponse200>>> GetCoachesAsyncWithHttpInfo (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CoachesApi : ICoachesApi
    {
        private CFBSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoachesApi(String basePath)
        {
            this.Configuration = new CFBSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CoachesApi(CFBSharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = CFBSharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CFBSharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CFBSharp.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Coaching records and history Coaching history
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>ICollection&lt;InlineResponse200&gt;</returns>
        public ICollection<InlineResponse200> GetCoaches (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null)
        {
             ApiResponse<ICollection<InlineResponse200>> localVarResponse = GetCoachesWithHttpInfo(firstName, lastName, team, year, minYear, maxYear);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Coaching records and history Coaching history
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;InlineResponse200&gt;</returns>
        public ApiResponse< ICollection<InlineResponse200> > GetCoachesWithHttpInfo (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null)
        {

            var localVarPath = "./coaches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (firstName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "firstName", firstName)); // query parameter
            if (lastName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lastName", lastName)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (minYear != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "minYear", minYear)); // query parameter
            if (maxYear != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "maxYear", maxYear)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCoaches", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<InlineResponse200>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<InlineResponse200>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InlineResponse200>)));
        }

        /// <summary>
        /// Coaching records and history Coaching history
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>Task of ICollection&lt;InlineResponse200&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<InlineResponse200>> GetCoachesAsync (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null)
        {
             ApiResponse<ICollection<InlineResponse200>> localVarResponse = await GetCoachesAsyncWithHttpInfo(firstName, lastName, team, year, minYear, maxYear);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Coaching records and history Coaching history
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firstName">First name filter (optional)</param>
        /// <param name="lastName">Last name filter (optional)</param>
        /// <param name="team">Team name filter (optional)</param>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="minYear">Minimum year filter (inclusive) (optional)</param>
        /// <param name="maxYear">Maximum year filter (inclusive) (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;InlineResponse200&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<InlineResponse200>>> GetCoachesAsyncWithHttpInfo (string firstName = null, string lastName = null, string team = null, int? year = null, int? minYear = null, int? maxYear = null)
        {

            var localVarPath = "./coaches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (firstName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "firstName", firstName)); // query parameter
            if (lastName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lastName", lastName)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (minYear != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "minYear", minYear)); // query parameter
            if (maxYear != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "maxYear", maxYear)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCoaches", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<InlineResponse200>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<InlineResponse200>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InlineResponse200>)));
        }

    }
}
