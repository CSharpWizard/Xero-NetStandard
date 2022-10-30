﻿using Xero.Api.Example.Console.Helpers;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Example.Console.Authenticators
{
    public class PublicAuthenticator : PublicAuthenticatorBase
    {
        public PublicAuthenticator(ITokenStoreAsync store)
            : this(store, new XeroApiSettings())
        {
        }

        public PublicAuthenticator(ITokenStoreAsync store, IXeroApiSettings xeroApiSettings) 
            : base(store, xeroApiSettings)
        {
        }

        protected override string AuthorizeUser(IToken token, string scope = null, bool redirectOnError = false)
        {
            var authorizeUrl = GetAuthorizeUrl(token, scope, redirectOnError);

            ProcessHelper.OpenBrowser(authorizeUrl);

            System.Console.WriteLine("Enter the PIN given on the web page");

            return System.Console.ReadLine();
        }
    }
}
