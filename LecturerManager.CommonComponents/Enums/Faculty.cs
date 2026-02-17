using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums
{
    public enum Faculty
    {
        [Display(Name = "Faculty of Informatics")]
        FacultyOfInformatics,
        [Display(Name = "Faculty of Economics")]
        FacultyOfEconomics,
        [Display(Name = "Faculty of Law")]
        FacultyOfLaw,
        [Display(Name = "Faculty of Natural Sciences")]
        FacultyOfNaturalSciences
    }
}
