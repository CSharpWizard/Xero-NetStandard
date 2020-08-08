/* 
 * Xero oAuth 2 identity service
 *
 * This specifing endpoints related to managing authentication tokens and identity for Xero API
 *
 * The version of the OpenAPI document: 2.2.11
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Identity;

namespace Xero.NetStandard.OAuth2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Allows you to delete a connection for this user (i.e. disconnect a tenant)
        /// </summary>
        /// <remarks>
        /// Override the base server url that include version
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteConnectionAsync (string accessToken, Guid id);

        /// <summary>
        /// Allows you to delete a connection for this user (i.e. disconnect a tenant)
        /// </summary>
        /// <remarks>
        /// Override the base server url that include version
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConnectionAsyncWithHttpInfo (string accessToken, Guid id);
        /// <summary>
        /// Allows you to retrieve the connections for this user
        /// </summary>
        /// <remarks>
        /// Override the base server url that include version
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authEventId">Filter by authEventId (optional)</param>
        /// <returns>Task of List&lt;Connection&gt;</returns>
        System.Threading.Tasks.Task<List<Connection>> GetConnectionsAsync (string accessToken, Guid? authEventId = null);

        /// <summary>
        /// Allows you to retrieve the connections for this user
        /// </summary>
        /// <remarks>
        /// Override the base server url that include version
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authEventId">Filter by authEventId (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Connection&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Connection>>> GetConnectionsAsyncWithHttpInfo (string accessToken, Guid? authEventId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityApi : IIdentityApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IdentityApi : IIdentityApi
    {
        private Xero.NetStandard.OAuth2.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityApi() : this((string) null)
        {
            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                new Xero.NetStandard.OAuth2.Client.Configuration { BasePath = "https://api.xero.com" }
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityApi(String basePath)
        {
            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                new Xero.NetStandard.OAuth2.Client.Configuration { BasePath = basePath }
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IdentityApi(Xero.NetStandard.OAuth2.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public IdentityApi(Xero.NetStandard.OAuth2.Client.ISynchronousClient client,Xero.NetStandard.OAuth2.Client.IAsynchronousClient asyncClient, Xero.NetStandard.OAuth2.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Xero.NetStandard.OAuth2.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Xero.NetStandard.OAuth2.Client.IReadableConfiguration Configuration {get; set;}


        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Xero.NetStandard.OAuth2.Client.ExceptionFactory ExceptionFactory
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
        /// Allows you to delete a connection for this user (i.e. disconnect a tenant) Override the base server url that include version
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteConnectionAsync (string accessToken, Guid id)
        {
             await DeleteConnectionAsyncWithHttpInfo(accessToken, id);

        }

        /// <summary>
        /// Allows you to delete a connection for this user (i.e. disconnect a tenant) Override the base server url that include version
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<Object>> DeleteConnectionAsyncWithHttpInfo (string accessToken, Guid id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'id' when calling IdentityApi->DeleteConnection");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (id != null)
                requestOptions.PathParameters.Add("id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.DeleteAsync<Object>("/connections/{id}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("DeleteConnection", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Allows you to retrieve the connections for this user Override the base server url that include version
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authEventId">Filter by authEventId (optional)</param>
        /// <returns>Task of List&lt;Connection&gt;</returns>
        public async System.Threading.Tasks.Task<List<Connection>> GetConnectionsAsync (string accessToken, Guid? authEventId = null)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<List<Connection>> localVarResponse = await GetConnectionsAsyncWithHttpInfo(accessToken, authEventId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allows you to retrieve the connections for this user Override the base server url that include version
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authEventId">Filter by authEventId (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Connection&gt;)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<List<Connection>>> GetConnectionsAsyncWithHttpInfo (string accessToken, Guid? authEventId = null)
        {

            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            

            if (authEventId != null)
            {
                foreach (var kvp in Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToMultiMap("", "authEventId", authEventId))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.GetAsync<List<Connection>>("/connections", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetConnections", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
