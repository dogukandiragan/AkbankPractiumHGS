using AkbankPracticumHGS.Core;
using AkbankPracticumHGS.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbankPracticumHGS
{
    public partial class Form1 : Form
    {
        Gise gise = new Gise();
        Data data = new Data();
        object arac = new object();

       

        public Form1()
        {
            InitializeComponent();
            ComboFill();
        }
   
   
        //creating a vehicle with random information
        private void button1_Click(object sender, EventArgs e)
        {
            BaseVehicle bv = data.CreateRandomVehicle();
            textBox1.Text = bv.HGSno;
            textBox2.Text = bv.Balance.ToString();
            comboBox1.Text = bv.Type;
            textBox3.Text = bv.Name;
            textBox4.Text = bv.Surname;
            arac = bv;
        }

        //vehicle types add
        public void ComboFill()
        {
            comboBox1.Items.Add("Car");
            comboBox1.Items.Add("Minibus");
            comboBox1.Items.Add("Bus");
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            //easy form validation
            if (textBox2.Text.Length > 0) {

                //get transitions and show on datagridview
                gecisler = gise.VehiclePass((BaseVehicle)arac);
                dataGridView1.DataSource = gecisler.ToList();


                //cleaning form after insert
                comboBox1.SelectedIndex =-1;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
        }




        //Daily Report for executive manager department
        List<TransactionDisplay> gecisler = new List<TransactionDisplay>();
        int total = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            
            // transition data separate by daily
            var re = gecisler.GroupBy(s => s.DateTime.ToShortDateString()).Select(grp => grp.ToList()).ToList();

   
            foreach( var day in re){
                total = 0;
                foreach(TransactionDisplay td in day)
                {
                    total = total + td.Payment;
                }
                //daily report adding to listbox
                listBox1.Items.Add(day[0].DateTime.ToShortDateString()+ " Tarihinde " + day.Count.ToString()+ " Araç "+ total.ToString() + " Lira Ödemiştir.");
            }

        }
    }
}
