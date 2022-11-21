﻿using Audience.BLL.DTO;
using Audience.DAL.Entities;
using Audience.Infrastructure.Services;

namespace Audience.BLL.Interfaces
{
    public interface IAudiencesServices
    {
        Task<Result> Create(Audiences audience);
        Task<IEnumerable<AudiencesDTO>> GetAll();
        Task<AudiencesDTO> Get(int id);
        Task<Result> Delete(int id);

    }
}
