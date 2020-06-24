// Palak Depani, 000787449
// Date - 25 October 2019
// I, Palak depani, student no 000787449, cerify that all code submitted is my own work;that i have not copied from any other source .
//I also certify that i have not allowed my work to be copied by other
// purpose - it print the appropriate data from text file according to user input




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace lab3B
{
    public partial class Form1 : Form
    {
        // two parameter 

        private int choice = 0;

        private int total;

        // default constructor
        public Form1()
        {
            InitializeComponent();

            if (serviceListBox.SelectedItems.ToString() == "Cut")
            {
                // enable service button 
                addserviceButton.Enabled = true;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // add service button click activity
        private void button1_Click(object sender, EventArgs e)
        {   
            
            dressercomboBox.Enabled = false;
            // it enable total button
            totalButton.Enabled = true;


            if (choice == 1)
            {
                // select dresser from dresser list
                chargesListBox.Items.Add(dressercomboBox.SelectedItem);
                choice = 2;

                // switch case after dreser selection 
                switch (dressercomboBox.SelectedItem.ToString())
                {
                    //there are different prices for different hair artist
                    case "Jane":
                        priceListBox.Items.Add("$30");
                        total = total + 30;
                        break;

                    case "Pat":
                        priceListBox.Items.Add("$45");
                        total = total + 45;
                        break;

                    case "Ron":
                        priceListBox.Items.Add("$40");
                        total = total + 40;
                        break;

                    case "Sue":
                        priceListBox.Items.Add("$50");
                        total = total + 50;
                        break;

                    case "Laurie":
                        priceListBox.Items.Add("$55");
                        total = total + 55;
                        break;
                }
            }

            // now add selected service charge 
            chargesListBox.Items.Add(serviceListBox.SelectedItem);

            // switch case for service selected
            switch (serviceListBox.SelectedItem.ToString())
            {
                
                //different price for different services 
                // price for cutting service
                case "Cut":
                    priceListBox.Items.Add("$30");
                    total = total + 30;
                    break;

                // charges for wash and blow dry
                case "Wash, blow-dry and style":
                    priceListBox.Items.Add("$20");
                    total = total + 20;
                    break;
                
                // charge for service color
                case "Colour":
                    priceListBox.Items.Add("$40");
                    total = total + 40;
                    break;

                // charges for service highlight
                case "Highlights":
                    priceListBox.Items.Add("$50");
                    total = total + 50;
                    break;
 
                // charges for service extension
                case "Extensions":
                    priceListBox.Items.Add("$200");
                    total = total + 200;
                    break;
              
                // charges for up do service
                case "Up-do":
                    priceListBox.Items.Add("$60");
                    total = total + 60;
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {   
            // give total ofservices selected
            label1.Text = string.Format($"{total:C}");
        }

        // this exit the application
        private void button4_Click(object sender, EventArgs e)
        {   //close the application
            Application.Exit();
        }

        // this reset the form , clear selected service and dresser
        private void button3_Click(object sender, EventArgs e)
        {
            // this clear application
            dressercomboBox.SelectedItem = 0;
            serviceListBox.ClearSelected();

            // clear charge display box
            chargesListBox.Items.Clear();

            // clear the price list display for selected services
            priceListBox.Items.Clear();

            // it null the total charge display label
            label1.Text = null;

            // again enable dresser selection combobox
            dressercomboBox.Enabled = true;

            total = 0;
            // show by default dresser one
            choice = 1;
        }

        // if dresser selected then it enable add service button
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dressercomboBox.SelectedIndex > -1 && serviceListBox.SelectedIndex > -1)
            {
                addserviceButton.Enabled = Enabled;
            }

        }

        // when form loaded is display below things
        private void Form1_Load(object sender, EventArgs e)
        {
            choice = 1;
            addserviceButton.Enabled = false;
            totalButton.Enabled = false;

        }


    }
}
