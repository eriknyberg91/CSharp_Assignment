using Business.Interfaces;

namespace Business.Services;

public class FileService : IFileService
{
    private string _directoryPath;
    private string _filePath;

    public FileService(string directoryPath = "Data", string fileName = "content.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName); 
    }



    public string GetFile()
    {
       if (File.Exists(_filePath))
        {
            using var streamReader = new StreamReader(_filePath);
            string data = streamReader.ReadToEnd();
            return data;
        }

        return null!;

    }

    public void SaveToFile(string data)
    {
        if (!Directory.Exists(_directoryPath))
        {   
            Directory.CreateDirectory(_directoryPath);
            using var streamWriter = new StreamWriter(_filePath);
            streamWriter.WriteLine(data);

        }

        else
        {
            using var streamWriter = new StreamWriter(_filePath);
            streamWriter.WriteLine(data);

        }
    }
}
