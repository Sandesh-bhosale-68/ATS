namespace ATS.Models
{
    public class CNDData
    {
        public string MaritalStatus { get; set; }
        public string PanCard { get; set; }
        public string Passport { get; set; }
        public string UAN { get; set; }
        public bool IsDifferentlyAbled { get; set; }
        public string SelectedLanguage { get; set; }
        public List<LanguageDetail> VirtualGridValues { get; set; }
    }
    public class LanguageDetail
    {
        public string Language { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Speak { get; set; }
    }
}
