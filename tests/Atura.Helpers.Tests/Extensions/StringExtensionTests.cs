using Atura.Helpers.Extensions;
using Shouldly;
using Xunit;

namespace Atura.Helpers.Tests.Extensions
{
    public class StringExtensionTests
    {
        [Fact]
        public void IsMissing_ReturnsTrue_WhenStringIsNull()
        {
            const string aNullString = null;

            var result = aNullString.IsMissing();

            result.ShouldBeTrue();
        }

        [Fact]
        public void IsMissing_ReturnsTrue_WhenStringIsEmpty()
        {
            var aNullString = string.Empty;

            var result = aNullString.IsMissing();

            result.ShouldBeTrue();
        }

        [Fact]
        public void IsMissing_ReturnsTrue_WhenStringIsWhitespace()
        {
            const string aNullString = "  ";

            var result = aNullString.IsMissing();

            result.ShouldBeTrue();
        }

        [Fact]
        public void IsMissing_ReturnsFalse_WhenStringIsNotNullAndHasSomeCharacters()
        {
            const string aNullString = "a-string";

            var result = aNullString.IsMissing();

            result.ShouldBeFalse();
        }

        [Fact]
        public void IsPresent_ReturnsFalse_WhenStringIsNull()
        {
            const string aNullString = null;

            var result = aNullString.IsPresent();

            result.ShouldBeFalse();
        }

        [Fact]
        public void IsPresent_ReturnsFalse_WhenStringIsEmpty()
        {
            var aNullString = string.Empty;

            var result = aNullString.IsPresent();

            result.ShouldBeFalse();
        }

        [Fact]
        public void IsPresent_ReturnsFalse_WhenStringIsWhitespace()
        {
            const string aNullString = "  ";

            var result = aNullString.IsPresent();

            result.ShouldBeFalse();
        }

        [Fact]
        public void IsPresent_ReturnsTrue_WhenStringIsNotNullAndHasSomeCharacters()
        {
            const string aNullString = "a-string";

            var result = aNullString.IsPresent();

            result.ShouldBeTrue();
        }
    }
}
