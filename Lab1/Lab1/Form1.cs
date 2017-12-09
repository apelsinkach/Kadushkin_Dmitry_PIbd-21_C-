using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private Meat meat = new Meat();

        private Lemon lemon = new Lemon();

        private Spices spices;

        private WaterTap tap = new WaterTap();

        private Grille grille = new Grille();

        private Pot pot = new Pot();

        private Oil oil = new Oil();

        private Knife knife = new Knife();

        private Coal coal = new Coal();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meat = new Meat();      
                button1.Enabled = false;
                if (radioButton1.Checked) { button2.Visible = true; }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            lemon = new Lemon();           
                button3.Enabled = false;
                if (radioButton1.Checked) { button6.Visible = true; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (spices == null) spices = new Spices();
            spices.Count = 100;         
                button5.Enabled = false;
                if (isReadyToMarinade()) { addLemon_btn.Visible = true; }
        }

        private bool isReadyToMarinade()
        {       
            if (lemon == null) { return false; }
            else if (lemon.Has_cleaned != 10) { return false; }

            if (oil == null) { return false; }           
       
            if (spices == null) { return false; }         

            return true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!button1.Enabled) { button2.Visible = true; }
                if (!button3.Enabled) { button6.Visible = true; }
                tap.State = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (button2.Enabled) { button2.Visible = false; }
                if (button6.Enabled) { button6.Visible = false; }
                tap.State = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tap.WashingMeat(meat);
            if (meat.Dirty == 0) { button7.Visible = true; }
            button2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tap.WashingLemon(lemon);
            if (lemon.Dirty == 0) { button8.Visible = true; }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (meat.Dirty == 0) { knife.CuttingMeat(meat); }
            button7.Enabled = false;
            if (pot.MarinadeReady) { addMeat_btn.Visible = true; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oil = new Oil();       
                button4.Enabled = false;
                addOil_btn.Visible = true;
        }

        private void addOil_btn_Click(object sender, EventArgs e)
        {
            pot.AddOil(oil);
            addOil_btn.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            knife.CuttingLemon(lemon);
            button8.Enabled = false;
            if (isReadyToMarinade()) { addLemon_btn.Visible = true; }
        }

        private void addLemon_btn_Click(object sender, EventArgs e)
        {
            addLemon_btn.Enabled = false;
            pot.CreateMarinade(spices,lemon);
           spices = null;lemon = null;
            if (meat.Has_cleaned == 10) { addMeat_btn.Visible = true; }
        }

        private void addMeat_btn_Click(object sender, EventArgs e)
        {
            pot.addMeat(meat);
            meat = null;          
            getMeat_btn.Visible = true;
            addMeat_btn.Enabled = false;
            MessageBox.Show("Мясо замариновалось!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void getMeat_btn_Click(object sender, EventArgs e)
        {
            meat = pot.GetMeat();
            if (!grille.CoalReady())
            {
                MessageBox.Show("Теперь нужны угли!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else button9.Visible = true;
            getMeat_btn.Enabled = false;
            if (grille.CoalReady()) { button9.Visible = true; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            if (coal != null) { grille.Coal = coal; }
            else
            {
                MessageBox.Show("Нет угля!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                coal = new Coal();
                coal.Weight = 2000;
            }
            grille.Coal.IsBurning = true;
            while (!grille.CoalReady())
            {
                grille.CookCoal();
            }
            if (meat == null || !meat.Has_marinade) { MessageBox.Show("Теперь приготовьте мясо!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { button9.Visible = true; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            grille.Meat = meat;
            meat = null;
            while (!grille.isReady)
            { grille.Cook(); }
            meat = grille.Meat;
            if (meat.Has_ready)
            {
                MessageBox.Show("Шашлык готов!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
