using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLProject
{
    public partial class Form1 : Form
    {
        String category = "";
        String Auth = "";
        String Name="";
        public Form1()
        {
            InitializeComponent();
            Dictionary<String, String> test = new Dictionary<String, String>();
            test.Add("Romance", "Romance");
            test.Add("Horror", "Horror");
            test.Add("Science Fiction", "Science Fiction");
            test.Add("Computer", "Computer");
            test.Add("Fantasy", "Fantasy");
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
           String[] TT=c.LoadValues(category);
           
          //  char Split = '.';
            
            Dictionary<String, String> auth = new Dictionary<String, String>();
         foreach(String y in TT)
         {
             if(!auth.ContainsKey(y))
             {
                 auth.Add(y, y);
             }
             
           
             
         }
         comboBox2.DataSource = new BindingSource(auth, null);
      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = ((KeyValuePair<String, String>)comboBox1.SelectedItem).Value;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auth = ((KeyValuePair<String, String>)comboBox2.SelectedItem).Value;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder Temp = new StringBuilder();
            Controller c1 = new Controller();
            String [] YY=c1.LoadTitle(Auth);
            foreach(String t in YY)
            {
                Temp.Append(t);
                Temp.Append(",   ");

              
            }
            Dictionary<String, String> NameofBook = new Dictionary<String, String>();
            foreach (String t in YY)
            {
                if (!NameofBook.ContainsKey(t))
                {
                    NameofBook.Add(t,t);
                }



            }
            comboBox3.DataSource = new BindingSource(NameofBook, null);
            button3.Visible = true;
             //label1.Text = (Temp.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller n = new Controller();
            String Value=n.GetPrice(Name);
            label1.Text=Value;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
         Name = ((KeyValuePair<String, String>)comboBox3.SelectedItem).Value;
            button3.Visible = true;
        }
    }
}
