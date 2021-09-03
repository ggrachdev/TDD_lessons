﻿using System;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace _013_EventRelatedTests
{
    [TestFixture]
    class EventRelatedTests
    {
        [Test]
        public static void EventAttachedTest()
        {
            MockRepository rhinoEngine = new MockRepository();

            var view = rhinoEngine.DynamicMock<IView>();

            using (rhinoEngine.Record())
            {
                view.Load += null;
                LastCall.Constraints(new Anything());
            }

            Presenter presenter = new Presenter(view, null);

            rhinoEngine.Verify(view);
        }
    }
}
