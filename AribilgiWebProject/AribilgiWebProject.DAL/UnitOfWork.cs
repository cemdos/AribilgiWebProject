using AribilgiWebProject.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AribilgiWebProject.DAL
{
    public class UnitOfWork
    {
		private static NinicoDbEntities context => new NinicoDbEntities();

        public static int AddData<T>(T model) where T : BaseModel
        {
            context.Set<T>().Add(model);
            int effectedRowCount = context.SaveChanges();
            return effectedRowCount;
        }

        public static List<T> GetAll<T>() where T :BaseModel
        {
            List<T> resultDatas = context.Set<T>().Where(_=> !_.Deleted).ToList();
            return resultDatas;
        }

        public static T GetById<T>(int id) where T : BaseModel
        {
            T resultData = context.Set<T>().Find(id);
            return resultData;
        }

        public static int UpdateData<T>(T model) where T : BaseModel
        {
            var updating = context.Set<T>().Find(model.ID);
            updating = model;
            context.Entry(updating).State = EntityState.Modified;
            var effectedRowCount = context.SaveChanges();
            return effectedRowCount;
        }

        public static int RemoveData<T>(int id) where T : BaseModel
        {
            var deletingData = context.Set<T>().Find(id);
            context.Set<T>().Remove(deletingData);
            var effectedRowCount = context.SaveChanges();
            return effectedRowCount;
        }

    }
}
