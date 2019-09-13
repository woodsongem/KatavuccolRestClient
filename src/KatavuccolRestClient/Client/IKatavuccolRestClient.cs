using KatavuccolRestClient.DataContracts;

namespace KatavuccolRestClient.Client
{
    public interface IKatavuccolRestClient
    {
         RestResponse Get(IGet get);

        // RestResponse Post(IPost get);

        // RestResponse Delete(IDelete get);

        // RestResponse Put(IPut get);
    }
}