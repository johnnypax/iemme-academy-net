﻿namespace REST_02_EF_Libreria.Repositories
{
    public interface IRepo<T>
    {
        T? GetById(int id);
        List<T> GetAll();
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
