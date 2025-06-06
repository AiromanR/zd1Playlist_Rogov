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
            //�������� �������� ���������
            ashan = new Shop();
            ashan.CreateProduct("������", 30, 100);
            ashan.CreateProduct("���� \"�����������\"", 40, 40);
            ashan.CreateProduct("�����", 35, 75);
            ashan.CreateProduct("���������", 35, 150);
            ashan.CreateProduct("��������", 50, 150);
            foreach (var product in Shop.products.Keys)
                comboBoxName.Items.Add(product.Name.ToString() + ", " + product.Price.ToString() + " ���");
            CheckListProduct();

            //�������� �������� �����
            music = new Playlist();
            music.CreateSong("�������", "���-���", "albom/kis-kis.mp4");
            music.CreateSong("�������", "BELOGLAZOV", "albom/krapiva.mp4");
            music.CreateSong("�������", "����", "albom/peremen.mp4");
            music.CreateSong("����", "MellSher", "albom/leto.mp4");
            music.CreateSong("��� ������", "MellSher", "albom/horosho.mp4");
            foreach (var song in Playlist.list)
                comboBoxName.Items.Add(song.Title.ToString() + ", " + song.Author.ToString() + ", " + song.Filename.ToString() + ", ");
            CheckListSong();
            if (listMusic.Items.Count > 0) listMusic.SetSelected(currentIndex, true);
            
        }

        //������� ���������
        private void buy_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedIndex != -1 && countProducts.Value != 0)
            {
                int count = (int)countProducts.Value;
                string[] product = comboBoxName.SelectedItem.ToString().Split(',');
                string name = product[0];
                if (ashan.Sell(name, count) != null)
                    MessageBox.Show(ashan.Sell(name, count), "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (money - ashan.FindByName(name).Price * count >= 0)
                    {
                        if (Shop.products[ashan.FindByName(name)] >= count)
                        {
                            money -= ashan.FindByName(name).Price * count;
                            profit += ashan.FindByName(name).Price * count;
                            wallet.Text = money.ToString() + " ���";
                            labelProfit.Text = profit.ToString() + " ���";
                            CheckListProduct();
                        }
                        else
                            MessageBox.Show("������������ ������ � �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("������������ �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("�������� ������� � ����������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //���������� ListBox ���������
        private void CheckListProduct()
        {
            listProducts.Items.Clear();
            listProducts.Visible = true;
            string list = ashan.WriteAllProducts();
            string[] products = list.Split('\n');
            for (int i = 1; i < products.Length; i++)
                listProducts.Items.Add(products[i]);
        }
        //���������� ListBox �����
        private void CheckListSong()
        {
            listMusic.Items.Clear();
            listMusic.Visible = true;
            string list = music.getMusicList();
            string[] musicList = list.Split('\n');
            for (int i = 0; i < musicList.Length - 1; i++)
                listMusic.Items.Add($"{i + 1}) " + musicList[i]);
            if (listMusic.Items.Count > 0)  listMusic.SetSelected(currentIndex, true);
            //����������� ��� NumericUpDown ��� ��������� ������ �� �������
            numericAdd.Maximum = listMusic.Items.Count+1;
            numericPerehod.Maximum = listMusic.Items.Count;
            numericDelete.Maximum = listMusic.Items.Count;
            numericPerehod.Minimum = 1;
            numericDelete.Minimum = 1;
        }
        //���������� �����
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != "" && textBoxAuthor.Text != "" && textBoxPath.Text != "")
            {
                foreach (var item in listMusic.Items)
                {
                    string temp = item.ToString().Substring(3);
                    if (temp == $"��������: {textBoxTitle.Text}, �����: {textBoxAuthor.Text}, ���� � �����: {textBoxPath.Text}")
                    {
                        isDuplicate = true;
                        break;
                    }
                        
                }
                if (!isDuplicate)
                {
                    music.CreateSong(textBoxTitle.Text, textBoxAuthor.Text, textBoxPath.Text);
                } else MessageBox.Show("����� �� ����� ������ ��� ����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("��������� ���� ����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CheckListSong();
        }
        //���������� ����� �� �������
        private void buttonAddIndex_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != "" && textBoxAuthor.Text != "" && textBoxPath.Text != "")
            {
                if ((int)numericAdd.Value - 1 <= listMusic.Items.Count)
                {
                    music.CreateSong(textBoxTitle.Text, textBoxAuthor.Text, textBoxPath.Text, (int)numericAdd.Value - 1);
                }
                else MessageBox.Show("������� ���������� ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("��������� ���� ����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CheckListSong();
        }
        //�������� ����� �� �������
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
            } else MessageBox.Show("�������� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //�������� ����� �� �����
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
            else MessageBox.Show("�������� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //�������� ���������
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
                music.ClearSongs();
            else MessageBox.Show("�������� ��� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CheckListSong();
            currentIndex = 0;
        }
        //������� �� ����. �����
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
            else MessageBox.Show("�������� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //������� �� ����. �����
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
            else MessageBox.Show("�������� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //������� � ������ ���������
        private void buttonToStart_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                if (listMusic.Items.Count > 0)  listMusic.SetSelected(0, true);
                currentIndex = 0;
            }
        }
        //������� � ����� ���������
        private void buttonToFinish_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)
            {
                if (listMusic.Items.Count > 0)  listMusic.SetSelected(listMusic.Items.Count - 1, true);
                currentIndex = listMusic.Items.Count - 1;
            }
            else MessageBox.Show("�������� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //������� � ���������� �����
        private void buttonPerehod_Click(object sender, EventArgs e)
        {
            if (listMusic.Items.Count > 0)  listMusic.SetSelected((int)numericPerehod.Value - 1, true);
            else MessageBox.Show("�������� ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            currentIndex = (int)numericPerehod.Value - 1;
        }
    }
}
