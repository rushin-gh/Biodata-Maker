using System;
using System.Collections.Generic;

namespace Biodata_Maker.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Salutation {  get; set; }

        public string UserName {  get; set; }

        public DateTime  UserDOB { get; set; }

        public string BirthPlace { get; set; }

        public double Height { get; set; }

        public string Color {  get; set; }

        public string BloodGroup { get; set; }

        public string Education { get; set; }

        public string Occupation { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public List<string> MamaList { get; set; }

        public int BrotherCount { get; set; }

        public int SisterCount { get; set; }

        public List<string> Relatives { get; set; }

        public string Cast { get; set; }

        public string Kuladevata { get; set; }

        public string NativeAddress { get; set; }

        public string MobileNumber { get; set; }
    }
}