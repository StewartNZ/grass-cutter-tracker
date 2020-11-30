using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrassCutterTracker
{
    public partial class frm_Item : Form
    {
        private cls_Item _Item;

        public frm_Item()
        {
            InitializeComponent();
            dtp_Date.MaxDate = DateTime.Today;

            cbo_Type.DataSource = cls_Item.ItemTypes.Values.ToList();
            cbo_Type.SelectedIndex = 0;
        }

        public bool ShowDialog(cls_Item item)
        {
            _Item = item;

            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void UpdateDisplay()
        {
            dtp_Date.MaxDate = DateTime.Today;
            dtp_Date.MinDate = DateTimePicker.MinimumDateTime;

            txt_Code.Text = _Item.Code;
            txt_Name.Text = _Item.Name;
            cbo_Type.SelectedIndex = Convert.ToInt32(_Item.Type);
            chk_Paid.Checked = _Item.Paid;
            dtp_Date.Value = _Item.Date;

            txt_Code.Enabled = String.IsNullOrEmpty(_Item.Code);
        }

        private bool PushData()
        {
            Dictionary<string, string> lcValuesToCheck = new Dictionary<string, string> {
                    { "Code", txt_Code.Text },
                    { "Name", txt_Name.Text }
                };

            if (cls_Extensions.InputErrorCheck(lcValuesToCheck))
            {
                return false;
            }

            _Item.Code = txt_Code.Text;
            _Item.Name = txt_Name.Text;
            _Item.Type = cbo_Type.SelectedIndex;
            _Item.Date = dtp_Date.Value;
            _Item.Paid = chk_Paid.Checked;

            return true;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (txt_Code.Enabled && cls_GrassCutterTracker.ItemList.ContainsKey(txt_Code.Text))
            {
                MessageBox.Show("Item with that Code already exists", "Duplicate Item Code");
            }
            else
            {
                if (PushData())
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_Item_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK && MessageBox.Show("Are you sure? All changes will be lost.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
