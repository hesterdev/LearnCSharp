using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WAVirtualScreen
{
    public partial class SystemInfoBrowserForm : Form
    {
        public SystemInfoBrowserForm()
        {
            InitializeComponent();

            //Add each property of the SystemInformation class to the list box.
            Type t = typeof(SystemInformation);
            PropertyInfo[] pi = t.GetProperties();
            for (int i = 0; i < pi.Length; i++)
                listBox1.Items.Add(pi[i].Name);
            textBox1.Text = "The SystemInformation class has " + pi.Length.ToString() + " properties.\r\n";

            //Configure the list item selected handler for the list box to invoke a 
            //method that displays the value of each property.
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Return if no list item is selected.
            if (listBox1.SelectedIndex == -1)
                return;
            // Get the property name from the list item.
            string propname = listBox1.Text;

            if (propname == "PowerStatus")
            {
                // Cycle and display the values of each property of the PowerStatus property.
                textBox1.Text += "\r\nThe value of the PowerStatus property is:";
                Type t = typeof(PowerStatus);
                PropertyInfo[] pi = t.GetProperties();
                for(int i = 0; i < pi.Length; i++)
                {
                    object propval = pi[i].GetValue(SystemInformation.PowerStatus, null);
                    textBox1.Text = "\r\n    PowerStatus." + pi[i].Name + " is: " + propval.ToString();
                }
            }
            else
            {
                // Display the value of the selected property of the SystemInformation type.
                Type t = typeof(SystemInformation);
                PropertyInfo[] pi = t.GetProperties();
                PropertyInfo prop = null;
                for(int i=0;i<pi.Length;i++)
                    if (pi[i].Name == propname)
                    {
                        prop = pi[i];
                        break;
                    }
                object propval = prop.GetValue(null, null);
                textBox1.Text = "\r\nThe value of the " + propname + " property is: " + propval.ToString();
            }

        }
    }
}
