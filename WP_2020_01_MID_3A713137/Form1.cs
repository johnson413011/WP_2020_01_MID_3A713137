using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_MID_3A713137.Properties;

namespace WP_2020_01_MID_3A713137
{
    public partial class Form1 : Form
    {
        List<Image> pc = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tex.Text))
            {
                MessageBox.Show("請輸入國家", "錯誤");
                return;//重新檢查
            }
            else
            {
                switch (tex.Text)
                {
                    case "台灣":
                        pic.Image = pc[0]; break;
                    case "日本":
                        pic.Image = pc[1]; break;
                    case "菲律賓":
                        pic.Image = pc[2]; break;
                    case "印尼":
                        pic.Image = pc[3]; break;
                    case "泰國":
                        pic.Image = pc[4]; break;
                    case "中國":
                        pic.Image = pc[5]; break;
                    case "俄羅斯":
                        pic.Image = pc[6]; break;
                    case "美國":
                        pic.Image = pc[7]; break;
                    case "英國":
                        pic.Image = pc[8]; break;
                    case "韓國":
                        pic.Image = pc[9]; break;
                    default:
                        MessageBox.Show("文字不符，請重新輸入國家", "錯誤");
                        break;
                }
            }           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pc.Add(Resources._1);
            pc.Add(Resources._2);
            pc.Add(Resources._3);
            pc.Add(Resources._4);
            pc.Add(Resources._5);
            pc.Add(Resources._6);
            pc.Add(Resources._7);
            pc.Add(Resources._8);
            pc.Add(Resources._9);
            pc.Add(Resources._10);
        }
    }
}
