using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1Shop_Rogov
{
    internal class Playlist
    {
        public static List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        //Создание объекта песня
        public void CreateSong(string Title, string Author, string Filename)
        {
            list.Add(new Song(Title, Author, Filename));
        }
        //Создание объекта песня по индексу(перегрузка)
        public void CreateSong(string Title, string Author, string Filename, int index)
        {
            list.Insert(index,new Song(Title, Author, Filename));
        }
        //Удаление объекта песня
        public void DeleteSong(int currentIndex)
        {
            list.RemoveAt(currentIndex);
        }
        //Удаление объекта песня по названию(перегрузка)
        public void DeleteSong(string name)
        {
            int i = 0;
            foreach (Song song in list)
            {
                i++;
                if (song.Title.ToLower() == name.ToLower())
                {
                    list.RemoveAt(i-1);
                    break;
                }
            }
        }
        //Отчистка объектов
        public void ClearSongs()
        {
            list.Clear();
        }
        //Получение определённой песни
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        //Получение плейлиста
        public string getMusicList()
        {
            string result = "";
            foreach (Song song in list)
                result += song.getInfo() + "\n";
            return result;
        }

    }
}
