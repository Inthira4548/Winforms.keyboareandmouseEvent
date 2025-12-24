using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winforms.keyboareandmouseEvent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"พิกัดของตัวชี้: {e.X}, Y: {e.Y}";
            //ถ้าxและyเท่ากันจะแสดงข้อความพิเศษ
            if (e.X == e.Y)
                MessageBox.Show($"พิกัด X: {e.X} และ Y: {e.Y}| เท่ากัน");
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            // {
            //   MessageBox.Show("$คลิกเมาส์ซ้าย พิกัด X: {e.X} และ Y: {e.Y}");
            // }
            //  else if (e.Button == MouseButtons.Right)
            //  {
            //   MessageBox.Show("$คลิกเมาส์ขวา พิกัด X: {e.X} และ Y: {e.Y}");
            //  }

            //  if (e.Button == MouseButtons.Left)
            // {
            //   this.BackColor = Color.LightGreen;
            // }
            // else if (e.Button == MouseButtons.Right)
            // {
            //this.BackColor = Color.LightPink;
            // }
        }

        private void btnTest_MouseEnter(object sender, EventArgs e)
        {
            btnTest.BackColor = Color.Yellow;
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            btnTest.BackColor = Color.Red;
        }

        private void txtSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSource.Text))
            {
                txtSource.DoDragDrop(txtSource.Text, DragDropEffects.Copy);
            }
        }

        private void lblTarget_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
         bool dragging = false;
         Point startPoint;
        private void lblTarget_DragDrop(object sender, DragEventArgs e)
        {
            lblTarget.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnMove_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = e.Location;
        }

        private void btnMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                btnMove.Left += e.X - startPoint.X;
                btnMove.Top += e.Y - startPoint.Y;
            }
        }

        private void btnMove_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
