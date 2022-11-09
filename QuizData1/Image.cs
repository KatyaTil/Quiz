using System;

namespace QuizData1
{
    public class Image
    {
        public String Name { get; set; }

        public String Path { get; set; }

        public Image(String name, String path)
        {
            Name = name;
            Path = path;
        }
    }
}