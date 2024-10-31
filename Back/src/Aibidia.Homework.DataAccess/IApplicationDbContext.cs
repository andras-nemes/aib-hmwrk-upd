using Aibidia.Homework.Domain.Models;
using Aibidia.Homework.Domain.Models.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Aibidia.Homework.DataAccess;

public interface IApplicationDbContext
{
    #region DbSets
    public DbSet<Resume> Resumes { get; set; }

    public DbSet<ResumeActive> ActiveResumes { get; set; }

    #endregion

    public Task<int> SaveChangesAsync();

    public Task ExecuteCommandAsync(string rawSqlQuery, params object[] parameters);

    DatabaseFacade Database { get; }
}
