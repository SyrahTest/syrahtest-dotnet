namespace SyrahTest.Core.Data
{
  /// <summary>
  /// Responsible for the retrieval of data sources.
  /// May also optimize the caching of data sources.
  /// </summary>
  public interface IDataStore
  {
    DataSource Load();
  }
}