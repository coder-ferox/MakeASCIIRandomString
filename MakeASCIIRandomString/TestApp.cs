using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeRandomString
{
    public partial class TestApp : Form
    {

        MakeASCIIRandomString mars = new MakeASCIIRandomString();
        string msg = "Did you write how long the string should be?\n\nNote: A number slightly bigger than 6000 characters will result in a blank string (maybe a winform limit ?)";

        public TestApp()
        {
            InitializeComponent();
        }

        private void btnMakeLowerCaseLetters_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.LowerCaseLetters(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "LowerCaseLetters(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }

        }

        private void btnMakeUpperCaseLetters_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.UpperCaseLetters(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "UpperCaseLetters(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLength.Text, out int result) && (txtLength.Text != ""))
                txtResult.Text = "Please write an integer";
            else
                txtResult.Text = "";
        }

        private void btnMakeSymbols_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.Symbols(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "Symbols(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.Numbers(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "Numbers(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeLowerAndUpper_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixLetters(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixLetters(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeLowerCaseAndSymbols_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixLowerCaseLettersAndSymbols(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixLowerCaseLettersAndSymbols(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeUpperCaseAndSymbols_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixUpperCaseLettersAndSymbols(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixUpperCaseLettersAndSymbols(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeMixLCUCAndSymbols_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixAllKindOfLettersAndSymbols(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixAllKindOfLettersAndSymbols(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeNumbersAndSymbols_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixNumbersAndSymbols(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixNumbersAndSymbols(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeLowerCaseLettersAndNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixNumbersAndLowerCaseLetters(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixNumbersAndLowerCaseLetters(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeUpperCaseLettersAndNumber_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixNumbersAndUpperCaseLetters(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixNumbersAndUpperCaseLetters(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMixAll_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixAll(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixAll(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }

        private void btnMakeByPattern_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixByPattern(txtPattern.Text);
                txtMethod.Text = "MixByPattern(" + txtPattern.Text + ");";
            }
            catch (Exception ex)
            {
                string msgPattern = "Probably you didn't write a pattern near Go button, or you have written a bad pattern\n\nl -> lower case\nu -> upper case\ns -> symbol\nn -> number\n\nExample: nnlluuslu -> 61kuLO&rT";
                MessageBox.Show(msgPattern);
            }
        }


        private void txtPattern_MouseHover(object sender, EventArgs e)
        {
            ttPatternInstruction.Show("Accept only l,u,s,n combinations",txtPattern);
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipText = "Copied " + txtResult.Text + " in the clipboard..."
            };

            notification.ShowBalloonTip(5000);
        }

        private void bntAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MakeASCIIRandomString Class + Test App\nVersion 2.0 20171223\nMade by Danilo Cappellino\nhttp://www.github.com/coder-ferox");
            
        }

        private void btnMakeMixLCUCNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = mars.MixAllKindOfLettersAndNumbers(Convert.ToInt32(txtLength.Text));
                txtMethod.Text = "MixAllKindOfLettersAndNumbers(" + Convert.ToInt32(txtLength.Text) + ");";
            }
            catch (Exception ex)
            {
                MessageBox.Show(msg);
            }
        }
    }
}
