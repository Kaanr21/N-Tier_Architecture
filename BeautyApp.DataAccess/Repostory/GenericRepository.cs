﻿using BeautyApp.DataAccess.Abstract;
using BeautyApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.DataAccess.Repostory
{
    public class GenericRepository<T>(BeautyAppDbContext _context): IGenericRepostory<T> where T : class
    {


        public DbSet<T> Table { get => _context.Set<T>(); }
        public int Count()
        {
            return Table.Count();
        }

        public void Create(T entity)
        {
            Table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Table.Find(id);
            Table.Remove(entity);
            _context.SaveChanges();
        }

        public int FilteredCount(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).Count();
        }

        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).FirstOrDefault();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public List<T> GetList()
        {
            return Table.ToList();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            _context.SaveChanges();
        }
    }
}
