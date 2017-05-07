using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBoilerplate.Service
{
    public class DataService : IDataService
    {
        public string Get()
        {
            return "Zdravo svete";
        }

        public List<string> GetList()
        {
            return new List<string>
                            {
                                "jedan",
                                "dva",
                                "tri"
                            };
        }


    }
}
