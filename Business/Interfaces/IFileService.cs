namespace Business.Interfaces;

public interface IFileService
{
    string GetFile();
    void SaveToFile(string data);
}
