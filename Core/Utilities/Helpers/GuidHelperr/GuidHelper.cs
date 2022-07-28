using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.GuidHelperr
{
    public static class GuidHelper
    {
        public static string CreateGuid()
        {

            return Guid.NewGuid().ToString();
                                             
        }
    }
}
