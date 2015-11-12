using Xunit;

namespace SyrahTest.Core.Data
{
  [DataSource]
  internal class DataSourceProducer
  {
    [DataSource]
    public void methodA()
    {
      //SomeMethod("{{attributeName}}");
    }
  }

  public class DataSourceTestIT
  {
    DataStore dataStore = new DataStore();

    [Fact]
    public void ReadPropertyFromDefaultDataSource()
    {
      //DataStore.Scan(typeof(DataSourceProducer));
      DataSource ds = dataStore.Load();
      ds.SetRecord("$..nestedData");
      Assert.Equal("2", ds.GetValue("$.nestedData[1].id"));

    }
  }
}
