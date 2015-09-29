using System.Collections.Generic;

namespace Anathema.Igor.City_Homework.DataLoadSystem.FileLoader
{
    public abstract class FileLoader<T> : ILoadDataSys<T>
    {
        protected List<T> DataSet = new List<T>();
        public virtual List<T> GetData()
        {
            return DataSet;
        }
    }
}
