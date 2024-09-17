using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graafinentehtava19
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            MeistaPL.Visible = true;
        }

        private void RuokalistaForm_Load(object sender, EventArgs e) // latautuessaan tapahtuu seuraavat asiat:
        {
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            MeistaLB.Text += "klo 9:00 - 14:30 joka päivä ma-to ja pe \n";
            MeistaLB.Text += "klo 9:00-12:30. \n\nKeudan oppilaskunnan kahvilasta saa lämpimien \n";
            MeistaLB.Text += "juomien lisäksi virvokkeita ja pientä purtavaa sekä makeisia \n";
            MeistaLB.Text += "Tervetuloa tutustumaan!";
            MeistaLB.Font = new Font("Arial", 12);
                
        }

        private void button1_Click(object sender, EventArgs e)//meistä
        {
            MeistaPL.Visible = true; // aina se näkyy mistä painikkeesta on painettu ja muut eivät näy
            RuuatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e) //ruuat
        {
            MeistaPL.Visible = false;
            RuuatPL.Visible = true;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e) //juomat
        {
            MeistaPL.Visible = false;
            RuuatPL.Visible = false;
            JuomatPL.Visible = true;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e) //herkut
        {
            MeistaPL.Visible = false;
            RuuatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = true;
            KoriPL.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e) // kori
        {
            MeistaPL.Visible = false;
            RuuatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = true;
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

