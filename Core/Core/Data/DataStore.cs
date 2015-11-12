using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace SyrahTest.Core.Data
{
  public class DataStore : IDataStore
  {
    public DataSource Load()
    {
      JObject jsonDocument;
      string path = @"\Data\ReadPropertyFromDefaultDataSource.json";
      var currentDir = System.IO.Directory.GetCurrentDirectory();

      using (StreamReader file = File.OpenText(currentDir + path))
      using (JsonTextReader reader = new JsonTextReader(file))
      {
        jsonDocument = JToken.ReadFrom(reader) as JObject;
      }
      return new DataSource(jsonDocument);
    }
  }
}