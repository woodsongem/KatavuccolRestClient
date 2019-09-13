using System.Collections.Generic;

namespace KatavuccolRestClient.DataContracts
{
    public class IGet
    {
        string Url { get; }
        List<KeyValuePair> Headers { get; set; }
        string Endpoint { get; set; }
    }
}