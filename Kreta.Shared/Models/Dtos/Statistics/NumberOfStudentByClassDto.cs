﻿using Kreta.Shared.Models.Enums;

namespace Kreta.Shared.Models.Dtos.Statistics
{
    public class NumberOfStudentByClassDto
    {
        public int Grade { get; set; }
        public SchoolClassType Type { get; set; }
        public int NumberOfStudent { get; set; }
    }
}
