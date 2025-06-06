using System.Collections.Generic;
using System.Windows.Forms;

namespace zd1Shop_Rogov
{
    public partial class Form1 : Form
    {
        Playlist music;
        Shop ashan;
        decimal money = 1000;
        decimal profit = 0;
        int currentIndex = 0;
        bool isDuplicate = false;
        public Form1()
        {
            InitializeComponent();
            //Создание объектов продуктов
            ashan = new Shop();
            ashan.CreateProduct("Ржаной", 30, 100);
            ashan.CreateProduct("Хлеб \"Бородинский\"", 40, 40);
            ashan.CreateProduct("Пышки", 35, 75);
            ashan.CreateProduct("Пшеничный", 35, 150);
            ashan.CreateProduct("Тостовый", 50, 150);
            foreach (var product in Shop.products.Keys)
                comboBoxName.Items.Add(product.Name.ToString() + ", " + product.Price.ToString() + " руб");
            CheckListProduct();

            //Создание объектов песен
            music = new Playlist();
            music.CreateSong("Вторник", "кис-кис", "albom/kis-kis.mp4");
            music.CreateSong("Крапива", "BELOGLAZOV", "albom/krapiva.mp4");
            music.CreateSong("Перемен", "КИНО", "albom/peremen.mp4");
            music.CreateSong("Лето", "MellSher", "albom/leto.mp4");
            music.CreateSong("Мне хорошо", "MellSher", "albom/horosho.mp4");
            foreach (var song in Playlist.list)
                comboBoxName.Items.Add(song.Title.ToString() + ", " + song.Author.ToString() + ", " + song.Filename.ToString() + ", ");
            CheckListSong();
            if (listMusic.Items.Count > 0) listMusic.SetSelected(currentIndex, true);
            
        }

        //Покупка продуктов
        private void buy_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedIndex != -1 && countProducts.Value != 0)
            {
                int count = (int)countProducts.Value;
                string[] product = comboBoxName.SelectedItem.ToString().Split(',');
                string name = product[0];
                if (ashan.Sell(name, count) != null)
                    MessageBox.Show(ashan.Sell(name, count), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (money - ashan.FindByName(name).Price * count >= 0)
                    {
                        if (Shop.products[ashan.FindByName(name)] >= count)
                        {
                            money -= ashan.FindByName(name).Price * count;
                            profit += ashan.FindByName(name).Price * count;
                            wallet.Text = money.ToString() + " руб";
                            labelProfit.Text = profit.ToString() + " руб";
                            CheckListProduct();
                        }
                        else
                            MessageBox.Show("Недостаточно товара в наличии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Недостаточно средств", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Выберите продукт и количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Заполнение ListBox продуктов
        private void CheckListProduct()
        {
            listProducts.Items.Clear();
            listProducts.Visible = true;
            string list = ashan.WriteAllProducts();
            string[] products = list.Split('\n');
            for (int i = 1; i < products.Length; i++)
                listProducts.Items.Add(products[i]);
        }
        //Заполнение ListBox песен
        private void CheckListSong()
        {
            listMusic.Items.Clear();
            listMusic.Visible = true;
            string list = music.getMusicList();
            string[] musicList = list.Split('\n');
            for (int i = 0; i < musicList.Length - 1; i++)
                listMusic.Items.Add($"{i + 1}) " + musicList[i]);
            if (listMusic.Items.Count > 0)  listMusic.SetSelected(currentIndex, true);
            //Ограничения для NumericUpDown для избежания выхода за границы
            numericAdd.Maximum = listMusic.Items.Count+1;
            numericPerehod.Maximum = listMusic.Items.Count;
            numericDelete.Maximum = listMusic.Items.Count;
            numericPerehod.Minimum = 1;
            numericDelete.Minimum = 1;
        }
        //Добавление песен
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != "" && textBoxAuthor.Text != "" && textBoxPath.Text != "")
            {
                foreach (var item in listMusic.Items)
                {
                    string temp = item.ToString().Substring(3);
                    if (temp == $"Название: {textBoxTitle.Text}, Автор: {textBoxAuthor.Text}, Путь к файлу: {textBoxPath.Text}")
                    {
                        isDuplicate = true;
                        break;
                    }
                        
                }
                if (!isDuplicate)
                {
                    music.CreateSong(textBoxTitle.Text, textBoxAuthor.Text, textBoxPath.Text);
                } else MessageBox.Show("Песня от этого автора уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Заполните поля добавления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CheckListSong();
        }
        //Добавление песен по индексу
        private void buttonAddIndex_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != "" && textBoxAuthor.Text != "" && textBoxPath.Text != "")
            {
                if ((int)numericAdd.Value - 1 <= listMusic.Items.Count)
                {
                    music.CreateSong(textBoxTitle.Text, textBoxAuthor.Text, textBoxPath.Text, (int)numericAdd.Value - 1);
                }
                else MessageBox.Show("Введите правильный индекс!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Заполните поля заполнения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CheckListSong();
        }
        //Удаление песен по индексу
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                music.DeleteSong((int)numericDelete.Value - 1);
                if (currentIndex != 0)
                {
                    currentIndex--;
                }
                CheckListSong();
            } else MessageBox.Show("Плейлист пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //Удаление песен по имени
        private void buttonDeleteName_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                music.DeleteSong(textBoxDeleteName.Text);
                if (currentIndex != 0)
                {
                    currentIndex--;
                }
                CheckListSong();
            }
            else MessageBox.Show("Плейлист пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Отчистка плейлиста
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
                music.ClearSongs();
            else MessageBox.Show("Плейлист уже пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CheckListSong();
            currentIndex = 0;
        }
        //Переход на пред. песню
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                if (currentIndex < listMusic.Items.Count && currentIndex >= 1)
                {
                    currentIndex--;
                    if (listMusic.Items.Count > 0) listMusic.SetSelected(currentIndex, true);
                }
                else currentIndex++;
            } 
            else MessageBox.Show("Плейлист пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //Переход на след. песню
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                currentIndex++;
                if (currentIndex < listMusic.Items.Count)
                {
                    if (listMusic.Items.Count > 0)  listMusic.SetSelected(currentIndex, true);
                }
                else
                    currentIndex--;
            }
            else MessageBox.Show("Плейлист пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //Переход в начало плейлиста
        private void buttonToStart_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                if (listMusic.Items.Count > 0)  listMusic.SetSelected(0, true);
                currentIndex = 0;
            }
        }
        //Переход в конец плейлиста
        private void buttonToFinish_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                if (listMusic.Items.Count > 0)  listMusic.SetSelected(listMusic.Items.Count - 1, true);
                currentIndex = listMusic.Items.Count - 1;
            }
            else MessageBox.Show("Плейлист пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Переход к конкретной песне
        private void buttonPerehod_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)  listMusic.SetSelected((int)numericPerehod.Value - 1, true);
            else MessageBox.Show("Плейлист пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            currentIndex = (int)numericPerehod.Value - 1;
        }
    }
}
