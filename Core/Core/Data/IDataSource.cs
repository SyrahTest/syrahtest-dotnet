namespace SyrahTest.Core.Data
{
  public interface IDataSource<DocumentType>
  {
    string GetValue(string expression);
    void SetRecord(string expression);
  }
}