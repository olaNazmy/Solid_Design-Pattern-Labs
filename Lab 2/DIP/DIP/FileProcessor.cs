using DIP.Abstraction;
namespace DIP
{
    internal class FileProcessor
    {
        private readonly IFileReader fileReader;
        private readonly IFileWriter fileWriter;

        //inject in ctor
        public FileProcessor(IFileReader fileReader, IFileWriter fileWriter)
        {
            this.fileReader = fileReader;
            this.fileWriter = fileWriter;
        }
        //method to process file
        public void ProcessFile(string inputFilePath, string outputFilePath)
        {
            string fileContent = fileReader.ReadFile(inputFilePath);
            // Process the file content
            fileWriter.WriteFile(outputFilePath, fileContent);
        }
    }
}
