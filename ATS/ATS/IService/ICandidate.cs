
using ATS.DatabaseDB;
using ATS.Models;
using ATS.SpResult;
using static System.Net.WebRequestMethods;

namespace ATS.IService
{
    public interface ICandidate
    {

        //IEnumerable<USP_Get_HRMIS_Data> Get_HRMIS_Data(string Operation, string MobailNumber);

         Task<List<Source>> TestAsyncMethod();
        Task<List<Position>> GetPositioAsync();
        Task<List<LocationMaster>> LocationAsync();
        void SaveImages(CandidateImage images);
        Task<List<Source>> FillCandidateDetailsAsync();
        List<SubSource> SubDisposiotion(string disposition);
        void InsertCandidateDetails(CandidateEntryDetails candidateEntry, CandidateEntrySessionData fillCandidateData, PersonalDetailsModel personalDetails, QualificationDetailsModel qualificationDetails, WorkExperienceModel workExpData, AddressModel currentAddressData, AddressModel permanentAddressData, CNDData candeidateOther);
        Task<List<Dictionary<string, object>>> Get_HRMIS_DataAsync(string Operation, string MobailNumber);
        Task<List<Dictionary<string, object>>> Get_HRMIS_DataCheckActiveEmpCodeAsync(string Operation, string MobailNumber);
        string[] Save_OTPDetails(string MobailNumber , string OTP , string OTPEnail);
        List<Dictionary<string, object>> Get_OTPDetails(string mobileNumber, string  OTP, string OTPEnail);
        TblCandidateDetail GetLoginCredential( string UserName, string Password);
    }
}
