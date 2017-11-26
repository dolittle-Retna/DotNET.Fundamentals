﻿using Machine.Specifications;
using It = Machine.Specifications.It;

namespace doLittle.Applications.Specs.for_ApplicationArtifactIdentifier
{
    public class when_comparing_two_instances_representing_different_artifacts : given.different_artifacts
    {
        static bool result;

        Because of = () => result = identifier_a == identifier_b;

        It should_not_be_considered_the_same = () => result.ShouldBeFalse();
    }
}