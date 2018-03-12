using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCV_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directoryPath = txtPath.Text;
            if (Directory.Exists(directoryPath))
            {

                //add controler
                string cont = txtPath.Text + @"\Controllers";
                if (Directory.Exists(cont))
                {
                    File.Create(cont + "/" + txtFunc.Text + "Controller.cs");
                }
                else
                {
                    string ms = "Thư mục Controler không tồn tại!";
                    MessageBox.Show(ms, "Thông báo");
                }

                //add Model
                string model = txtPath.Text + @"\Models";
                if (Directory.Exists(model))
                {
                    File.Create(model + "/" + txtFunc.Text + "Dto.cs");
                }
                else
                {
                    string ms = "Thư mục Model không tồn tại!";
                    MessageBox.Show(ms, "Thông báo");
                }

                //add View       
                string view = txtPath.Text + @"\Views";
                string targetPath = txtDes.Text;
                if (Directory.Exists(view))
                {
                    Directory.CreateDirectory(view + "/" + txtFunc.Text);
                    string des = view + "/" + txtFunc.Text;
                    if (Directory.Exists(targetPath))
                    {
                        string[] files = Directory.GetFiles(targetPath);

                        // Copy the files and overwrite destination files if they already exist.
                        foreach (string s in files)
                        {
                            // Use static Path methods to extract only the file name from the path.
                            string fileName = Path.GetFileName(s);
                            string destFile = Path.Combine(view, fileName);
                            File.Copy(s, destFile, true);
                        }
                    }else
                    {
                        string ms = "Thư mục View mẫu không tồn tại!";
                        MessageBox.Show(ms, "Thông báo");
                    }
                }
                else
                {
                    string ms = "Thư mục View không tồn tại!";
                    MessageBox.Show(ms, "Thông báo");
                }
            }
            else
            {
                string ms = "Đường dẫn không tồn tại!";
                MessageBox.Show(ms, "Thông báo");
            }

        }
    }
}
