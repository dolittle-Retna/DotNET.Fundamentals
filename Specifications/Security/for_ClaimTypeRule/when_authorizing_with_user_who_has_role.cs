﻿using System.Threading;
using Dolittle.Security;
using Machine.Specifications;

namespace Dolittle.Security.Specs.for_ClaimTypeRule
{
    [Subject(typeof (ClaimTypeRule))]
    public class when_authorizing_with_user_who_has_role : given.a_claim_type_rule
    {
        static bool result;

        Establish context = () => user.Setup(u=>u.HasClaimType(required_claim)).Returns(true);

        Because of = () => result = rule.IsAuthorized(new object());

        It should_be_authorized = () => result.ShouldBeTrue();
    }
}