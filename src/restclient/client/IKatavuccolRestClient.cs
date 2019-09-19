

using RestClient.DataContracts;

namespace RestClient.Client
{
    public interface IKatavuccolRestClient
    {
        RestResponse Get(IGet get);

        RestResponse Post(IPost get);

        RestResponse Delete(IDelete get);

        RestResponse Put(IPut get);
    }
}