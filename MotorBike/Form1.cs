using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MotorBike;

namespace MotorBike
{
    public partial class Form1 : Form
    {
        AKbikeEntities db = new AKbikeEntities();
        List<Table_Motorbike> bikes;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bikes = db.Table_Motorbike.ToList();
            ShowTiles();
        }

        void ShowTiles()
        {
            motorbikeTile1.Fill(bikes[index]);
            motorbikeTile2.Fill(bikes[index + 1]);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (index - 2 >= 0)
            {
                index -= 2;
                ShowTiles();
            }
        }// Выполнил Калашников Артём

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index + 2 < bikes.Count)
            {
                index += 2;
                ShowTiles();
            }
        }
    }
}