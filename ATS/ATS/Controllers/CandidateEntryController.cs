using ATS.IService;
using ATS.Models;
using ATS.SpResult;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NuGet.Protocol.Plugins;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.Collections.Generic;
using System.Data;

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
using ATS.DatabaseDB;

namespace ATS.Controllers
{
    public class CandidateEntryController : Controller
    {

        private readonly ICandidate _candidateService;

        public CandidateEntryController(ICandidate candidateService)
        {
            _candidateService = candidateService;
        }
        public async Task<IActionResult> Index()
        {
            await _candidateService.TestAsyncMethod();

            return View();
        }
        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogIn credential)
        {
            var LogIn = _candidateService.GetLoginCredential(credential.UserName, credential.Password);
            if (LogIn != null )
            {
                return RedirectToAction("AddCandicateEntry");
            }
            else
            {
                return View();
            }
       
        }

        [HttpPost]
        public IActionResult OtherCandidateDetailsInfo([FromBody] CNDData formData)
        {
            try
            {                        
                string CandidateEntry = HttpContext.Session.GetString("CandidateEntry");
                string fillCandidateDetailsJson = HttpContext.Session.GetString("FillCandidateDetails");
                string PersnolDetails = HttpContext.Session.GetString("PersnolDetails");
                string QualificationDetails = HttpContext.Session.GetString("QualificationDetails");
                string WorkExprience = HttpContext.Session.GetString("WorkExprience");
                string Currentddress = HttpContext.Session.GetString("Currentddress");
                string PermentAddress = HttpContext.Session.GetString("PermentAddress");


                CandidateEntryDetails CandidateEntryData = JsonConvert.DeserializeObject<CandidateEntryDetails>(CandidateEntry);
                CandidateEntrySessionData FillCandidateData = JsonConvert.DeserializeObject<CandidateEntrySessionData>(fillCandidateDetailsJson);
                PersonalDetailsModel PersnolDetailsData = JsonConvert.DeserializeObject<PersonalDetailsModel>(PersnolDetails);
                QualificationDetailsModel QualificationDetailsData = JsonConvert.DeserializeObject<QualificationDetailsModel>(QualificationDetails);
                WorkExperienceModel WorkExpData = JsonConvert.DeserializeObject<WorkExperienceModel>(WorkExprience);
                AddressModel CurrentAddressdata = JsonConvert.DeserializeObject<AddressModel>(Currentddress);
                AddressModel PermentAddressData = JsonConvert.DeserializeObject<AddressModel>(PermentAddress);
                CNDData otherCandidateDetails = formData;
                _candidateService.InsertCandidateDetails(CandidateEntryData , FillCandidateData , PersnolDetailsData , QualificationDetailsData , WorkExpData , CurrentAddressdata , PermentAddressData , otherCandidateDetails);
              
                return RedirectToAction("ThankYou");
              
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = "Error processing data: " + ex.Message });
            }
        }
        public IActionResult CandidateOtherDetails()
        {
            return View();
        }
    
        public IActionResult PermanentAddress()
        {
            return View();
        }



        [HttpPost]
        public IActionResult PermanentAddress(AddressModel pmodel)
        {
            string CurrentAddresssToP = HttpContext.Session.GetString("Currentddress");

            if (!string.IsNullOrEmpty(CurrentAddresssToP))
            {
                AddressModel model = JsonConvert.DeserializeObject<AddressModel>(CurrentAddresssToP);

                // Use the model as needed

                return View(model);
            }

            return View(new AddressModel());

        }
        [HttpPost]
        public IActionResult PermentAddRedirect(AddressModel model)
        {
            string PermentAddress = JsonConvert.SerializeObject(model);
             HttpContext.Session.SetString("PermentAddress", PermentAddress);

            return Ok();
        }
        public IActionResult CurrentAddress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CurrentAddress(AddressModel model)
        {
            try
            {
                HttpContext.Session.SetString("Currentddress", JsonConvert.SerializeObject(model));
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("PermanentAddress");
        }


        public IActionResult WorkExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WorkExperience(WorkExperienceModel model)
        {
            string WorkExprience = JsonConvert.SerializeObject(model);
            HttpContext.Session.SetString("WorkExprience", WorkExprience);

            return RedirectToAction("CurrentAddress");
        }
        public IActionResult QualificationDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QualificationDetails(QualificationDetailsModel model)
        {
            string QualificationDetails = JsonConvert.SerializeObject(model);
            HttpContext.Session.SetString("QualificationDetails", QualificationDetails);
            return Ok();
        }
        public IActionResult PersonalDetails()
        {

            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(PersonalDetailsModel model)
        {
            string PersnolDetails = JsonConvert.SerializeObject(model);

            // Store the JSON string in the session
            HttpContext.Session.SetString("PersnolDetails", PersnolDetails);

            return RedirectToAction("QualificationDetails");
        }

        [HttpPost]
        public IActionResult FillCandidateDetailsPost([FromBody] CandidateEntrySessionData formData)
        {
            string FillCandidateDetails = JsonConvert.SerializeObject(formData);

            // Store the JSON string in the session
            HttpContext.Session.SetString("FillCandidateDetails", FillCandidateDetails);

            return Json(new { success = true }); // or any other response
        }



        public async Task<IActionResult> FillCandidateDetails()
        {
            var Source = await _candidateService.FillCandidateDetailsAsync();
            var DispositionData = Source.Select(x => new SelectListItem { Value = x.SourceId.ToString(), Text = x.SourceName.ToString() }).Distinct().ToList();
            var extraItem = new SelectListItem { Value = "0", Text = "Select  Source" };
            DispositionData.Insert(0, extraItem);
            ViewBag.Disposition = new SelectList(DispositionData, "Value", "Text");


            var loca = await _candidateService.LocationAsync();
            var Location = loca.Select(x => new SelectListItem { Value = x.LocationId.ToString(), Text = x.LocationName.ToString() }).Distinct().ToList();
            var Select = new SelectListItem { Value = "0", Text = "Select  Location" };
            Location.Insert(0, Select);
            ViewBag.Location = new SelectList(Location, "Value", "Text");


            var PositionApply = await _candidateService.GetPositioAsync();
            var Position = PositionApply.Select(x => new SelectListItem { Value = x.PositionId.ToString(), Text = x.PositionName.ToString() }).Distinct().ToList();
            var Positionlist = new SelectListItem { Value = "0", Text = "Select Position" };
            Position.Insert(0, Positionlist);
            ViewBag.Position = new SelectList(Position, "Value", "Text");

            return View();
        }
        [HttpPost]
        public IActionResult CompressImage(IFormFile photograph)
        {
            if (photograph != null && photograph.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    photograph.CopyTo(ms);

                    // Compress the image to 10 KB
                    var compressedImage = CompressImage(ms.ToArray(), 10);

                    //var imageData = new CandidateImage { CompressedImage = compressedImage };
                    //_candidateService.SaveImages(imageData);

                    return Ok("Image compressed and saved to the database.");
                }
            }

            return BadRequest("No file provided.");
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

        [HttpPost]
        public ActionResult HandleDisposition(string selectedValue)
        {
            var data = _candidateService.SubDisposiotion(selectedValue);
            var subDispositionList = data.Select(x => new SelectListItem { Value = x.SubSourceId.ToString(), Text = x.SubSourceName }).Distinct().ToList();
            var Select = new SelectListItem { Value = "0", Text = "Select  Sub-Source" };
            subDispositionList.Insert(0, Select);
            return Json(subDispositionList);
        }

        public IActionResult AddCandicateEntry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCandicateEntry(CandidateEntryDetails model)
        {
            if (ModelState.IsValid)
            {
                string candidateEntryJson = JsonConvert.SerializeObject(model);
                HttpContext.Session.SetString("CandidateEntry", candidateEntryJson);
                bool varifystatus = VerifyOTP(model.OTP, model.MobileNumber, model.EmailOTP);
                if (varifystatus)
                {

                    return RedirectToAction("FillCandidateDetails");
                }
                else
                {
                    ViewBag.AgeAlert = "Invalid OTP. Please try again.";
                    return View();
                }

            }
            return View();
        }

        public bool VerifyOTP(string OTP, string mobileNumber, string OTPEnail)
        {

            List<Dictionary<string, object>> ds_verifyOTP = _candidateService.Get_OTPDetails(mobileNumber, OTP, OTPEnail);
            if (ds_verifyOTP.Any(x => x.TryGetValue("Status", out var status) && status.ToString() == "Success"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost]
        public async Task<IActionResult> GenerateOTPMethod(string firstName, string mobileNumber, string EmailIDrValue)
        {

            HttpContext.Session.SetString("firstName", firstName);
            string Massge = "";
            List<Dictionary<string, object>> data = await _candidateService.Get_HRMIS_DataAsync("CheckMobileNo", mobileNumber);
            var masterID = data.Select(x => x["MasterId"]).FirstOrDefault();
            if (data.Count() > 0)
            {
                if (data.Any(x => x.TryGetValue("EmpCode", out var empCode) && empCode != null))
                {
                    Massge = "Your Master Id: " + masterID.ToString() + " - already generated";
                    return Ok(new { Status = "MasterIDPresent", Message = Massge });
                }
                else if (data.Any(x => x.TryGetValue("EmpCode", out var empCode) && empCode != null))
                {
                    List<Dictionary<string, object>> data2 = await _candidateService.Get_HRMIS_DataCheckActiveEmpCodeAsync("CheckActiveEmpCode", mobileNumber);
                    if (data2.Any(row => row.TryGetValue("ActiveEmp", out var activeEmp) && activeEmp != null && Convert.ToInt32(activeEmp) == 1))
                    {
                        string Text = SendSMS(mobileNumber, Convert.ToString(masterID));
                        return Ok(new { Status = "MasterIDPresent", Message = Massge });
                    }
                    if (data2.Any(row => row.TryGetValue("ActiveEmp", out var activeEmp) && activeEmp != null && Convert.ToInt32(activeEmp) == 0))
                    {
                        await Generate_OTP(mobileNumber, firstName, EmailIDrValue);
                        return Ok(new { Status = "Success", Message = "OTP generated successfully." });
                    }
                }
            }
            else
            {
                await Generate_OTP(mobileNumber, firstName, EmailIDrValue);
                return Ok(new { Status = "Success", Message = "OTP generated successfully." });
            }
            return Ok(new { Status = "Success", Message = "OTP generated successfully." });

        }

        [HttpPost]
        public async Task<IActionResult> Generate_OTP(string MobailNumber, string Username, string EmailIDrValue)
        {
            Random generator = new Random();
            string OTP = generator.Next(0, 9999).ToString("D4");
            string OTPEnail = generator.Next(0, 9999).ToString("D4");
            CL_SendMail cl = new CL_SendMail();
            cl.sendMail(Username, MobailNumber, OTPEnail, EmailIDrValue);
            string[] status = _candidateService.Save_OTPDetails(MobailNumber, OTP, OTPEnail);
            if (status[0] == "Success")
            {
                string msg = await SendOTPAsync(OTP, MobailNumber);
                if (msg == "Success")
                {
                    return Ok("Success");
                }
            }
            return Ok();
        }
        private async Task<string> SendOTPAsync(string OTP, string Mobile)
        {
            string Message = $"Yours OTP is {OTP}. Thank you for contacting OPO";

            string sourceAddress = "OPOSMS";
            string messageType = "SERVICE_IMPLICIT";
            string dltTemplateId = "1607100000000131768";
            string entityId = "1601100000000007805";
            string isEnabled = "true";

            string json = $"{{\"customerId\": \"{"ONE_POINT__Hsxp4Bd95x41AyX0iYU6"}\"," +
                          $"\"destinationAddress\":[\"{Mobile}\"]," +
                          $"\"message\": \"{Message}\"," +
                          $"\"sourceAddress\": \"{sourceAddress}\"," +
                          $"\"messageType\": \"{messageType}\"," +
                          $"\"dltTemplateId\": \"{dltTemplateId}\"," +
                          $"\"urlShortenerParams\":{{\"isEnabled\":\"{isEnabled}\"}}," +
                          $"\"entityId\":\"{entityId}\"" +
                          "}}";

            string APIurl = "https://openapi.airtel.in/gateway/airtel-iq-sms-utility/sendSms";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Basic T05FX1BPSU5UX19Ic3hwNEJkOTV4NDFBeVgwaVlVNjpGbUE4RkhWM0BCd0R1JjZr");

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                try
                {
                    HttpResponseMessage response = await client.PostAsync(APIurl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        Message = "Success";
                    }
                    else
                    {
                        Message = $"Failed...! {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    Message = $"Failed...! {ex.Message}";
                }
            }

            return Message;
        }
        private string SendSMS(string Mobile, string VistitorId)
        {
            try
            {
                string link = "http://ggl.lc/?f46918";
                string Message = $"Dear {HttpContext.Session.GetString("firstName")}, Your Visitor Id generated successfully. Visitor Id: {VistitorId}, Mobile: {Mobile}. Please find below the link to fill in your details: {link}. Regards, Recruitment Team. - One Point One Solutions Ltd";

                string sourceAddress = "OPOSMS";
                string messageType = "SERVICE_IMPLICIT";
                string dltTemplateId = "1607100000000067234";
                string entityId = "1601100000000007805";
                string isEnabled = "true";

                string json = "{\"customerId\": \"" + "ONE_POINT__Hsxp4Bd95x41AyX0iYU6" + "\"," +
                          "\"destinationAddress\":[\"" + Mobile + "\"]," +
                          "\"message\": \"" + Message + "\"," +
                          "\"sourceAddress\": \"" + sourceAddress + "\"," +
                          "\"messageType\": \"" + messageType + "\"," +
                          "\"dltTemplateId\": \"" + dltTemplateId + "\"," +
                           "\"urlShortenerParams\":{\"isEnabled\":\"" + isEnabled + "\"}," +
                          "\"entityId\":\"" + entityId + "\"" +
                          "}";

                string APIurl = "https://openapi.airtel.in/gateway/airtel-iq-sms-utility/sendSms";

                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic T05FX1BPSU5UX19Ic3hwNEJkOTV4NDFBeVgwaVlVNjpGbUE4RkhWM0BCd0R1JjZr");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var httpResponse = httpClient.PostAsync(APIurl, content).Result;
                var result = httpResponse.Content.ReadAsStringAsync().Result;
                return Message;
            }
            catch (Exception ex)
            {

            }
            return "";
        }
        private int CalculateAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthdate.Year;
            if (currentDate.Month < birthdate.Month || (currentDate.Month == birthdate.Month && currentDate.Day < birthdate.Day))
            {
                age--;
            }
            return age;
        }
    }
}
