using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace SyrahTest.Core.Data
{
  public class DataSource : IDataSource<JObject>
  {
    private JObject jsonDocument;

    public DataSource(JObject jsonDocument)
    {
      this.jsonDocument = jsonDocument;
    }

    public void SetRecord(string expression)
    {
    }

    public string GetValue(string expression)
    {
      return jsonDocument.SelectToken(expression).ToString();
    }
  }
}