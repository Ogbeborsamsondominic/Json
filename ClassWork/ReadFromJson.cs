using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ClassWork
{
    public class ReadFromJson
    {
        public List<Student> ReadFromJsons(string fileName)
        {
            string path = JsonHelper.GetPath(fileName);

            string jsonContent = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<Student>>(jsonContent);

        }
    }
}
