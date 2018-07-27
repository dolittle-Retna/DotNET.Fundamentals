﻿namespace Dolittle.PropertyBags.Specs.for_ObjectFactory.when_building
{
    using Machine.Specifications;
    using Dolittle.PropertyBags;
    using Dolittle.PropertyBags.Specs;
    using System;

    [Subject(typeof(ObjectFactory), "Build")]
    public class a_type_with_a_user_defined_factory : given.an_object_factory
    {
        static IObjectFactory factory;
        static RequiresSpecificConstructionByUser user_defined_type;
        static PropertyBag source;
        static object result;
        Establish context = () => 
        {
            factory = instance;
            user_defined_type = new RequiresSpecificConstructionByUser();
            source = user_defined_type.ToPropertyBag();
        };

        Because of = () => result = factory.Build(typeof(RequiresSpecificConstructionByUser), source);

        
        It should_build_an_instance_of_the_type = () => result.ShouldBeOfExactType<RequiresSpecificConstructionByUser>();
        It should_equal_the_source = () => result.ShouldEqual(user_defined_type);
    }
}