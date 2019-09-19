using System.Collections.Generic;

namespace RestClient.DataContracts
{
    public interface IGet
    {
        string Url { get; }
        List<KeyValuePair> Headers { get; set; }
        string Endpoint { get; set; }
    }
}