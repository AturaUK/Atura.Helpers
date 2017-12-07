using System;
using Shouldly;
using Xunit;

namespace Atura.Helpers.Tests.Guard
{
    public class GuardTests
    {
        private const string ParamName = "thisIsTheParam";

        [Fact]
        public void AgainstNull_ThrowsArgumentNullExceptionWithCorrectMessage_WhenTheObjectIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => Helpers.Guard.Guard.AgainstNull<string>(null, ParamName));

            exception.Message.ShouldBe($"Value cannot be null.{Environment.NewLine}Parameter name: {ParamName}");
        }

        [Fact]
        public void AgainstNull_DoesNotThrowException_WhenTheObjectIsNull()
        {
            Helpers.Guard.Guard.AgainstNull("hello", ParamName);

            // no assert here since the absense of an exception means we've passed!
        }
    }
}
