using System.Collections.Generic;
using System.Linq;

namespace Raya.Employee.Repository
{
    public static class RepositoryBase<T> where T : class
    {
        private static EmployeeContext context;
        static RepositoryBase()
        {
            context = new EmployeeContext();
        }
        public static T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public static List<T> Get()
        {
            return context.Set<T>().ToList();
        }
        public static T Add(T Entity)
        {
            context.Set<T>().Add(Entity);
            context.SaveChanges();
            return Entity;
        }
        public static void AddRange(List<T> Entities)
        {
            context.Set<T>().AddRange(Entities);
            context.SaveChanges();

        }
        public static T Update(T Entity)
        {
            context.SaveChanges();
            return Entity;
        }
        public static bool Delete(T Entity)
        {
            context.Set<T>().Remove(Entity);
            context.SaveChanges();
            return true;

        }
    }
}