using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.Models.Repositores
{
  public  interface IBookrepository<TEntity>
    {

        IList<TEntity> list();
        TEntity find(int id);
        void add(TEntity item);
        void update(int id,TEntity newItem);
        void delete(int id);
        IList<TEntity> Search(string term);

    }

}
