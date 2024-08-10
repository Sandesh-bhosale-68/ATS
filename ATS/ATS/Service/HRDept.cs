
using ATS.DatabaseDB;
using ATS.IService;
using ATS.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;

namespace ATS.Service
{
    public class HRDept : IHRDept
    {
        private readonly HRMISContext _context;
        public HRDept(HRMISContext hec)
        {

            _context = hec;
        }

        public void SendMailForInterview(string? candidateMasterid, string interviewStage, string interviewer, DateTime? date, string meeting)
        {
            try
            {
                var Candidate = _context.TblCandidateDetails.Where(x => x.Masterid == Convert.ToInt32(candidateMasterid)).Select(x => new { Fname = x.Fname, Emaild = x.Emaild }).FirstOrDefault();
                var Interviewr = _context.InterviewrsDepts.Where(x => x.InterviewId == Convert.ToInt32(interviewer)).Select(x => new { InterviewerName = x.InterviewerName, InterviewEmail = x.InterviewEmail }).FirstOrDefault();
                CL_SendMail cs = new CL_SendMail();
                cs.sendMailToCandidateinterview(Candidate.Fname, Candidate.Emaild, interviewStage, date, meeting);
                cs.sendMailToCandidateinterview(Interviewr.InterviewerName, Interviewr.InterviewEmail, interviewStage, date, meeting);

            }
            catch (Exception ex)
            {

            }
     
        }

        public List<InterviewrsDept> GetInterviewerList(string selectedValue)
        {
            var data = _context.InterviewrsDepts.Where(x=> x.DepartmentId== Convert.ToInt32(selectedValue)).Select( x=> new InterviewrsDept { InterviewId= x.InterviewId , InterviewerName=x.InterviewerName , InterviewEmail= x.InterviewEmail}).ToList(); ;
            return data;
        }

        public List<Department> GetListOfDepartment()
        {
            var data = _context.Departments.ToList();
            return data;
        }

        public async Task<List<AssesmentResult>> InterviewStatusAsync()
        {         
            var data = await _context.AssesmentResults.ToListAsync();
            return data;
        }

        public async Task<List<AssesmentSelection>> ListAssismentAsync()
        {
            List<AssesmentSelection> data = await _context.TblCandidateDetails.Select(x => new AssesmentSelection
            {
                Masterid = x.Masterid,
                FirstName = x.Fname,
                LastName = x.Lname,
                Location = x.Location,
                Position = x.Postappliedfor,
                Gender = x.Gender,
                Education = x.HighestQualification,
                PassingYear = x.YearofPassing,
                Percentage = x.Percentage,
                Experience = x.Totalexpr
            }).ToListAsync();

            return data;
        }

      

   

