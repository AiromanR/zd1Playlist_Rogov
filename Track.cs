using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1Shop_Rogov
{
    internal struct Song
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Filename { get; set; }


        public Song (string Title, string Author, string Filename)
        {
            this.Title = Title;
            this.Author = Author;
            this.Filename = Filename;
        }
        public string getInfo() 
        {
            return $"Название: {Title}, Автор: {Author}, Путь к файлу: {Filename}";
        }
    }
}
