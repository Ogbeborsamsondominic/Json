using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ClassWork
{
    public class WriteToJson
    {
        public void WriteToJsons(List<Student> students)
        {
            string fullPath = JsonHelper.GetPath("data.json");

            string jsonString = JsonSerializer.Serialize(students);

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }
        }
    }
}
