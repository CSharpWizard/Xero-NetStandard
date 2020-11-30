/* 
 * Bank Feeds API
 *
 * This specifing endpoints Xero Bank feeds API
 *
 * The version of the OpenAPI document: 2.5.0
 * Contact: api@xero.com
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Bankfeeds;

namespace Xero.NetStandard.OAuth2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBankFeedsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// create one or more new feed connection
        /// </summary>
        /// <remarks>
        /// By passing in the FeedConnections array object in the body, you can create one or more new feed connections
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connection(s) array object in the body</param>
        /// <returns>Task of FeedConnections</returns>
        System.Threading.Tasks.Task<FeedConnections> CreateFeedConnectionsAsync (string accessToken, string xeroTenantId, FeedConnections feedConnections);

        /// <summary>
        /// create one or more new feed connection
        /// </summary>
        /// <remarks>
        /// By passing in the FeedConnections array object in the body, you can create one or more new feed connections
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connection(s) array object in the body</param>
        /// <returns>Task of ApiResponse (FeedConnections)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeedConnections>> CreateFeedConnectionsAsyncWithHttpInfo (string accessToken, string xeroTenantId, FeedConnections feedConnections);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statements">Statements array of objects in the body (optional)</param>
        /// <returns>Task of Statements</returns>
        System.Threading.Tasks.Task<Statements> CreateStatementsAsync (string accessToken, string xeroTenantId, Statements statements = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statements">Statements array of objects in the body (optional)</param>
        /// <returns>Task of ApiResponse (Statements)</returns>
        System.Threading.Tasks.Task<ApiResponse<Statements>> CreateStatementsAsyncWithHttpInfo (string accessToken, string xeroTenantId, Statements statements = null);
        /// <summary>
        /// Delete an exsiting feed connection
        /// </summary>
        /// <remarks>
        /// By passing in FeedConnections array object in the body, you can delete a feed connection.
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connections array object in the body</param>
        /// <returns>Task of FeedConnections</returns>
        System.Threading.Tasks.Task<FeedConnections> DeleteFeedConnectionsAsync (string accessToken, string xeroTenantId, FeedConnections feedConnections);

        /// <summary>
        /// Delete an exsiting feed connection
        /// </summary>
        /// <remarks>
        /// By passing in FeedConnections array object in the body, you can delete a feed connection.
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connections array object in the body</param>
        /// <returns>Task of ApiResponse (FeedConnections)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeedConnections>> DeleteFeedConnectionsAsyncWithHttpInfo (string accessToken, string xeroTenantId, FeedConnections feedConnections);
        /// <summary>
        /// Retrive single feed connection based on unique id provided
        /// </summary>
        /// <remarks>
        /// By passing in a FeedConnection Id options, you can search for matching feed connections
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of FeedConnection</returns>
        System.Threading.Tasks.Task<FeedConnection> GetFeedConnectionAsync (string accessToken, string xeroTenantId, Guid id);

        /// <summary>
        /// Retrive single feed connection based on unique id provided
        /// </summary>
        /// <remarks>
        /// By passing in a FeedConnection Id options, you can search for matching feed connections
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of ApiResponse (FeedConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeedConnection>> GetFeedConnectionAsyncWithHttpInfo (string accessToken, string xeroTenantId, Guid id);
        /// <summary>
        /// searches feed connections
        /// </summary>
        /// <remarks>
        /// By passing in the appropriate options, you can search for available feed connections in the system.
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">Page number which specifies the set of records to retrieve. By default the number of the records per set is 10. Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?page&#x3D;1 to get the second set of the records. When page value is not a number or a negative number, by default, the first set of records is returned. (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <returns>Task of FeedConnections</returns>
        System.Threading.Tasks.Task<FeedConnections> GetFeedConnectionsAsync (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null);

        /// <summary>
        /// searches feed connections
        /// </summary>
        /// <remarks>
        /// By passing in the appropriate options, you can search for available feed connections in the system.
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">Page number which specifies the set of records to retrieve. By default the number of the records per set is 10. Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?page&#x3D;1 to get the second set of the records. When page value is not a number or a negative number, by default, the first set of records is returned. (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <returns>Task of ApiResponse (FeedConnections)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeedConnections>> GetFeedConnectionsAsyncWithHttpInfo (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null);
        /// <summary>
        /// Retrive single statement based on unique id provided
        /// </summary>
        /// <remarks>
        /// By passing in a statement id, you can search for matching statements
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statementId">statement id for single object</param>
        /// <returns>Task of Statement</returns>
        System.Threading.Tasks.Task<Statement> GetStatementAsync (string accessToken, string xeroTenantId, Guid statementId);

        /// <summary>
        /// Retrive single statement based on unique id provided
        /// </summary>
        /// <remarks>
        /// By passing in a statement id, you can search for matching statements
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statementId">statement id for single object</param>
        /// <returns>Task of ApiResponse (Statement)</returns>
        System.Threading.Tasks.Task<ApiResponse<Statement>> GetStatementAsyncWithHttpInfo (string accessToken, string xeroTenantId, Guid statementId);
        /// <summary>
        /// Retrive all statements based on unique search criteria
        /// </summary>
        /// <remarks>
        /// By passing in parameters, you can search for matching statements
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">unique id for single object (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <param name="xeroApplicationId"> (optional, default to &quot;00000000-0000-0000-0000-0000000010000&quot;)</param>
        /// <param name="xeroUserId"> (optional, default to &quot;00000000-0000-0000-0000-0000030000000&quot;)</param>
        /// <returns>Task of Statements</returns>
        System.Threading.Tasks.Task<Statements> GetStatementsAsync (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string xeroApplicationId = null, string xeroUserId = null);

        /// <summary>
        /// Retrive all statements based on unique search criteria
        /// </summary>
        /// <remarks>
        /// By passing in parameters, you can search for matching statements
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">unique id for single object (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <param name="xeroApplicationId"> (optional, default to &quot;00000000-0000-0000-0000-0000000010000&quot;)</param>
        /// <param name="xeroUserId"> (optional, default to &quot;00000000-0000-0000-0000-0000030000000&quot;)</param>
        /// <returns>Task of ApiResponse (Statements)</returns>
        System.Threading.Tasks.Task<ApiResponse<Statements>> GetStatementsAsyncWithHttpInfo (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string xeroApplicationId = null, string xeroUserId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBankFeedsApi : IBankFeedsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BankFeedsApi : IBankFeedsApi
    {
        private Xero.NetStandard.OAuth2.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BankFeedsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BankFeedsApi() : this((string) null)
        {
            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                new Xero.NetStandard.OAuth2.Client.Configuration { BasePath = "https://api.xero.com/bankfeeds.xro/1.0" }
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankFeedsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BankFeedsApi(String basePath)
        {
            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                new Xero.NetStandard.OAuth2.Client.Configuration { BasePath = basePath }
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankFeedsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BankFeedsApi(Xero.NetStandard.OAuth2.Client.Configuration configuration)
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
        public BankFeedsApi(Xero.NetStandard.OAuth2.Client.ISynchronousClient client,Xero.NetStandard.OAuth2.Client.IAsynchronousClient asyncClient, Xero.NetStandard.OAuth2.Client.IReadableConfiguration configuration)
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
        /// create one or more new feed connection By passing in the FeedConnections array object in the body, you can create one or more new feed connections
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connection(s) array object in the body</param>
        /// <returns>Task of FeedConnections</returns>
        public async System.Threading.Tasks.Task<FeedConnections> CreateFeedConnectionsAsync (string accessToken, string xeroTenantId, FeedConnections feedConnections)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnections> localVarResponse = await CreateFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, feedConnections);
             return localVarResponse.Data;

        }

        /// <summary>
        /// create one or more new feed connection By passing in the FeedConnections array object in the body, you can create one or more new feed connections
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connection(s) array object in the body</param>
        /// <returns>Task of ApiResponse (FeedConnections)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnections>> CreateFeedConnectionsAsyncWithHttpInfo (string accessToken, string xeroTenantId, FeedConnections feedConnections)
        {
            // verify the required parameter 'xeroTenantId' is set
            if (xeroTenantId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'xeroTenantId' when calling BankFeedsApi->CreateFeedConnections");

            // verify the required parameter 'feedConnections' is set
            if (feedConnections == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'feedConnections' when calling BankFeedsApi->CreateFeedConnections");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (xeroTenantId != null)
                requestOptions.HeaderParameters.Add("Xero-Tenant-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroTenantId)); // header parameter
            requestOptions.Data = feedConnections;

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.PostAsync<FeedConnections>("/FeedConnections", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CreateFeedConnections", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statements">Statements array of objects in the body (optional)</param>
        /// <returns>Task of Statements</returns>
        public async System.Threading.Tasks.Task<Statements> CreateStatementsAsync (string accessToken, string xeroTenantId, Statements statements = null)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<Statements> localVarResponse = await CreateStatementsAsyncWithHttpInfo(accessToken, xeroTenantId, statements);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statements">Statements array of objects in the body (optional)</param>
        /// <returns>Task of ApiResponse (Statements)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<Statements>> CreateStatementsAsyncWithHttpInfo (string accessToken, string xeroTenantId, Statements statements = null)
        {
            // verify the required parameter 'xeroTenantId' is set
            if (xeroTenantId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'xeroTenantId' when calling BankFeedsApi->CreateStatements");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json",
                "application/problem+json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (xeroTenantId != null)
                requestOptions.HeaderParameters.Add("Xero-Tenant-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroTenantId)); // header parameter
            requestOptions.Data = statements;

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.PostAsync<Statements>("/Statements", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CreateStatements", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Delete an exsiting feed connection By passing in FeedConnections array object in the body, you can delete a feed connection.
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connections array object in the body</param>
        /// <returns>Task of FeedConnections</returns>
        public async System.Threading.Tasks.Task<FeedConnections> DeleteFeedConnectionsAsync (string accessToken, string xeroTenantId, FeedConnections feedConnections)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnections> localVarResponse = await DeleteFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, feedConnections);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an exsiting feed connection By passing in FeedConnections array object in the body, you can delete a feed connection.
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="feedConnections">Feed Connections array object in the body</param>
        /// <returns>Task of ApiResponse (FeedConnections)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnections>> DeleteFeedConnectionsAsyncWithHttpInfo (string accessToken, string xeroTenantId, FeedConnections feedConnections)
        {
            // verify the required parameter 'xeroTenantId' is set
            if (xeroTenantId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'xeroTenantId' when calling BankFeedsApi->DeleteFeedConnections");

            // verify the required parameter 'feedConnections' is set
            if (feedConnections == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'feedConnections' when calling BankFeedsApi->DeleteFeedConnections");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (xeroTenantId != null)
                requestOptions.HeaderParameters.Add("Xero-Tenant-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroTenantId)); // header parameter
            requestOptions.Data = feedConnections;

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.PostAsync<FeedConnections>("/FeedConnections/DeleteRequests", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("DeleteFeedConnections", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Retrive single feed connection based on unique id provided By passing in a FeedConnection Id options, you can search for matching feed connections
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of FeedConnection</returns>
        public async System.Threading.Tasks.Task<FeedConnection> GetFeedConnectionAsync (string accessToken, string xeroTenantId, Guid id)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnection> localVarResponse = await GetFeedConnectionAsyncWithHttpInfo(accessToken, xeroTenantId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrive single feed connection based on unique id provided By passing in a FeedConnection Id options, you can search for matching feed connections
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="id">Unique identifier for retrieving single object</param>
        /// <returns>Task of ApiResponse (FeedConnection)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnection>> GetFeedConnectionAsyncWithHttpInfo (string accessToken, string xeroTenantId, Guid id)
        {
            // verify the required parameter 'xeroTenantId' is set
            if (xeroTenantId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'xeroTenantId' when calling BankFeedsApi->GetFeedConnection");

            // verify the required parameter 'id' is set
            if (id == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'id' when calling BankFeedsApi->GetFeedConnection");


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
            
            if (id != null)
                requestOptions.PathParameters.Add("id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (xeroTenantId != null)
                requestOptions.HeaderParameters.Add("Xero-Tenant-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroTenantId)); // header parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.GetAsync<FeedConnection>("/FeedConnections/{id}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetFeedConnection", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// searches feed connections By passing in the appropriate options, you can search for available feed connections in the system.
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">Page number which specifies the set of records to retrieve. By default the number of the records per set is 10. Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?page&#x3D;1 to get the second set of the records. When page value is not a number or a negative number, by default, the first set of records is returned. (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <returns>Task of FeedConnections</returns>
        public async System.Threading.Tasks.Task<FeedConnections> GetFeedConnectionsAsync (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnections> localVarResponse = await GetFeedConnectionsAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// searches feed connections By passing in the appropriate options, you can search for available feed connections in the system.
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">Page number which specifies the set of records to retrieve. By default the number of the records per set is 10. Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?page&#x3D;1 to get the second set of the records. When page value is not a number or a negative number, by default, the first set of records is returned. (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/FeedConnections?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <returns>Task of ApiResponse (FeedConnections)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<FeedConnections>> GetFeedConnectionsAsyncWithHttpInfo (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null)
        {
            // verify the required parameter 'xeroTenantId' is set
            if (xeroTenantId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'xeroTenantId' when calling BankFeedsApi->GetFeedConnections");


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
            

            if (page != null)
            {
                foreach (var kvp in Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToMultiMap("", "page", page))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }

            if (pageSize != null)
            {
                foreach (var kvp in Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (xeroTenantId != null)
                requestOptions.HeaderParameters.Add("Xero-Tenant-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroTenantId)); // header parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.GetAsync<FeedConnections>("/FeedConnections", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetFeedConnections", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Retrive single statement based on unique id provided By passing in a statement id, you can search for matching statements
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statementId">statement id for single object</param>
        /// <returns>Task of Statement</returns>
        public async System.Threading.Tasks.Task<Statement> GetStatementAsync (string accessToken, string xeroTenantId, Guid statementId)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<Statement> localVarResponse = await GetStatementAsyncWithHttpInfo(accessToken, xeroTenantId, statementId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrive single statement based on unique id provided By passing in a statement id, you can search for matching statements
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="statementId">statement id for single object</param>
        /// <returns>Task of ApiResponse (Statement)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<Statement>> GetStatementAsyncWithHttpInfo (string accessToken, string xeroTenantId, Guid statementId)
        {
            // verify the required parameter 'xeroTenantId' is set
            if (xeroTenantId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'xeroTenantId' when calling BankFeedsApi->GetStatement");

            // verify the required parameter 'statementId' is set
            if (statementId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'statementId' when calling BankFeedsApi->GetStatement");


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
            
            if (statementId != null)
                requestOptions.PathParameters.Add("statementId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(statementId)); // path parameter
            if (xeroTenantId != null)
                requestOptions.HeaderParameters.Add("Xero-Tenant-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroTenantId)); // header parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.GetAsync<Statement>("/Statements/{statementId}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetStatement", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Retrive all statements based on unique search criteria By passing in parameters, you can search for matching statements
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">unique id for single object (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <param name="xeroApplicationId"> (optional, default to &quot;00000000-0000-0000-0000-0000000010000&quot;)</param>
        /// <param name="xeroUserId"> (optional, default to &quot;00000000-0000-0000-0000-0000030000000&quot;)</param>
        /// <returns>Task of Statements</returns>
        public async System.Threading.Tasks.Task<Statements> GetStatementsAsync (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string xeroApplicationId = null, string xeroUserId = null)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<Statements> localVarResponse = await GetStatementsAsyncWithHttpInfo(accessToken, xeroTenantId, page, pageSize, xeroApplicationId, xeroUserId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrive all statements based on unique search criteria By passing in parameters, you can search for matching statements
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xeroTenantId">Xero identifier for Tenant</param>
        /// <param name="page">unique id for single object (optional)</param>
        /// <param name="pageSize">Page size which specifies how many records per page will be returned (default 10). Example - https://api.xero.com/bankfeeds.xro/1.0/Statements?pageSize&#x3D;100 to specify page size of 100. (optional)</param>
        /// <param name="xeroApplicationId"> (optional, default to &quot;00000000-0000-0000-0000-0000000010000&quot;)</param>
        /// <param name="xeroUserId"> (optional, default to &quot;00000000-0000-0000-0000-0000030000000&quot;)</param>
        /// <returns>Task of ApiResponse (Statements)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<Statements>> GetStatementsAsyncWithHttpInfo (string accessToken, string xeroTenantId, int? page = null, int? pageSize = null, string xeroApplicationId = null, string xeroUserId = null)
        {
            // verify the required parameter 'xeroTenantId' is set
            if (xeroTenantId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'xeroTenantId' when calling BankFeedsApi->GetStatements");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json",
                "application/problem+json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            

            if (page != null)
            {
                foreach (var kvp in Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToMultiMap("", "page", page))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }

            if (pageSize != null)
            {
                foreach (var kvp in Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (xeroTenantId != null)
                requestOptions.HeaderParameters.Add("Xero-Tenant-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroTenantId)); // header parameter
            if (xeroApplicationId != null)
                requestOptions.HeaderParameters.Add("Xero-Application-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroApplicationId)); // header parameter
            if (xeroUserId != null)
                requestOptions.HeaderParameters.Add("Xero-User-Id", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(xeroUserId)); // header parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.GetAsync<Statements>("/Statements", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetStatements", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}