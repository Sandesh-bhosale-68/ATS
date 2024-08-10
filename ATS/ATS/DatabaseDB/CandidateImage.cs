using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class CandidateImage
    {
        public int Id { get; set; }
        public byte[]? addressProof { get; set; }
        public byte[]? nationalityProof { get; set; }
        public byte[]? higherEducation { get; set; }
        public byte[]? lastEmployer { get; set; }
        public byte[]? photograph { get; set; }




        public string PhotographfName { get; set; }
     
        public string AddProoffName { get; set; }
 
        public string NationalityProofName { get; set; }
  
        public string HigherEduName { get; set; }
 

        public string LastEmployerName { get; set; }
  


    }
}
