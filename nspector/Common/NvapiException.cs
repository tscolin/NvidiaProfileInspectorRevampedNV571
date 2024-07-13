using System;
using nspector.Native.NVAPI2;

namespace nspector.Common
{
    public class NvapiException(string function, NvAPI_Status status) : Exception(function + " failed: " + status)
    {
        public readonly NvAPI_Status Status = status;
    }

    public class NvapiAddApplicationException(string applicationName) : NvapiException("DRS_CreateApplication", NvAPI_Status.NVAPI_EXECUTABLE_ALREADY_IN_USE)
    {
        public readonly string ApplicationName = applicationName;
    }
}
