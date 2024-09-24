using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez03_dal_refactor.classes
{
    internal class AssetDAO : IDao<Asset>
    {
        private static AssetDAO? instance;

        public static AssetDAO GetInstance()
        {
            if (instance == null)
                instance = new AssetDAO();

            return instance;
        }

        private AssetDAO() { }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Asset> FindAll()
        {
            throw new NotImplementedException();
        }

        public Asset? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Asset obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Asset obj)
        {
            throw new NotImplementedException();
        }
    }
}
