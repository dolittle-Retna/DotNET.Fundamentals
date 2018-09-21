namespace Security.for_Claims.when_equating_and_getting_hashcode
{
    using System.Collections.Generic;
    using System.Linq;
    using Dolittle.Security;
    using Machine.Specifications;

    [Subject(typeof(Claims), nameof(Equals))]
    public class two_claims_with_different_claims
    {
        static Claims first;
        static Claims second; 

        static bool is_equal_by_method;
        static bool is_equal_by_operator;
        static bool is_not_equal_by_operator;
        static bool hash_code_is_equal;
        Establish context = () => 
        {
            var list_one = new List<Claim>();
            list_one.Add(new Claim("4","4","4"));
            list_one.Add(new Claim("1","1","1"));
            var list_two = new List<Claim>();
            list_two.Add(new Claim("2","2","2"));
            list_two.Add(new Claim("3","3","3"));
            first = new Claims(list_one.ToArray());
            second = new Claims(list_two.ToArray());
        };

        Because of = () => 
        {
            is_equal_by_method = first.Equals(second);
            is_equal_by_operator = first == second;
            is_not_equal_by_operator = first != second;
            hash_code_is_equal = first.GetHashCode() == second.GetHashCode();
        };

        It should_not_be_equal_when_using_the_Equals_method = () => is_equal_by_method.ShouldBeFalse();
        It should_not_be_equal_when_using_the_equals_operator = () => is_equal_by_operator.ShouldBeFalse();
        It should_not_be_equal_when_using_the_not_equals_operator = () => is_not_equal_by_operator.ShouldBeTrue();
        It should_not_have_the_same_hashcode = () => hash_code_is_equal.ShouldBeFalse();
    }       
}