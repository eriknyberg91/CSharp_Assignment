namespace Business.Interfaces;

public interface IFileService
{
    void SaveToFile(string data);
    string GetFile();
}
