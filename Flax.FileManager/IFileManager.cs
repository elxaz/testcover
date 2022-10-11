using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flax.FileManager
{
    public interface IFileManager
    {
        public Task Write(string filePath, string text);
        public Task<string> Read(string filePath);
        public Task<string> Create(string filePath, bool strictCreation = false);
        public Task Delete(string filePath);
    }
}
