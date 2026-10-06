using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SQLite;

namespace gameManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // ignore this... <:)
        }

        void list()
        {
            umutaEntities gameDox = new umutaEntities();
            dataGridView1.DataSource = gameDox.gameDox.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            umutaEntities gameDox = new umutaEntities();

            gameDox newGame = new gameDox();

            newGame.Game = txtGame.Text;
            newGame.Developer = txtDeveloper.Text;
            newGame.Genre = txtGenre.Text;
            newGame.Platform = txtPlatform.Text;
            newGame.Year = int.Parse(txtYear.Text);
            newGame.Price = decimal.Parse(txtPrice.Text);
            newGame.AgeRating = int.Parse(txtAgeRating.Text);
            newGame.Score = decimal.Parse(txtScore.Text);
            newGame.GameMode = txtGameMode.Text;
            newGame.Stock = int.Parse(Stock.Text);

            gameDox.gameDox.Add(newGame);
            gameDox.SaveChanges();

            list();
        }
    }
}