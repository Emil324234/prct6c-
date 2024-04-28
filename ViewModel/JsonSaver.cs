using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.TextFormatting;

namespace prct6.ViewModel
{
    internal class JsonSaver //для json
    {

        //сериализация
        public static void SerializeObject<T>(T obj, string pathjson)
        {
            try
            {
                string txtjson = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText(pathjson, txtjson);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не, не, не, не, не: {e.Message}", "Ошибка");
            }
        }


        //десериализация
        public static T DeserializeObject<T>(string jsonStr)
        {
            try
            {
                var txtjson = File.ReadAllText(jsonStr);
                T deserializedObj = JsonConvert.DeserializeObject<T>(txtjson);
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
