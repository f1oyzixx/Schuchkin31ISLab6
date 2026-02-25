using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Schuchkin31ISLab6.ModelEF;

namespace Schuchkin31ISLab6
{
    public partial class FormAddUPDMD : Form
    {
        public FormAddUPDMD()
        {
            InitializeComponent();
        }
        private string Pic_Name;
        private List<Table_Motorbike> vsMotorbike = FormShowMot.DB.Table_Motorbike.ToList();

        private void FormAddUPDMD_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormShowMot form = new FormShowMot();
            form.Visible = true;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxModel.Text))
            {
                MessageBox.Show("Заполните все поля Модель и Марка!");
                return;
            }

            try
            {
                Convert.ToInt32(textBoxMileage.Text);
                Convert.ToInt32(textBoxHorsepower.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В полях Л/С и Пробег, могут быть только целочисленные данные");
                return;
            }

            try
            {
                Convert.ToSingle(textBoxPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В поле Цена, могут быть только числа с плавающей точкой");
                return;
            }

            if (!File.Exists(Pic_Name))
            {
                MessageBox.Show("Невозможно найти файл!");
                return;
            }
            File.Copy(Pic_Name, $@"Pictures\{FLplus1()}{Path.GetExtension(Pic_Name)}");

            Table_Motorbike NMotorbike = new Table_Motorbike();

            NMotorbike.ID = FLplus1();
            NMotorbike.Brand = textBoxBrand.Text;
            NMotorbike.Model = textBoxModel.Text;
            NMotorbike.Price = Convert.ToSingle(textBoxPrice.Text);
            NMotorbike.Horsepower = Convert.ToInt32(textBoxHorsepower.Text);
            NMotorbike.Mileage = Convert.ToInt32(textBoxMileage.Text);
            NMotorbike.Picture = $@"{FLplus1()}{Path.GetExtension(Pic_Name)}";

            try
            {
                FormShowMot.DB.Table_Motorbike.Add(NMotorbike);
                FormShowMot.DB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = null;
            }
            textBoxBrand.Text = null;
            pictureBox1.Image = null;
            Pic_Name = null;
        }
        private int FLplus1()
        {
            int max = 0;
            foreach (Table_Motorbike TB in vsMotorbike)
            {
                if (max < TB.ID) max = TB.ID;
            }
            return ++max;
        }

        private void FormAddUPDMD_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }

        private void textBoxHorsepower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void textBoxMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Pic_Name = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
