/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\").
 *
 * OpenAPI spec version: 3.3.0
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
    public interface IDraftApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List of NFL Draft picks
        /// </summary>
        /// <remarks>
        /// List of NFL Draft picks
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>ICollection&lt;DraftPick&gt;</returns>
        ICollection<DraftPick> GetDraftPicks (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null);

        /// <summary>
        /// List of NFL Draft picks
        /// </summary>
        /// <remarks>
        /// List of NFL Draft picks
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;DraftPick&gt;</returns>
        ApiResponse<ICollection<DraftPick>> GetDraftPicksWithHttpInfo (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null);
        /// <summary>
        /// List of NFL positions
        /// </summary>
        /// <remarks>
        /// List of NFL positions
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;DraftPosition&gt;</returns>
        ICollection<DraftPosition> GetNFLPositions ();

        /// <summary>
        /// List of NFL positions
        /// </summary>
        /// <remarks>
        /// List of NFL positions
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;DraftPosition&gt;</returns>
        ApiResponse<ICollection<DraftPosition>> GetNFLPositionsWithHttpInfo ();
        /// <summary>
        /// List of NFL teams
        /// </summary>
        /// <remarks>
        /// List of NFL teams
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;DraftTeam&gt;</returns>
        ICollection<DraftTeam> GetNFLTeams ();

        /// <summary>
        /// List of NFL teams
        /// </summary>
        /// <remarks>
        /// List of NFL teams
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;DraftTeam&gt;</returns>
        ApiResponse<ICollection<DraftTeam>> GetNFLTeamsWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List of NFL Draft picks
        /// </summary>
        /// <remarks>
        /// List of NFL Draft picks
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>Task of ICollection&lt;DraftPick&gt;</returns>
        System.Threading.Tasks.Task<ICollection<DraftPick>> GetDraftPicksAsync (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null);

        /// <summary>
        /// List of NFL Draft picks
        /// </summary>
        /// <remarks>
        /// List of NFL Draft picks
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;DraftPick&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<DraftPick>>> GetDraftPicksAsyncWithHttpInfo (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null);
        /// <summary>
        /// List of NFL positions
        /// </summary>
        /// <remarks>
        /// List of NFL positions
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ICollection&lt;DraftPosition&gt;</returns>
        System.Threading.Tasks.Task<ICollection<DraftPosition>> GetNFLPositionsAsync ();

        /// <summary>
        /// List of NFL positions
        /// </summary>
        /// <remarks>
        /// List of NFL positions
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ICollection&lt;DraftPosition&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<DraftPosition>>> GetNFLPositionsAsyncWithHttpInfo ();
        /// <summary>
        /// List of NFL teams
        /// </summary>
        /// <remarks>
        /// List of NFL teams
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ICollection&lt;DraftTeam&gt;</returns>
        System.Threading.Tasks.Task<ICollection<DraftTeam>> GetNFLTeamsAsync ();

        /// <summary>
        /// List of NFL teams
        /// </summary>
        /// <remarks>
        /// List of NFL teams
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ICollection&lt;DraftTeam&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<DraftTeam>>> GetNFLTeamsAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DraftApi : IDraftApi
    {
        private CFBSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DraftApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DraftApi(String basePath)
        {
            this.Configuration = new CFBSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DraftApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DraftApi(CFBSharp.Client.Configuration configuration = null)
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
        /// List of NFL Draft picks List of NFL Draft picks
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>ICollection&lt;DraftPick&gt;</returns>
        public ICollection<DraftPick> GetDraftPicks (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null)
        {
             ApiResponse<ICollection<DraftPick>> localVarResponse = GetDraftPicksWithHttpInfo(year, nflTeam, college, conference, position);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of NFL Draft picks List of NFL Draft picks
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;DraftPick&gt;</returns>
        public ApiResponse< ICollection<DraftPick> > GetDraftPicksWithHttpInfo (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null)
        {

            var localVarPath = "./draft/picks";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (nflTeam != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "nflTeam", nflTeam)); // query parameter
            if (college != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "college", college)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter
            if (position != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "position", position)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDraftPicks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<DraftPick>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<DraftPick>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DraftPick>)));
        }

        /// <summary>
        /// List of NFL Draft picks List of NFL Draft picks
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>Task of ICollection&lt;DraftPick&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<DraftPick>> GetDraftPicksAsync (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null)
        {
             ApiResponse<ICollection<DraftPick>> localVarResponse = await GetDraftPicksAsyncWithHttpInfo(year, nflTeam, college, conference, position);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of NFL Draft picks List of NFL Draft picks
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year filter (optional)</param>
        /// <param name="nflTeam">NFL team filter (optional)</param>
        /// <param name="college">Player college filter (optional)</param>
        /// <param name="conference">College confrence abbreviation filter (optional)</param>
        /// <param name="position">NFL position filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;DraftPick&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<DraftPick>>> GetDraftPicksAsyncWithHttpInfo (int? year = null, string nflTeam = null, string college = null, string conference = null, string position = null)
        {

            var localVarPath = "./draft/picks";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (nflTeam != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "nflTeam", nflTeam)); // query parameter
            if (college != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "college", college)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter
            if (position != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "position", position)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDraftPicks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<DraftPick>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<DraftPick>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DraftPick>)));
        }

        /// <summary>
        /// List of NFL positions List of NFL positions
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;DraftPosition&gt;</returns>
        public ICollection<DraftPosition> GetNFLPositions ()
        {
             ApiResponse<ICollection<DraftPosition>> localVarResponse = GetNFLPositionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of NFL positions List of NFL positions
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;DraftPosition&gt;</returns>
        public ApiResponse< ICollection<DraftPosition> > GetNFLPositionsWithHttpInfo ()
        {

            var localVarPath = "./draft/positions";
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


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNFLPositions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<DraftPosition>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<DraftPosition>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DraftPosition>)));
        }

        /// <summary>
        /// List of NFL positions List of NFL positions
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ICollection&lt;DraftPosition&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<DraftPosition>> GetNFLPositionsAsync ()
        {
             ApiResponse<ICollection<DraftPosition>> localVarResponse = await GetNFLPositionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of NFL positions List of NFL positions
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ICollection&lt;DraftPosition&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<DraftPosition>>> GetNFLPositionsAsyncWithHttpInfo ()
        {

            var localVarPath = "./draft/positions";
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


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNFLPositions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<DraftPosition>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<DraftPosition>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DraftPosition>)));
        }

        /// <summary>
        /// List of NFL teams List of NFL teams
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ICollection&lt;DraftTeam&gt;</returns>
        public ICollection<DraftTeam> GetNFLTeams ()
        {
             ApiResponse<ICollection<DraftTeam>> localVarResponse = GetNFLTeamsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of NFL teams List of NFL teams
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ICollection&lt;DraftTeam&gt;</returns>
        public ApiResponse< ICollection<DraftTeam> > GetNFLTeamsWithHttpInfo ()
        {

            var localVarPath = "./draft/teams";
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


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNFLTeams", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<DraftTeam>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<DraftTeam>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DraftTeam>)));
        }

        /// <summary>
        /// List of NFL teams List of NFL teams
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ICollection&lt;DraftTeam&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<DraftTeam>> GetNFLTeamsAsync ()
        {
             ApiResponse<ICollection<DraftTeam>> localVarResponse = await GetNFLTeamsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of NFL teams List of NFL teams
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ICollection&lt;DraftTeam&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<DraftTeam>>> GetNFLTeamsAsyncWithHttpInfo ()
        {

            var localVarPath = "./draft/teams";
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


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNFLTeams", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<DraftTeam>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<DraftTeam>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DraftTeam>)));
        }

    }
}
