using AribilgiWebProject.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AribilgiWebProject.DAL
{
    public class UnitOfWork
    {
        private static NinicoDbEntities context;
        private static UnitOfWork instance;

        private static NinicoDbEntities Context
        {
            get
            {
                if (context == null)
                    context = new NinicoDbEntities();
                return context;
            }
        }
        public static UnitOfWork Instance
        {
            get
            {
                if (instance == null)
                    instance = new UnitOfWork();
                return instance;
            }
        }


        public T AddData<T>(T model) where T : BaseModel
        {
            var addedData = Context.Set<T>().Add(model);
            Context.Entry(model).State = EntityState.Added;
            //context.Category.Add(new Category
            //{
            //    Name = "Test"
            //});
            int effectedRow = Context.SaveChanges();
            return addedData;
        }

        public List<T> GetAll<T>() where T : BaseModel
        {
            List<T> resultDatas = Context.Set<T>().Where(_ => !_.Deleted).ToList();
            return resultDatas;
        }

        public T GetById<T>(int id) where T : BaseModel
        {
            T resultData = Context.Set<T>().Find(id);
            return resultData;
        }

        public T UpdateData<T>(T model) where T : BaseModel
        {
            var updating = Context.Set<T>().Find(model.ID);
            updating = model;
            Context.Entry(updating).State = EntityState.Modified;
            Context.SaveChanges();
            return model;
        }

        public T RemoveData<T>(int id) where T : BaseModel
        {
            var deletingData = Context.Set<T>().Find(id);
            var deletedData = Context.Set<T>().Remove(deletingData);
            Context.SaveChanges();
            return deletedData;
        }

    }
}
