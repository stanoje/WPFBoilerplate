using System.Collections.Generic;

namespace WpfBoilerplate.Service
{
    public interface IDataService
    {
        string Get();
        List<string> GetList();
    }
}