
using ATS.DatabaseDB;
using ATS.IService;
using ATS.Models;
using ATS.SpResult;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

using System.Reflection.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace ATS.Service
{
    public class Candidate : ICandidate
    {


        private readonly HRMISContext _context;
        public Candidate(HRMISContext hec)
        {

            _context = hec;
        }
        public void InsertCandidateDetails(CandidateEntryDetails candidateEntry, CandidateEntrySessionData fillCandidateData, PersonalDetailsModel personalDetails, QualificationDetailsModel qualificationDetails, WorkExperienceModel workExpData, AddressModel currentAddressData, AddressModel permanentAddressData, CNDData candeidateOther)
        {
            try
            {
                TblCandidateDetail candidate = new TblCandidateDetail
                {

                    Empcode = "",
                    Prefix = "",
                    Fname = candidateEntry.FirstName.ToString(),
                    Lname = candidateEntry.LastName.ToString(),
                    Dob = candidateEntry.DOB,
                    Gender = personalDetails.Gender,
                    Fathername = personalDetails.FatherName.ToString(),
                    Mothername = personalDetails.MotherName.ToString(),
                    Emaild = candidateEntry.EmailID,
                    Fulladdr1 = currentAddressData.HouseNumber.ToString(),
                    Faddr1 = currentAddressData.StreetName.ToString(),
                    Faddr2 = currentAddressData.State,
                    Faddr3 = currentAddressData.Area,
                    Faddr4 = currentAddressData.LandMark,
                    Fmobile = candidateEntry.MobileNumber,
                    Flandline = candidateEntry.MobileNumber,
                    Fulladdr2 = currentAddressData.HouseNumber.ToString(),
                    Saddr1 = currentAddressData.StreetName.ToString(),
                    Saddr2 = currentAddressData.State,
                    Saddr3 = currentAddressData.Area,
                    Saddr4 = currentAddressData.LandMark,
                    Smobile = candidateEntry.MobileNumber,
                    Slandline = candidateEntry.MobileNumber,
                    Maritialstatus = candeidateOther.MaritalStatus,
                    Anivdate = "2025-05-15", // Example date as string
                    Spousename = "",
                    Nameofchildren = "",
                    Bloodgrp = personalDetails.BloodGroup,
                    Emergcontno = personalDetails.EmergencyContactDetails,
                    Emergcontperson = "",
                    Anyotherquali = qualificationDetails.CertificationOther,
                    Totalexpr = Convert.ToString(workExpData.NumberOfExp),
                    Prorefname = "",
                    Prorefdesig = "",
                    Prorefcontact = "",
                    Famrefname = "",
                    Famrefcontact = "",
                    Frdrefname = personalDetails.Ref1,
                    Frdrefcontact = "",
                    Refrecname = "",
                    Refreccontact = "",
                    Refreccuremp = "",
                    Refrecdesig = "",
                    Lastctcpm = "",
                    Dateoftraining = DateTime.Now,
                    Dateofjoining = DateTime.Now,
                    Location = permanentAddressData.LandMark,
                    Department = fillCandidateData.Position,
                    Subdepartment = fillCandidateData.Position,
                    Subdepartment1 = "",
                    Joiningdesig = "",
                    Currentdesig = workExpData.Designation,
                    Placeofbirth = "",
                    Nationality = "Indian",
                    Religion = "",
                    Languages = "",
                    Passportno = candeidateOther.Passport,
                    Caste = "",
                    Identificationmark = "",
                    Handicap = "",
                    Handicapnature = "",
                    Handicapper = "",
                    Licenseexpirydt = DateTime.Now.AddYears(2),
                    Subcaste = "",
                    Issueofrltr = "",
                    Interviewdt = DateTime.Now.AddDays(7),
                    Issueapptltr = "",
                    Postappliedfor = fillCandidateData.Position,
                    Entrydttm = DateTime.Now,
                    Interviewstatus = "",
                    Interviewtm = "",
                    Postassigned = "",
                    TeleRound = "",
                    Mode = "",
                    ModeHrperson = "",
                    Photoid = "",
                    Interviewer = "",
                    IntrvFlag = 1,
                    InternalRef = "",
                    InfFlag = "",
                    AnnualCtc = Convert.ToString(workExpData.CTC),
                    OfferLetterDate = DateTime.Now.AddDays(2),
                    ActualDoj = DateTime.Now.AddDays(10),
                    HasJoined = 0,
                    TrngBatchId = 123,
                    TrainerEmpId = "",
                    TrainerName = " ",
                    IsRejected = 0,
                    TrngStatus = "",
                    ConsaltantRef = "",
                    EntryUpdatedbyDt = "",
                    HrLocation = "",
                    ClosedBy = "",
                    PinCodeForCurrent = currentAddressData.PinCode,
                    PinCodeForPermanant = currentAddressData.PinCode,
                    EffortRefName = "",
                    EffortRefContactNo = "",
                    EffortRefEmpid = "",
                    LocationId = 456,
                    CertificationComments = "",
                    TrngSubStatus = "",
                    CurrentArea = permanentAddressData.Area,
                    CurrentLandmark = permanentAddressData.LandMark,
                    PermArea = permanentAddressData.Area,
                    PermLandmark = permanentAddressData.LandMark,
                    PanCard = candeidateOther.PanCard,
                    AadharCard = Convert.ToString(candidateEntry.AadharCardNumber),
                    AadharStatus = "Verified",
                    AdharName = personalDetails.AdharName,
                    CreatedDate = DateTime.Now,
                    Uanno = Convert.ToInt32(candeidateOther.UAN),
                    BasicDaRate = 15000.50m,
                    GrossSalPli = 60000.75m,
                    PfMember = "",
                    PensionMember = "",
                    PfNo = candeidateOther.UAN,
                    DolPrev = DateTime.Now.AddMonths(-3),
                    PfWithdrawStatus = "",
                    Remark = "",
                    BankLocation = "",
                    AccNo = "",
                    Ifsccode = "",
                    CandidateLocation = " ",
                    Purpose = "",
                    SubDeptName = "",
                    Round1 = "",
                    Round2 = " ",
                    Round3 = "",
                    Round4 = "",
                    HighestQualification = qualificationDetails.HighEducation,
                    YearofPassing = qualificationDetails.HighPassingYear,
                    Percentage = "",
                    CreatedBy = " ",
                    DifferentlyAbled = "",
                    EmploymentStatus = "",
                    FtPt = "",
                    WfoWfh = "",
                    PfApplicability = "",
                    EsicApplicability = " ",
                  
                };

                if (personalDetails.Gender == "Male")
                {
                    candidate.Prefix = "Mrs.";
                }
                else
                {
                    candidate.Prefix = "Miss";
                }
                _context.TblCandidateDetails.Add(candidate);
                _context.SaveChanges();
                var MasterID = _context.TblCandidateDetails.Where(x => x.Fmobile == candidateEntry.MobileNumber).Select(x => x.Masterid).FirstOrDefault();
                InsertWorkexpDetails(Convert.ToInt32(MasterID), workExpData , candidateEntry.MobileNumber);
                InsertQualificationData(qualificationDetails, Convert.ToInt32(MasterID));
                InsertLanguageData(candeidateOther.VirtualGridValues, Convert.ToInt32(MasterID));

            }
            catch (DbUpdateException ex)
            {

            }
        }
        public void InsertWorkexpDetails( int masterid  , WorkExperienceModel WorkExp , string MobailNumber)
        {
            try
            {
                var experienceDetail = new ExperienceDetail
                {

                    MasterId = masterid,
                    MobileNo = MobailNumber,
                    CompanyName = WorkExp.ORGName,
                    Designation = WorkExp.Designation,
                    FromDate = WorkExp.LastORGJED,
                    ToDate = WorkExp.LWD,
                    TotalExperience = WorkExp.NumberOfExp.ToString(),
                    Process = WorkExp.Designation,
                    Ctc = WorkExp.CTC.ToString(),
                    RecDate = DateTime.Now
                };
                _context.ExperienceDetails.Add(experienceDetail);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {

            }
        
        }

        public void InsertLanguageData(List<LanguageDetail> languageDataList, int masterid)
        {
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                foreach (var languageData in languageDataList)
                {
                    command.CommandText = "InsertLanguageData";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.Add(new SqlParameter("@MasterId", masterid));
                    command.Parameters.Add(new SqlParameter("@Language", languageData.Language.ToString()));
                    command.Parameters.Add(new SqlParameter("@Read", languageData.Read.ToString()));
                    command.Parameters.Add(new SqlParameter("@Write", languageData.Write.ToString()));
                    command.Parameters.Add(new SqlParameter("@Speak", languageData.Speak.ToString()));
                    command.ExecuteNonQuery();
                }
            }


        }

        public void InsertQualificationData(QualificationDetailsModel qualificationDetails, int masterid)
        {

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                command.CommandText = "InsertEducationData";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("@MasterId", masterid));
                command.Parameters.Add(new SqlParameter("@HighEducation", qualificationDetails.HighEducation));
                command.Parameters.Add(new SqlParameter("@HighPassingYear", qualificationDetails.HighPassingYear));
                command.Parameters.Add(new SqlParameter("@HSC", qualificationDetails.HSC));
                command.Parameters.Add(new SqlParameter("@Diploma", qualificationDetails.Diploma));
                command.Parameters.Add(new SqlParameter("@Graduate", qualificationDetails.Graduate));
                command.Parameters.Add(new SqlParameter("@PostGraduate", qualificationDetails.PostGraduate));
                command.Parameters.Add(new SqlParameter("@SpecialCertification", qualificationDetails.SpecialCertification));
                command.Parameters.Add(new SqlParameter("@CertificationOther", qualificationDetails.CertificationOther));
                command.Parameters.Add(new SqlParameter("@OtherCertificatePassingYear", qualificationDetails.OtherCertificatePassingYear));
                command.Parameters.Add(new SqlParameter("@PercentageOther", qualificationDetails.PercentageOther));

                command.ExecuteNonQuery();
            }
        }
        public List<SubSource> SubDisposiotion(string disposition)
        {
            var data = _context.SubSources.Where(x => x.SourceId == Convert.ToInt32(disposition))
                                           .Select(x => new SubSource { SubSourceId = x.SubSourceId, SubSourceName = x.SubSourceName }).ToList();
            return data;
        }

        public async Task<List<Source>> FillCandidateDetailsAsync()
        {
            try
            {
                return await _context.Sources.ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<List<Dictionary<string, object>>> Get_HRMIS_DataAsync(string Operation, string MobailNumber)
        {
            try
            {
                var result = new List<Dictionary<string, object>>();
                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "USP_Get_HRMIS_Data";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("Operation", Operation));
                    command.Parameters.Add(new SqlParameter("fmobile", MobailNumber));
                    await _context.Database.OpenConnectionAsync();
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                var columnName = reader.GetName(i);
                                var columnValue = reader.GetValue(i);
                                row.Add(columnName, columnValue);
                            }
                            result.Add(row);
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Get_HRMIS_DataAsync: {ex.Message}");
                throw;
            }
        }


        public async Task<List<Dictionary<string, object>>> Get_HRMIS_DataCheckActiveEmpCodeAsync(string Operation, string MobailNumber)
        {
            try
            {
                List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "USP_Get_HRMIS_Data";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("Operation", Operation));
                    command.Parameters.Add(new SqlParameter("fmobile", MobailNumber));
                    await _context.Database.OpenConnectionAsync();
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                var columnName = reader.GetName(i);
                                var columnValue = reader.GetValue(i);
                                row.Add(columnName, columnValue);
                            }
                            result.Add(row);
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Dictionary<string, object>> Get_OTPDetails(string mobileNumber, string OTP, string EmailOTP)
        {
            try
            {
                List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "USP_Get_HRMIS_Data";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("fmobile", mobileNumber));
                    command.Parameters.Add(new SqlParameter("OTPCode", OTP));
                    command.Parameters.Add(new SqlParameter("EmailOPT", EmailOTP));
                    command.Parameters.Add(new SqlParameter("Operation", "VerifyMobile"));
                    _context.Database.OpenConnection();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                var columnName = reader.GetName(i);
                                var columnValue = reader.GetValue(i);
                                row.Add(columnName, columnValue);
                            }

                            result.Add(row);
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public string[] Save_OTPDetails(string MobailNumber, string OTP, string EmailOTP)
        {

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "USP_Get_HRMIS_Data";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("Operation", "SendOTP"));
                command.Parameters.Add(new SqlParameter("fmobile", MobailNumber));
                command.Parameters.Add(new SqlParameter("OTPCode", OTP));
                command.Parameters.Add(new SqlParameter("@EmailOPT", EmailOTP));
                _context.Database.OpenConnection();
                var scalarResult = command.ExecuteScalar();

                if (scalarResult != null)
                {
                    string[] status = scalarResult.ToString().Split(',');
                    return status;
                }
            }
            return null;

        }

        public async Task<List<LocationMaster>> LocationAsync()
        {
            try
            {
                var data = await _context.LocationMasters
                    .Select(x => new LocationMaster { LocationId = x.LocationId, LocationName = x.LocationName })
                    .ToListAsync();

                return data;
            }
            catch (Exception ex)
            {
                // Handle or log the exception appropriately
                throw;
            }
        }

        public async Task<List<Position>> GetPositioAsync()
        {
            try
            {
                var data = await _context.Positions.ToListAsync();
                return data;
            }
            catch (Exception ex)
            {
                // Handle or log the exception appropriately
                throw;
            }
        }

        public void SaveImages(CandidateImage images)
        {
            try
            {

                _context.CandidateImages.Add(images);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public async Task<List<Source>> TestAsyncMethod()
        {
            var data = await _context.Sources.ToListAsync();
            return data;
        }

        public TblCandidateDetail GetLoginCredential(string UserName, string Password)
        {
            var data = _context.TblCandidateDetails.Where(x => x.Fmobile == UserName).FirstOrDefault();
            return data;
        }
    }
}
