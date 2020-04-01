using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OnceUponATime
{
    public class JsonParser
    {
        private string Filename;

        public void SetFilename(string filename)
        {
            Filename = filename;
        }

        public Series GetSeries()
        {
            
            return JsonConvert.DeserializeObject<Series>(File.ReadAllText(Filename));
            
        }
        
    }
}