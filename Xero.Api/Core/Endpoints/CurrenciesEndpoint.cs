﻿using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface ICurrenciesEndpoint : IXeroCreateEndpoint<CurrenciesEndpoint, Currency, CurrenciesRequest, CurrenciesResponse>
    {
        
    }

    public class CurrenciesEndpoint : XeroCreateEndpoint<CurrenciesEndpoint, Currency, CurrenciesRequest, CurrenciesResponse>,
        ICurrenciesEndpoint
    {
        public CurrenciesEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public CurrenciesEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/Currencies")
        {
        }
    }
}