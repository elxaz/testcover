namespace Flax.FileManager
{
    public class LocalFileManager : IFileManager
    {
        public Task<string> Create(string filePath, bool strictCreation = false)
        {
            if(File.Exists(filePath))
            {
                if (strictCreation)
                    return Task.FromResult(string.Empty);

                string tempPath = filePath;
                int i = 1;
                while (File.Exists(tempPath))
                {
                    tempPath = filePath + $"({i})";
                }

                filePath = tempPath;
            }

            File.Create(filePath);

            return Task.FromResult(filePath);
        }

        public Task Delete(string filePath)
        {
            File.Delete(filePath);
            return Task.CompletedTask;
        }

        public Task<string> Read(string filePath)
        {
            string text = File.ReadAllText(filePath);
            return Task.FromResult(text);
        }

        public Task Write(string filePath, string text)
        {
            return File.AppendAllTextAsync(filePath, text);
        }
    }
}