        public async Task SentRejegnationMassaaageAsync(int masterID, string Resignation)
        {
            try
            {
                CL_SendMail cs = new CL_SendMail();
                var candidateInfo = await _context.TblCandidateDetails.Where(x => x.Masterid == masterID).Select(x => new { EmailID = x.Emaild, FirstName = x.Fname }).FirstOrDefaultAsync();
                if (candidateInfo != null)
                {
                    var EmailID = candidateInfo.EmailID;
                    var FirstName = candidateInfo.FirstName;
                    cs.sendMail(FirstName, Convert.ToString(masterID), Resignation, EmailID);
                }

                var candidateToRemove = await _context.AssesmentResults.FirstOrDefaultAsync(x => x.MasterId == masterID);
                if (candidateToRemove != null)
                {
                    _context.AssesmentResults.Remove(candidateToRemove);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public TblCandidateDetail GetCandidateDetails(string MasterID)
        {
            var data = _context.TblCandidateDetails.Where(x => x.Masterid == Convert.ToInt32(MasterID)).FirstOrDefault();
            return data; 
        }

        public List<Department> DepartmentList()
        {
            var data = _context.Departments.ToList();
            return data;
        }

        public List<TblDesignation> GetDesignationList(string selectedValue)
        {
            var data = _context.TblDesignations.Where(x => x.DepartMentId == Convert.ToInt32(selectedValue)).Distinct().ToList();
            return data;
        }

        public List<TblQualification1> GetEducationDetails(string MasterID)
        {
            var data = _context.TblQualification1s.Where(x => x.Masterid == Convert.ToInt32(MasterID)).ToList();
            return data; 
        }

        public async Task SentRejegnationMassaaageForaccessmentAsync(int masterID, string Resignation)
        {
            try
            {
                CL_SendMail cs = new CL_SendMail();
                var candidateInfo = await _context.TblCandidateDetails.Where(x => x.Masterid == masterID).Select(x => new { EmailID = x.Emaild, FirstName = x.Fname }).FirstOrDefaultAsync();
                if (candidateInfo != null)
                {
                    var EmailID = candidateInfo.EmailID;
                    var FirstName = candidateInfo.FirstName;
                    cs.sendMail(FirstName, Convert.ToString(masterID), Resignation, EmailID);
                }             
            }
            catch (Exception ex)
            {

            }
        }

        public async  Task SendAssesntMentEmail(string masterID)
        {
            var AssesmentLink = "Test Link";
            CL_SendMail cs = new CL_SendMail();
            var candidateInfo = await _context.TblCandidateDetails.Where(x => x.Masterid == Convert.ToInt32( masterID)).Select(x => new { EmailID = x.Emaild, FirstName = x.Fname }).FirstOrDefaultAsync();
            if (candidateInfo != null)
            {
                var EmailID = candidateInfo.EmailID;
                var FirstName = candidateInfo.FirstName;
                cs.sendMail(FirstName, Convert.ToString(masterID), AssesmentLink, EmailID);
            }
            
        }

        public void ConfirmDetails(OnboardingModel model)
        {
            var candidateDetails = _context.TblCandidateDetails.Where(x => x.AadharCard == model.AdharNumber).FirstOrDefault();
            if (candidateDetails != null)
            {
                candidateDetails.Fname = model.FirstName;
                candidateDetails.Fathername = model.FatherName;
                candidateDetails.Mothername = model.MotherName;
                candidateDetails.Lname = model.LastName;
                candidateDetails.Mname = model.FatherName;
                candidateDetails.AdharName = model.AdharName;
                candidateDetails.Gender = model.Gender;
                candidateDetails.Emaild = model.Email;
                candidateDetails.HighestQualification = model.EducationDetails;
                candidateDetails.Totalexpr = model.WorkExperience;
                candidateDetails.Currentdesig = model.Designation;
                candidateDetails.Emergcontno = model.EmergencyContactDetails;
                candidateDetails.Bloodgrp = model.BloodGroup;
                candidateDetails.EffortRefEmpid = model.Ref1;
                if(model.CTC != null)
                {
                    candidateDetails.Lastctcpm = model.CTC;
                }
                if (model.NAPS != null)
                {
                    candidateDetails.Lastctcpm = model.NAPS;
                }
                if (model.NATS != null)
                {
                    candidateDetails.Lastctcpm = model.NATS;
                }
                candidateDetails.Joiningdesig = model.Designation;           
                candidateDetails.Currentdesig = model.DesignationPRV;
                _context.SaveChanges();
            }
            var ExprenceDetails = _context.ExperienceDetails.Where(x => x.MasterId == Convert.ToInt32(candidateDetails.Masterid)).FirstOrDefault();
            if(ExprenceDetails != null)
            {
                ExprenceDetails.CompanyName = model.LastOrganization;
                ExprenceDetails.Designation = model.DesignationPRV;
                ExprenceDetails.FromDate = model.LastOrganizationJoinDate;
                ExprenceDetails.ToDate = model.LastOrganizationLWD;
                ExprenceDetails.TotalExperience = model.WorkExperience;
                ExprenceDetails.Process = model.DesignationPRV;
                if (model.CTC != null)
                {
                    ExprenceDetails.Ctc = model.CTC;
                }
                if (model.NAPS != null)
                {
                    ExprenceDetails.Ctc = model.NAPS;
                }
                if (model.NATS != null)
                {
                    ExprenceDetails.Ctc = model.NATS;
                }

                _context.SaveChanges();
            }
            else
            {
               
            }
        }

        public void SaveDocument(CandidateImage cd, string masterId)
        {
            SaveDocumentHelper(cd.PhotographfName, cd.photograph, masterId);
            SaveDocumentHelper(cd.AddProoffName, cd.addressProof, masterId);
            SaveDocumentHelper(cd.HigherEduName, cd.higherEducation, masterId);
            SaveDocumentHelper(cd.LastEmployerName, cd.lastEmployer, masterId);
            SaveDocumentHelper(cd.NationalityProofName, cd.nationalityProof, masterId);
     
        }

        private void SaveDocumentHelper(string imageName, byte[] imageData, string masterId)
        {
            var existingEntity = _context.TblCandidateDocuments.Local.FirstOrDefault(e => e.ImageId == 0); // Adjust as needed
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            TblCandidateDocument candidateDocument = new TblCandidateDocument
            {
                MasterId = Convert.ToInt32(masterId),
                ImageName = imageName,
                ImageData = imageData
            };

            _context.TblCandidateDocuments.Add(candidateDocument);
            _context.SaveChanges();
        }
    }
}
