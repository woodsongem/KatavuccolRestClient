using System.Collections.Generic;

namespace KatavuccolRestClient.DataContracts
{
    public class IDelete
    {
         object Request { get; set; }
        string Url { get; }
        List<KeyValuePair> Headers { get; set; }
        string Endpoint { get; set; }
    }
}