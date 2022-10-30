﻿using System;
using System.Linq;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using System.Collections.Generic;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class GetTrackingCategories : TrackingCategoriesTest
    {
        [Test]
        public void Can_get_Tracking_Category()
        {
            Given_two_TrackingCategorys();

            Given_GetAll();

            List_contains_the_two_Tracking_Category();

            Given_both_Tracking_Category_is_deleted();
        }
    }
}
