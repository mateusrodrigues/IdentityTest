using System;

namespace IdentityTest.Constants
{
    public static class Addresses
    {
        public static Uri ApiAddress
        {
            get
            {
                return new Uri("https://localhost:44302");
            }
        }

        public static Uri AuthAddress
        {
            get
            {
                return new Uri("https://localhost:44371");
            }
        }

        public static Uri MvcAddress
        {
            get
            {
                return new Uri("https://localhost:44320");
            }
        }
    }
}
