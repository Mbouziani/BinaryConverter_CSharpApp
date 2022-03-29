using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary_cnverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GB_bin.Visible = true; 
            GB_dec.Visible = false;
            GB_hex.Visible = false;
            GB_oct.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            x = 1;
            GB_bin.Visible = false;
            GB_dec.Visible = true;
            GB_hex.Visible = false;
            GB_oct.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            x = 1;
            GB_bin.Visible = true; 
            GB_dec.Visible = false;
            GB_hex.Visible = false;
            GB_oct.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            x = 1;
            GB_bin.Visible = false;
            GB_dec.Visible = false;
            GB_hex.Visible = false;
            GB_oct.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            x = 1;
            GB_bin.Visible = false;
            GB_dec.Visible = false;
            GB_hex.Visible = true;
            GB_oct.Visible = false;
        }

        // dicimal part
        private void octalcv ()
        {
            long remainder, dec, octal = 0, i = 1;
            LB_oct.Text = "";
            dec = nbr;

            // start converting
            while (dec != 0)
            {
                remainder = dec % 8;
                octal=octal+(remainder*i);
                dec = dec / 8;
                i = i * 10;
            }
            LB_oct.Text = (octal).ToString();
        }
        private void binaircv()
        {
            long i = 0, j, dnm;
            long[] bin=new long[100];
            LB_bin.Text = "";
            dnm = nbr;

            // start converting
            if (dnm == 0)
            {
                LB_bin.Text = "0";
            }
            while(dnm>0)
            {
                bin[i] = dnm % 2;
                dnm = dnm / 2;
                i++;
            }
            for (j = i - 1; j >= 0;j--)
            {
                if (LB_bin.Text == "")
                {
                    LB_bin.Text = bin[j].ToString();
                }
                else
                {
                    LB_bin.Text = LB_bin.Text + bin[j].ToString();
                }
            }

        }
        private void hexacv()
        {
            long dec, quo, i = 1, j, temp;
            char[] hexa = new char[100];
            LB_hex.Text = "";
            dec = nbr;

            // start converting
            quo = dec;

            while(quo!=0)
            {
                temp = quo % 16;
                // integer nbr to char
                if (temp < 10)
                {
                    temp = temp + 48;
                }
                else
                {
                    temp = temp + 55;
                }
                hexa[i++] = (char)temp;
                quo = quo / 16;
                i++;
            }

            for (j = i - 1; j > 0; j--)
            {
                if (LB_hex.Text == "")
                {
                    LB_hex.Text = hexa[j].ToString();
                }
                else
                {
                    LB_hex.Text = LB_hex.Text + hexa[j].ToString();
                }
            }
        }
       
        int x = 0;
        long nbr = 0;
        
        private void button7_Click(object sender, EventArgs e)
        {
           
            if (x == 1)
            { 
                LB_dec.Text = "";
                x = 0;
            }
            
            if (LB_dec.Text == "")
            {
                LB_dec.Text = "1";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "1";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "" || LB_dec.Text == "0")
            {
                LB_dec.Text = "0";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else 
            {
                LB_dec.Text = LB_dec.Text + "0";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "2";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "2";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "3";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "3";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "4";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "4";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "5";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "5";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "6";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "6";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "7";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "7";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "8";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "8";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_dec.Text = "";
                x = 0;
            }

            if (LB_dec.Text == "")
            {
                LB_dec.Text = "9";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
            else
            {
                LB_dec.Text = LB_dec.Text + "9";
                nbr = Convert.ToInt64(LB_dec.Text);
                octalcv();
                binaircv();
                hexacv();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LB_bin.Text = "0";
            LB_dec.Text = "0";
            LB_hex.Text = "0";
            LB_oct.Text = "0";
            x = 1;
            nbr = 0;
        }
        

        // binarry partt

        private void decimcv()
        {
            long rem, binary, dec=0,i=1;
            LB_dec.Text = "";
            binary = nbr;

            while (binary > 0)
            {
                rem = binary % 2;
                dec = dec + (rem * i);
                binary = binary / 10;
                i = i * 2;
            }
            LB_dec.Text = (dec).ToString();
        }
        private void BtoO()
        {
            long remainder, binary, oct =0,dec = 0, i = 1;
            LB_oct.Text = "";
            binary = nbr;

            while (binary > 0)
            {
                remainder = binary % 2;
                dec = dec + (remainder * i);
                binary = binary / 10;
                i = i * 2;
            }
            i = 1;
            while (dec!=0)
            {
                remainder = dec % 8;
                oct = oct + (remainder * i);
                dec = dec / 8;
                i = i * 10;
            }
            LB_oct.Text = (oct).ToString();
        }
        private void BtoH()
        {
            long rem, binary, deci = 0, k = 1;
            long[] hexd = new long[1000];
            LB_hex.Text = "";
            binary = nbr;

            while (binary > 0)
            {
                rem = binary % 2;
                deci = deci + (rem *k);
                binary = binary / 10;
                k = k * 2;
            }
            long dec, quo, i = 1, j, temp;
            char[] hexa = new char[100];
            
            dec = deci;

            // start converting
            quo = dec;

            while (quo != 0)
            {
                temp = quo % 16;
                // integer nbr to char
                if (temp < 10)
                {
                    temp = temp + 48;
                }
                else
                {
                    temp = temp + 55;
                }
                hexa[i++] = (char)temp;
                quo = quo / 16;
                i++;
            }

            for (j = i - 1; j > 0; j--)
            {
                if (LB_hex.Text == "")
                {
                    LB_hex.Text = hexa[j].ToString();
                }
                else
                {
                    LB_hex.Text = LB_hex.Text + hexa[j].ToString();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_bin.Text = "";
                x = 0;
            }

            if (LB_bin.Text == "")
            {
                LB_bin.Text = "1";
                nbr = Convert.ToInt64(LB_bin.Text);
                decimcv();
                BtoH();
                BtoO();
            }
            else
            {
                LB_bin.Text = LB_bin.Text + "1";
                nbr = Convert.ToInt64(LB_bin.Text);
                decimcv();
                BtoH();
                BtoO();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_bin.Text = "";
                x = 0;
            }

            if (LB_bin.Text == "")
            {
                LB_bin.Text = "0";
                nbr = Convert.ToInt64(LB_bin.Text);
                decimcv();
                BtoH();
                BtoO();
            }
            else
            {
                LB_bin.Text = LB_bin.Text + "0";
                nbr = Convert.ToInt64(LB_bin.Text);
                decimcv();
                BtoH();
                BtoO();
            }
        }
        
        
        // octal part 
        private void OtoD()
        {
            long rem, octal, dec = 0, i = 1;
            LB_dec.Text = "";
            octal = nbr;

            while ( octal != 0)
            {
                rem = octal % 10;
                dec = dec + (rem * i);
                octal = octal / 10;
                i = i * 8;
            }
            LB_dec.Text = (dec).ToString();
        }
        private void OtoB()
        {
            //octal to decimal
            long rem, octal, dec = 0, k = 1;
            LB_bin.Text = "";
            octal = nbr;

            while (octal != 0)
            {
                rem = octal % 10;
                dec = dec + (rem * k);
                octal = octal / 10;
                k = k * 8;
            }
            
            // decimal to binaire
            long i = 0, j, dnm;
            long[] bin = new long[100];
            
            dnm = dec;

            // start converting
            if (dnm == 0)
            {
                LB_bin.Text = "0";
            }
            while (dnm > 0)
            {
                bin[i] = dnm % 2;
                dnm = dnm / 2;
                i++;
            }
            for (j = i - 1; j >= 0; j--)
            {
                if (LB_bin.Text == "")
                {
                    LB_bin.Text = bin[j].ToString();
                }
                else
                {
                    LB_bin.Text = LB_bin.Text + bin[j].ToString();
                }
            }
        }
        private void OtoH()
        {
            long rem, octal, decii = 0, k = 1;
            LB_hex.Text = "";
            octal = nbr;

            while (octal != 0)
            {
                rem = octal % 10;
                decii = decii + (rem * k);
                octal = octal / 10;
                k = k  * 8;
            }
            long dec, quo, i = 1, j, temp;
            char[] hexa = new char[100];

            dec = decii;

            // start converting
            quo = dec;

            while (quo != 0)
            {
                temp = quo % 16;
                // integer nbr to char
                if (temp < 10)
                {
                    temp = temp + 48;
                }
                else
                {
                    temp = temp + 55;
                }
                hexa[i++] = (char)temp;
                quo = quo / 16;
                i++;
            }

            for (j = i - 1; j > 0; j--)
            {
                if (LB_hex.Text == "")
                {
                    LB_hex.Text = hexa[j].ToString();
                }
                else
                {
                    LB_hex.Text = LB_hex.Text + hexa[j].ToString();
                }
            }
        }


        private void button37_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "1";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "1";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "0";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "0";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "2";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "3";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "3";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "4";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "4";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "5";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "5";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "6";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "6";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_oct.Text = "";
                x = 0;
            }

            if (LB_oct.Text == "")
            {
                LB_oct.Text = "7";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
            else
            {
                LB_oct.Text = LB_oct.Text + "7";
                nbr = Convert.ToInt64(LB_oct.Text);
                OtoD();
                OtoB();
                OtoH();
            }
        }
        
        
        //hexadecimal part
        private void HtoD()
        {
            LB_dec.Text = "";
            long dec = 0 ,val=0,len,lenpow;
            int i=0;

            string hexi;
            hexi = hex;

            len = hexi.Length;
            lenpow = hexi.Length;
            lenpow--;

            for (i = 0; i < len; i++)
            {
                switch (hexi[i])
                {
                        case'0': val=0; break;
                        case'1': val=1; break;
                        case'2': val=2; break;
                        case'3': val=3; break;
                        case'4': val=4; break;
                        case'5': val=5; break;
                        case'6': val=6; break;
                        case'7': val=7; break;
                        case'8': val=8; break;
                        case'9': val=9; break;
                        case'A': val=10; break;
                        case'B': val=11; break;
                        case'C': val=12; break;
                        case'D': val=13; break;
                        case'E': val=14; break;
                        case'F': val=15; break;
                }
                dec += val * Convert.ToInt64(Math.Pow(16, lenpow));
                lenpow--;

            }
            LB_dec.Text = (dec).ToString();

        }
        private void HtoB()
        {
            LB_bin.Text = "";
            long dec = 0, val = 0, len, lenpow;
            int i = 0;


            string hexi;
            hexi = hex;

            len = hexi.Length;
            lenpow = hexi.Length;
            lenpow--;

            for (i = 0; i < len; i++)
            {
                switch (hexi[i])
                {
                    case '0': val = 0; break;
                    case '1': val = 1; break;
                    case '2': val = 2; break;
                    case '3': val = 3; break;
                    case '4': val = 4; break;
                    case '5': val = 5; break;
                    case '6': val = 6; break;
                    case '7': val = 7; break;
                    case '8': val = 8; break;
                    case '9': val = 9; break;
                    case 'A': val = 10; break;
                    case 'B': val = 11; break;
                    case 'C': val = 12; break;
                    case 'D': val = 13; break;
                    case 'E': val = 14; break;
                    case 'F': val = 15; break;
                }
                dec += val * Convert.ToInt64(Math.Pow(16, lenpow));
                lenpow--;

            }

            // decimal to binaire

            long k = 0, j, dnm;
            long[] bin = new long[100];
            dnm = dec;

            // start converting
            if (dnm == 0)
            {
                LB_bin.Text = "0";
            }
            while (dnm > 0)
            {
                bin[k] = dnm % 2;
                dnm = dnm / 2;
                k++;
            }
            for (j = k - 1; j >= 0; j--)
            {
                if (LB_bin.Text == "")
                {
                    LB_bin.Text = bin[j].ToString();
                }
                else
                {
                    LB_bin.Text = LB_bin.Text + bin[j].ToString();
                }
            }
        }
        private void HtoO()
        {
            LB_oct.Text = "";
            long dec = 0, val = 0, len, lenpow;
            int i = 0;


            string hexi;
            hexi = hex;

            len = hexi.Length;
            lenpow = hexi.Length;
            lenpow--;

            for (i = 0; i < len; i++)
            {
                switch (hexi[i])
                {
                    case '0': val = 0; break;
                    case '1': val = 1; break;
                    case '2': val = 2; break;
                    case '3': val = 3; break;
                    case '4': val = 4; break;
                    case '5': val = 5; break;
                    case '6': val = 6; break;
                    case '7': val = 7; break;
                    case '8': val = 8; break;
                    case '9': val = 9; break;
                    case 'A': val = 10; break;
                    case 'B': val = 11; break;
                    case 'C': val = 12; break;
                    case 'D': val = 13; break;
                    case 'E': val = 14; break;
                    case 'F': val = 15; break;
                }
                dec += val * Convert.ToInt64(Math.Pow(16, lenpow));
                lenpow--;

            }
            // dicimal to octal
            long remainder, deci, octal = 0, l = 1;
            LB_oct.Text = "";
            deci = dec;

            // start converting
            while (deci != 0)
            {
                remainder = deci % 8;
                octal = octal + (remainder * l);
                deci = deci / 8;
                l = l * 10;
            }
            LB_oct.Text = (octal).ToString();
        }
            

        string hex;
        private void button21_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "1";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
               
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "1";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
                
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;

            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "A";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();

            }
            else
            {
                LB_hex.Text = LB_hex.Text + "A";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "B";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();

            }
            else
            {
                LB_hex.Text = LB_hex.Text + "B";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "0";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "0";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "2";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "2";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "3";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "3";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "4";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "4";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "5";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "5";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "6";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "6";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "7";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "7";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "8";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "8";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "9";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "9";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "D";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "D";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "E";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "E";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "F";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "F";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LB_hex.Text = "";
                x = 0;
            }

            if (LB_hex.Text == "")
            {
                LB_hex.Text = "C";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
            else
            {
                LB_hex.Text = LB_hex.Text + "C";
                hex = LB_hex.Text;
                HtoD();
                HtoB();
                HtoO();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        


    }
}
