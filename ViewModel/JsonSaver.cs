using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;


namespace prct6.ViewModel
{
    internal class JsonSaver
    {
        public static string SerializeObject(object obj)
        {
            try
            {
                string serializedObj = JsonConvert.SerializeObject(obj);
                return serializedObj;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не, не, не, не, не: {e.Message}", "Ошибка");
                return null;
            }
        }

        public static T DeserializeObject<T>(string jsonStr)
        {
            try
            {
                T deserializedObj = JsonConvert.DeserializeObject<T>(jsonStr);
                return deserializedObj;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не, не, не, не, не, не: {e.Message}", "Ошибка");
                return default(T);
            }
        }
    }
}