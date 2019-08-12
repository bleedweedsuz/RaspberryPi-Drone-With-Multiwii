using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDrone
{
    public partial class CustomButton : UserControl
    {

        public delegate void _Clicked();
        private _Clicked clicked;
        [Browsable(true)]
        public string TitleBoxValue
        {
            get { return TitleBox.Text; }
            set { TitleBox.Text = value; }
        }
        [Browsable(true)]
        public Image IconBoxValue
        {
            get { return IconBox.Image; }
            set { IconBox.Image = value; }
        }
        [Browsable(true)]
        public bool IsButtonSelected
        {
            get { return SelectedBox.Visible; }
            set { SelectedBox.Visible = value; }
        }
        [Browsable(true)]
        public Color SelectBackColor
        {
            get { return SelectedBox.BackColor; }
            set { SelectedBox.BackColor = value; BorderPabel.BackColor = value; TitleBox.ForeColor = value; }
        }
        public CustomButton()
        {
            InitializeComponent();
        }
        public void EventRegister(_Clicked clicked)
        {
            this.clicked = clicked;
        }
        private void MainBackPanel_MouseHover(object sender, EventArgs e)
        {
            MainBackPanel.BackColor = StyleClass.TabButtonHover;
        }
        private void MainBackPanel_MouseLeave(object sender, EventArgs e)
        {
            MainBackPanel.BackColor = StyleClass.TabButtonColor;
        }
        private void MainBackPanel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (clicked == null) { return; }
                clicked.Invoke();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TitleBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (clicked == null) { return; }
                clicked.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ToggleSelect()
        {
            if (IsButtonSelected) { IsButtonSelected = false; } else { IsButtonSelected = true; }
            SelectedBox.Visible = IsButtonSelected;
        }
    }
}
