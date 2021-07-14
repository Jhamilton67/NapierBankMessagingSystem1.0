using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Data
{
    public class Json
    {
        public void JSonSerialize(object data, string filePath)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (FileStream file = File.Open(filePath, FileMode.Open))
                using (StreamReader reader = new StreamReader(file))
                using (JsonReader jsonReader = new JsonTextReader(reader))
                {

                }

             
            }
            catch (Exception)
            {
                
            }

        }
        public void JsonDeserialize(string FilePath)
        {

        }
    }
}
