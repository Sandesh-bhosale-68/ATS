using ATS.DatabaseDB;
using ATS.IService;
using ATS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Packaging.Licenses;

using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.Drawing.Imaging;
using System.Drawing;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Size = SixLabors.ImageSharp.Size;
using Image = SixLabors.ImageSharp.Image;

using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ATS.Controllers
{
    public class HrWorkDeptController : Controller
    {

        private readonly IHRDept _hrdept;

        public HrWorkDeptController(IHRDept HrDept)
        {
            _hrdept = HrDept;
        }
        [HttpPost]
        public IActionResult UploadDocument(DocumentUpload model)
        {
            if(ModelState.IsValid)
            {
                CandidateImage cd = new CandidateImage();
                if (model != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        if (model.AddProof != null)
                        {
                            model.AddProof.CopyTo(ms);
                            var compressedAddressProof = CompressImage(ms.ToArray(), 10);
                            cd.addressProof = compressedAddressProof;
                        }

                        ms.SetLength(0);

                        if (model.NationalityProof != null)
                        {
                            model.NationalityProof.CopyTo(ms);
                            var compressedNationalityProof = CompressImage(ms.ToArray(), 10);
                            cd.nationalityProof = compressedNationalityProof;
                        }

                        ms.SetLength(0);

                        if (model.HigherEdu != null)
                        {
                            model.HigherEdu.CopyTo(ms);
                            var compressedHigherEdu = CompressImage(ms.ToArray(), 10);
                            cd.higherEducation = compressedHigherEdu;
                        }

                        ms.SetLength(0);

                        if (model.LastEmployer != null)
                        {
                            model.LastEmployer.CopyTo(ms);
                            var compressedLastEmployer = CompressImage(ms.ToArray(), 10);
                            cd.lastEmployer = compressedLastEmployer;
                        }

                        ms.SetLength(0);

                        if (model.Photograph != null)
                        {
                            model.Photograph.CopyTo(ms);
                            var compressedPhotograph = CompressImage(ms.ToArray(), 10);
                            cd.photograph = compressedPhotograph;
                        }


                        cd.PhotographfName = model.Photograph.FileName;
                        cd.AddProoffName = model.AddProof.FileName;
                        cd.NationalityProofName = model.NationalityProof.FileName;
                        cd.HigherEduName = model.HigherEdu.FileName;
                        cd.LastEmployerName = model.LastEmployer.FileName;
                        string MasterID = HttpContext.Session.GetString("MasterID");
                        _hrdept.SaveDocument(cd, MasterID);
                       
                    }
                }
               

            }
            else
            {
                ViewBag.Validation = "All Fields Requrired....!!";
            }
            return View();
        }
        private byte[] CompressImage(byte[] imageData, int targetSizeKB)
        {
            using (var ms = new MemoryStream(imageData))
            {
                using (var image = Image.Load(ms))
                {
                    using (var compressedMs = new MemoryStream())
                    {
                        var encoder = new JpegEncoder(); // Adjust encoder as needed

                        image.Save(compressedMs, encoder);

                        while (compressedMs.Length / 1024 > targetSizeKB)
                        {
                            image.Mutate(x => x.Resize(new ResizeOptions
                            {
                                Size = new Size(image.Width - 10, (int)(image.Height * (image.Width - 10) / (double)image.Width)),
                                Mode = ResizeMode.Max
                            }));

                            compressedMs.Position = 0;
                            compressedMs.SetLength(0);

                            image.Save(compressedMs, encoder); // Adjust encoder as needed
                        }

                        return compressedMs.ToArray();
                    }
                }
            }
        }
        public IActionResult UploadDocument()
        {
          
            return View();
        }
        
        [HttpPost]
        public IActionResult Onbourding( OnboardingModel model)
        {
            _hrdept.ConfirmDetails(model);
            AddDropDawonOnboarding();
            return View(model);
        }
        public IActionResult Onbourding()
        {
            string MasterID = HttpContext.Session.GetString("MasterID");
            var Candidate = _hrdept.GetCandidateDetails(MasterID);
            var EducationDetails = _hrdept.GetEducationDetails(MasterID);
            var PostGraduation = EducationDetails.FirstOrDefault(x => x.QualiLevel.Contains("PostGraduate"));
            var Bachelor = EducationDetails.FirstOrDefault(x => x.QualiLevel.Contains("Graduate"));
            var Diploma = EducationDetails.FirstOrDefault(x => x.QualiLevel.Contains("Diploma"));
            var HSC = EducationDetails.FirstOrDefault(x => x.QualiLevel.Contains("HSC"));

            OnboardingModel onboardingData = new OnboardingModel
            {
                FirstName = Candidate.Fname,
                FatherName = Candidate.Fathername,
                MotherName = Candidate.Mothername,
                LastName = Candidate.Lname,
                AdharName = Candidate.AdharName,
                Gender = Candidate.Gender,
                AdharNumber = Candidate.AadharCard,
                Email = Candidate.Emaild,
                EducationDetails = Candidate.HighestQualification,
                PostGraduate = PostGraduation.Yrofpass.ToString(),
                Graduate = Bachelor.Yrofpass.ToString(),
                Diploma = Diploma.Yrofpass.ToString(),
                HSC = HSC.Yrofpass.ToString(),
                WorkExperience = Candidate.Totalexpr,
                LastOrganization = "",
                LastOrganizationJoinDate = DateTime.Now,
                  LastOrganizationLWD = DateTime.Now,
                LastOrganizationCTC = Candidate.AnnualCtc,
                Designation = Candidate.Postappliedfor,
                EmergencyContactDetails = Candidate.Emergcontno,
                BloodGroup = Candidate.Bloodgrp,
                Ref1 = Candidate.Refreccontact,
                Ref2 = Candidate.Refrecname
              
            };

            AddDropDawonOnboarding();
            return View(onboardingData);
        }

        public void AddDropDawonOnboarding()
        {
            var designation = _hrdept.DepartmentList();
            var DesignationList = designation.Select(x => new SelectListItem { Value = x.DepartmentId.ToString(), Text = x.DepartmentName.ToString() }).Distinct().ToList();
            ViewBag.Department = new SelectList(DesignationList, "Value", "Text");

            var salaryList = new List<SelectListItem>
                {
                  new SelectListItem { Value = "", Text = "Select" },
                    new SelectListItem { Value = "NAPS", Text = "NAPS" },
                    new SelectListItem { Value = "NATS", Text = "NATS" },
                    new SelectListItem { Value = "CTC", Text = "CTC" },
                    // Add more items as needed
                };
            ViewBag.Salary = new SelectList(salaryList, "Value", "Text");


            var NAPS = new List<SelectListItem>
                {
                  new SelectListItem { Value = "", Text = "Select" },
                    new SelectListItem { Value = "NAPS", Text = "400000" },
                    new SelectListItem { Value = "NATS", Text = "300000" },
                    new SelectListItem { Value = "CTC", Text = "200000" },
                    // Add more items as needed
                };
            ViewBag.NAPS = new SelectList(NAPS, "Value", "Text");



            var NATS = new List<SelectListItem>
                {
                  new SelectListItem { Value = "", Text = "Select" },
                    new SelectListItem { Value = "NAPS", Text = "400000" },
                    new SelectListItem { Value = "NATS", Text = "300000" },
                    new SelectListItem { Value = "CTC", Text = "200000" },
                    // Add more items as needed
                };
            ViewBag.NATS = new SelectList(NATS, "Value", "Text");


            var CTC = new List<SelectListItem>
                {
                  new SelectListItem { Value = "", Text = "Select" },
                    new SelectListItem { Value = "NAPS", Text = "400000" },
                    new SelectListItem { Value = "NATS", Text = "300000" },
                    new SelectListItem { Value = "CTC", Text = "200000" },
                    // Add more items as needed
                };
            ViewBag.CTC = new SelectList(CTC, "CTC", "Text");
        }

        [HttpPost]
        public ActionResult HandleDesignation(string selectedValue)
        {
            var data = _hrdept.GetDesignationList(selectedValue);
            var subDispositionList = data.Where(x => x.DepartMentId == Convert.ToInt32(selectedValue)).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.DesignationName }) .DistinctBy(x => x.Text).ToList();
            return Json(subDispositionList);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FunctionalInterview(FunctionlInterview interviewData)
        {
            
            string CandidateMasterid = HttpContext.Session.GetString("MasterID");
            _hrdept.SendMailForInterview(CandidateMasterid , interviewData.InterviewStage , interviewData.Interviewer , interviewData.Date , interviewData.Meeting);

            return  RedirectToAction("AssignInterview");
        }
        [HttpPost]
         public IActionResult InterviewrSelection(string selectedValue)
        {
            var data = _hrdept.GetInterviewerList(selectedValue);
            var subDispositionList = data.Select(x => new SelectListItem { Value = x.InterviewId.ToString(), Text = x.InterviewerName }).Distinct().ToList();
            subDispositionList.Insert(0, new SelectListItem { Value = "0", Text = "Select Interviwer" });

            return Json(subDispositionList);
        }
        public IActionResult DynamicInterviewStage()
        {
            try
            {
                string interview1 = HttpContext.Session.GetString("Interview1");
                string Interview2 = HttpContext.Session.GetString("Interview2");
                string Interview3 = HttpContext.Session.GetString("Interview3");
                string MasterID = HttpContext.Session.GetString("MasterID");

                if (interview1 == "-")
                {
                    List<SelectListItem> InterviewStage = new List<SelectListItem>
                {
                    new SelectListItem { Value = "interview1", Text = "Interview 1" },
                    new SelectListItem { Value = "interview2", Text = "Interview 2" },
                    new SelectListItem { Value = "interview3", Text = "Interview 3" }
                };
                    ViewBag.AgeAlert = "Interview Stage 1";
                    ViewBag.InterviewStage = new SelectList(InterviewStage, "Value", "Text");
                }
                if (interview1 == "Selected" && Interview2 == "-")
                {
                    List<SelectListItem> InterviewStage = new List<SelectListItem>
                {
                     new SelectListItem { Value = "interview2", Text = "Interview 2" },
                      new SelectListItem { Value = "interview3", Text = "Interview 3" }
                };
                    ViewBag.AgeAlert = "Interview Stage 2";
                    ViewBag.InterviewStage = new SelectList(InterviewStage, "Value", "Text");
                }

                if (interview1 != "Rejected" && Interview2 == "Selected" && Interview3 == "-")
                {
                    List<SelectListItem> InterviewStage = new List<SelectListItem>
                        {
                              new SelectListItem { Value = "interview3", Text = "Interview 3" }
                        };
                    ViewBag.AgeAlert = "Interview Stage 3";
                    ViewBag.InterviewStage = new SelectList(InterviewStage, "Value", "Text");
                }


          

                List<Department> data = _hrdept.GetListOfDepartment();
                var Department = data.Select(x => new SelectListItem { Value = x.DepartmentId.ToString(), Text = x.DepartmentName.ToString() }).Distinct().ToList();
                Department.Insert(0, new SelectListItem { Value = "0", Text = "Select Department" });

                ViewBag.Department = new SelectList(Department, "Value", "Text");

              
            }
            catch(Exception ex)
            {

            }
         
            return View();
        }

        [HttpPost]
        public IActionResult AssignInterviewDyanamicStage(int masterId, string interview1, string interview2, string interview3)
        {
            HttpContext.Session.SetString("Interview1", interview1);
            HttpContext.Session.SetString("Interview2", interview2);
            HttpContext.Session.SetString("Interview3", interview3);
            HttpContext.Session.SetString("MasterID",Convert.ToString(masterId) );

            if (interview1 == "Selected" && interview2 == "Selected" && interview3 == "Selected")
            {
                return Ok("Condition not False");
            }
            else
            {
                return Ok("Condition not true");
            }
    
        }
        [HttpPost]
        public async Task<IActionResult> RejectionMassge(int masterId, string rejectionMessage)
        {
            await _hrdept.SentRejegnationMassaaageAsync(masterId, rejectionMessage);

            return Json(new { success = true, message = "Rejection message processed successfully." });
        }

        [HttpPost]
        public async Task<IActionResult> RejectionMassgeForAccessment(int masterId, string rejectionMessage)
        {
            await _hrdept.SentRejegnationMassaaageForaccessmentAsync(masterId, rejectionMessage);

            return Json(new { success = true, message = "Rejection message processed successfully." });
        }
        public async Task<IActionResult> AssesmentSelection()
        {
            List<AssesmentSelection> data = await _hrdept.ListAssismentAsync();
            return View(data);
        }

        public async Task<IActionResult> AssignInterview()
        {
            List<AssesmentResult> data = await _hrdept.InterviewStatusAsync();
            return View(data);
        }


        [HttpPost]
        public async Task<IActionResult> SendAssesmentLink(string masterId)
        {
            await _hrdept.SendAssesntMentEmail(masterId);
            return Json(new { success = true }); 
        }
    }
}
