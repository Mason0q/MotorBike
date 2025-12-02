using System;
using System.Drawing;
using System.Windows.Forms;
using MotorBike;

namespace MotorBike
{
    public partial class MotorbikeTile : UserControl
    {
        public MotorbikeTile()
        {
            InitializeComponent();
        }

        public void Fill(Table_Motorbike bike)
        {
            pictureBox1.Image = Image.FromFile($@"Pictures\{bike.Picture}");
            labelBrand.Text = bike.Brand;
            labelModel.Text = bike.Model;
            labelPrice.Text = $"{bike.Price:N0} ₽";
            labelPower.Text = $"{bike.Horsepower} л.с.";
            labelMileage.Text = $"{bike.Mileage:N0} км";
        } // Выполнил Калашников Артём
    }
}