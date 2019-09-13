using System.Collections.Generic;

namespace KatavuccolRestClient.DataContracts
{
    public interface IPut
    {
        object Request { get; set; }
        string Url { get; }
        List<KeyValuePair> Headers { get; set; }
        string Endpoint { get; set; }
    }
}