﻿using Kreta.Shared.Models.Dtos;
using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Extensions
{
    public static class PublicSpaceExtension
    {
        public static PublicSpaceDto ToDto(this PublicSpace educationLevel)
        {
            return new PublicSpaceDto
            {
                Id = educationLevel.Id,
                NameOfPublicSpace = educationLevel.NameOfPublicSpace

            };
        }

        public static PublicSpace ToModel(this PublicSpaceDto model)
        {
            return new PublicSpace
            {
                Id = model.Id,
                NameOfPublicSpace=model.NameOfPublicSpace,
            };
        }
    }
}
