using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prct6.ViewModel
{
    internal class JsonSaver //для json
    {
        //сериализация
        public void Serialise()
        {
            try
            {
                string serializedObj = JsonConvert.SerializeObject(obj);
                return serializedObj;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Не, не, не, не, не: {e.Message}");
                return null;
            }
        }

        //десериализация
        public void Deserialize() { }
    }
}
