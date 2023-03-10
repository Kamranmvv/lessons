using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class DataBase
    {
        private ArrayList DB = new ArrayList();



        public void NewItem<T>(T item)
        {
            DB.Add(item);
        }
        public void NewItems<T>(params T[] item)
        {

        }
        public void UpdateItem()
        {

        }
        public void DeleteItem()
        {
            BaseSettings bSettings = new BaseSettings();
            bSettings.IsDeleted = true;
        }
    }
}
