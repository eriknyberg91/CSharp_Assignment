using Business.Interfaces;

namespace Business.Services;

public class FileService : IFileService
{
    private string _directoryPath;
    private string _filePath;

    public FileService(string directoryPath = "Data", string fileName = "content.json") //Parameterar bidrar med default ifall annat inte fylls i
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName); // Skapar sökväg(?) till filen
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
            using var streamWriter = new StreamWriter(_filePath);
            streamWriter.WriteLine(data);

        }
    }
}
