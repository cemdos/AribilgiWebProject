using AribilgiWebProject.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AribilgiWebProject.DAL
{
    public class UnitOfWork
    {
		private static NinicoDbEntities context => new NinicoDbEntities();

        public static T AddData<T>(T model) where T : BaseModel
        {
            var addedData = context.Set<T>().Add(model);
            context.SaveChanges();
            return addedData;
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

        public static T UpdateData<T>(T model) where T : BaseModel
        {
            var updating = context.Set<T>().Find(model.ID);
            updating = model;
            context.Entry(updating).State = EntityState.Modified;
            context.SaveChanges();
            return model;
        }

        public static T RemoveData<T>(int id) where T : BaseModel
        {
            var deletingData = context.Set<T>().Find(id);
            var deletedData = context.Set<T>().Remove(deletingData);
            context.SaveChanges();
            return deletedData;
        }

    }
}
