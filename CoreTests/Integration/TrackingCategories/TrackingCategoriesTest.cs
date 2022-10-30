﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.TrackingCategories
{
    public class TrackingCategoriesTest : ApiWrapperTest
    {
        // Most of these tests will fail unless you go into Xero.com and delete the Tracking Categories. You may have to void invoices they are attached to as well.

        public TrackingCategory Given_a_TrackingCategory_with_Options()
        {
            var trackingCategory = Given_a_TrackingCategory();

            var option1 = Given_a_tracking_option();
            var option2 = Given_a_tracking_option();

            Api.TrackingCategories[trackingCategory.Id].Add(option1);
            var result = Api.TrackingCategories[trackingCategory.Id].Add(option2);

            return result;
        }

        public TrackingCategory Given_a_TrackingCategory()
        {
            var guid = Guid.NewGuid();

            var trackingCategory = Api.TrackingCategories.Add(new TrackingCategory
            {
                Id = guid,
                Name = "TheJoker " + guid,
                Status = TrackingCategoryStatus.Active
            });

            return trackingCategory;
        }

        public Option Given_a_tracking_option()
        {
            var guid = Guid.NewGuid();

            return new Option()
            {
                Id = guid,
                Name = guid.ToString()
            };
        }

        public List<Option> Given_a_tracking_options()
        {
            List<Option> options = new List<Option>();

            options.Add(Given_a_tracking_option());
            options.Add(Given_a_tracking_option());

            return options;
        }

        public Invoice Given_a_invoice_with_tracking_option_assigned_that_is_APPROVED(TrackingCategory ct, InvoiceType type = InvoiceType.AccountsPayable, InvoiceStatus status = InvoiceStatus.Draft)
        {
            Guid category = ct.Id;
            string name = ct.Name;
            string option = ct.Options.FirstOrDefault().Name;

            var invoice = Api.Create(new Invoice
            {
                Contact = new Contact { Name = "Wayne Enterprises" },
                Type = type,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = status,
                Items = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = "200",
                        Description = "Good value item",
                        LineAmount = 100m,
                        Tracking = new ItemTracking
                            {
                                new ItemTrackingCategory
                                {
                                    Id = category,
                                    Name = name,
                                    Option = option
                                }
                            }
                    }
                }

            });

            invoice.Status = InvoiceStatus.Authorised;
            return Api.Update(invoice);
        }
    }
}
