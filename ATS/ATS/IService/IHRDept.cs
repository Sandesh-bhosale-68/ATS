using ATS.DatabaseDB;
using ATS.Models;

namespace ATS.IService
{
    public interface IHRDept
    {
        Task<List<AssesmentSelection>> ListAssismentAsync();
        Task<List<AssesmentResult>> InterviewStatusAsync();
        Task SentRejegnationMassaaageAsync(int masterID, string Resignation);
        List<Department> GetListOfDepartment();
        List<InterviewrsDept> GetInterviewerList(string selectedValue);
         TblCandidateDetail GetCandidateDetails(string MasterID);
        List<Department> DepartmentList();
        List<TblDesignation> GetDesignationList(string selectedValue);
        Task SentRejegnationMassaaageForaccessmentAsync(int masterID, string Resignation);
        void SendMailForInterview(string? candidateMasterid, string interviewStage, string interviewer, DateTime? date, string meeting);
        List<TblQualification1> GetEducationDetails(string MasterID);
        Task SendAssesntMentEmail(string masterId);
        void ConfirmDetails(OnboardingModel model);
        void SaveDocument(CandidateImage cd  , string masterID);
    }
}
