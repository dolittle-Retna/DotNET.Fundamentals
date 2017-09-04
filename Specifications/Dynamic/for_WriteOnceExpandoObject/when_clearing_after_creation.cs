﻿using System;
using Machine.Specifications;

namespace doLittle.Dynamic.Specs.Execution.for_WriteOnceExpandoObject
{
    [Subject(typeof(WriteOnceExpandoObject))]
    public class when_clearing_after_creation : given.a_write_once_expando_object_without_values
    {
        protected static Exception exception;
        Because of = () => exception = Catch.Exception(() => ((WriteOnceExpandoObject)values).Clear());
#pragma warning disable 0169        
        Behaves_like<a_read_only_container> a_read_only_container;
#pragma warning restore 0169        
    }
}
