﻿using SoftwarePlannerLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftwarePlannerLibrary.Databases.Interfaces
{
    public interface ITeamsControl
    {
        Task<List<NoteModel>> GetAllTeamNotesAsync(int teamId);
        Task<List<ProjectModel>> GetAllTeamProjectsAsync(int teamId);
        Task<List<TicketModel>> GetAllTeamTicketsAsync(int teamId);
        Task<TeamModel> GetTeamInfoByIdAsync(int? teamId);
    }
}