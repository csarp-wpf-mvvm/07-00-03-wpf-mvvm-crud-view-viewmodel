﻿using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Models.Dtos
{
    public class SchoolClassSubjectsDto
    {
        public Guid Id { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClass { get; set; }
        public Guid SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsTheHoursInOne { get; set; }
    }
}
