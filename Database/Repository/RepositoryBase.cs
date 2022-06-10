using booking.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// entity framework - niste metode, le folosesc(ca sa nu scriu query urile in cod apelez niste metode care incapsuleaza 
/// codul de query uri)-]*l
/// o colectie de obiecte in memorie
/// dupa ce modificam baza de date ne folosim de sablonul de proiectare-unitOfWork pt a salva obiectul modificat 
/// in baza de date
/// unit se ocupa de tranzactie(operatie care se face asupra bazei de date)
/// </summary>
namespace booking.Database.Repository
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : BaseModel
    {
        private readonly DbContext _db;
        private readonly DbSet<T> _dbSet;

        protected RepositoryBase(BookingContext context)
        {
            _db = context;
            _dbSet = context.Set<T>();
        }

        public IList<T> GetAll(bool asNoTracking = false, bool includeDeleted = false)
        {
            var query = includeDeleted
               ? _dbSet
               : _dbSet.Where(entity => entity.DeletedAt == false);

            return asNoTracking
                ? query.AsNoTracking().ToList()
                : query.ToList();
        }

        public T GetById(int id, bool asNoTracking = false)
        {
            return GetRecords(asNoTracking).FirstOrDefault(e => e.Id == id);
        }

        public virtual void Insert(T record)
        {
            if (_db.Entry(record).State == EntityState.Detached)
            {
                _db.Attach(record);
                _db.Entry(record).State = EntityState.Added;
            }
        }

        public virtual void Update(T record)
        {
            if (_db.Entry(record).State == EntityState.Detached)
                _db.Attach(record);

            _db.Entry(record).State = EntityState.Modified;
        }

        public void Delete(T record)
        {
            if (record != null)
            {
                record.DeletedAt = true;
                Update(record);
            }
        }

        public void Dispose()
        {
            _db?.Dispose();
        }

        protected IQueryable<T> GetRecords(bool asNoTracking = false, bool includeDeleted = false)
        {
            var result = includeDeleted ?
                _dbSet.Where(e => e.DeletedAt != false)
                :
                _dbSet;

            return asNoTracking ? result.AsNoTracking() : result;
        }
    }
}
