using System;

namespace SKL.Report.Core.Models.DTOModels
{
    public class UserScores
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public decimal ModuleTotalScores { get; set; }
        public int FatherModuleID { get; set; }
        public decimal Scores { get; set; }
    }
}
