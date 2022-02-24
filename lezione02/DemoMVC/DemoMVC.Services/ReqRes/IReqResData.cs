using DemoMVC.Models.ReqRes;
using System.Threading.Tasks;

namespace DemoMVC.Services.ReqRes
{
    public interface IReqResData
    {
        Task<ReqResData> EstraiDati();
        void CancellaRichiesta();
        Task<ReqResResponse> Crea(ReqResNewUser newUser);
    }
}
