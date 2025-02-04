﻿using Kreta.Shared.Models.Entites;
using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.Shared.Models.Entites.SwitchTable
{
    public class SchoolClassStudents : IDbEntity<SchoolClassStudents>
    {
        public Guid Id { get; set; }
        public Guid SchoolClassId { get; set; }
        public virtual SchoolClass? SchoolClass { get; set; }
        public Guid StudnetId { get; set; }
        public virtual Student? Student { get; set; }
        public DateOnly? DateOfEnrolment { get; set; }
        public bool HasId => throw new NotImplementedException();
    }
}
