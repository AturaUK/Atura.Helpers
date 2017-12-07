using Atura.Helpers.Guard;

namespace Samples
{
    public class MyClass
    {
        public void MyMethod(string parameter)
        {
            Guard.AgainstNull(parameter, nameof(parameter));

            // do stuff
        }
    }
}
