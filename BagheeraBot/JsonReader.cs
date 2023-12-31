using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagheeraBot
{
    public class JsonReader
    {
        public string token { get; set; }
        public string prefix { get; set; }

        
        public async Task ReadJson()
        {
            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JsonStructure data = JsonConvert.DeserializeObject<JsonStructure>(json);

                this.token = data.token;
                this.prefix = data.prefix;
            }
            #region Deserializing from a Path
            //string filePath = @"";
            //string fileData = File.ReadAllText(filePath);

            //JsonStructure convertFromJson = JsonConvert.DeserializeObject<JsonStructure>(filePath); 
            #endregion
        }
    }
    internal sealed class JsonStructure
    {
        public string token { set; get; }
        public string prefix { set; get; }
    }
}
