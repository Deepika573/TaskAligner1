using Microsoft.EntityFrameworkCore;
using TaskAligner.Data;
using TaskAligner.Entities;
using TaskAligner.Interfaces.Repository;

namespace TaskAligner.Repository
{
    public class DesignationRepository : IDesignationRepository
    {
        private readonly TaskAlignerDbContext _taskAlignerDbContext;

        public DesignationRepository(TaskAlignerDbContext taskAlignerDbContext)
        {
            _taskAlignerDbContext = taskAlignerDbContext;
        }

        public async Task<Designation> AddAsync(Designation designation)
        {
            await _taskAlignerDbContext.AddAsync(designation);
            await _taskAlignerDbContext.SaveChangesAsync();
            return designation;
        }

        public async Task<Designation> DeleteAsync(int id)
        {
            var designationFromDb = await _taskAlignerDbContext.Designation.FirstOrDefaultAsync(d => d.DesignationId == id);
            if (designationFromDb == null)
                return null;
            _taskAlignerDbContext.Designation.Remove(designationFromDb);
            await _taskAlignerDbContext.SaveChangesAsync();
            return designationFromDb;
        }

        public async Task<IEnumerable<Designation>> GetDesignationAsync()
        {
            return await _taskAlignerDbContext.Designation.ToListAsync();
        }

        public async Task<Designation> UpdateAsync(int id, Designation designation)
        {
            var designationFromDb = await _taskAlignerDbContext.Designation.AsNoTracking().FirstOrDefaultAsync(d => d.DesignationId == id);
            if (designationFromDb == null)
                return null;
            designation.DesignationId = designationFromDb.DesignationId;
            _taskAlignerDbContext.Designation.Update(designation);
            await _taskAlignerDbContext.SaveChangesAsync();
            return designation;
        }
    }
}
