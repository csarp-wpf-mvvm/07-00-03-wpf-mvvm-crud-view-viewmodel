﻿using Kreta.Shared.Extensions;
using Kreta.Shared.Models.Dtos;
using Kreta.Shared.Models.Entites.SwitchTable;

namespace Kreta.Shared.Assamblers
{
    public class SchoolClassStudentsAssambler : Assambler<SchoolClassStudents, SchoolClassStudentsDto>
    {
        public override SchoolClassStudentsDto ToDto(SchoolClassStudents domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override SchoolClassStudents ToModel(SchoolClassStudentsDto dto)
        {
            return dto.ToModel();
        }
    }
}
