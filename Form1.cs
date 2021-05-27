using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswortGenerator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnJgldiff_Click(object sender, EventArgs e) {
            textBox3.Text = generatePass();
        }

        private string generatePass() {
            string RoomID = "";
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkömnopqrstuvw!$&(/&%$=?(%&%@=/";
            Random r = new Random();
            for (int i = 0; i < 40; i++) {
                int randomCode = r.Next(0, characters.Length);
                RoomID = RoomID + characters[randomCode];
            }
            return RoomID;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
            if (textBox3.Text.Length < 1) {
                MessageBox.Show("inputbox is empty", "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                Clipboard.SetText(textBox3.Text);
            }
          
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
