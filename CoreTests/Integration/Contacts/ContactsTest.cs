﻿using System;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.Contacts
{
    public abstract  class ContactsTest : ApiWrapperTest
    {
        protected Contact Given_a_contact()
        {
            var contact = Api.Create(new Contact
            {
                Name = "Peter " + Guid.NewGuid().ToString("N")
            });
            return contact;
        }
    }
}
