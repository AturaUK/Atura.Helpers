using System;

namespace Atura.Helpers.Guard
{
    public static class Guard
    {
        public static void AgainstNull<T>(T parameter, string parameterName) where T : class
        {
            if (parameter == null) throw new ArgumentNullException(parameterName);
        }
    }
}