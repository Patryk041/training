using System.Collections.Generic;

namespace Anathema.Igor.City_Homework.DataLoadSystem
{
    public interface ILoadDataSys<T>
    {
        List<T> GetData();
    }
}
