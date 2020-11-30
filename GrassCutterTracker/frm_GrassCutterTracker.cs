using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GrassCutterTracker
{
    public partial class frm_GrassCutterTracker : Form
    {
        private DataTable _ItemTable;
        private BindingSource _ItemBindingSource = new BindingSource();

        private IComparer<cls_Item>[] _Comparer = { new cls_PaidComparer(), new cls_DateComparer(), new cls_NameComparer() };
        private readonly string[] _SortStrings = { "Paid", "Date", "Name" };

        private string fileName = "GrassCutterTracker.dat";

        public frm_GrassCutterTracker()
        {
            InitializeComponent();

            cbo_Sort.DataSource = _SortStrings;
            cbo_Sort.SelectedIndex = 0;

            dgv_Items.AutoGenerateColumns = true;

            MakeItemTable();
            _ItemBindingSource.DataSource = _ItemTable;
            dgv_Items.DataSource = _ItemBindingSource;

            dgv_Items.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            try
            {
                cls_GrassCutterTracker.Retrieve(fileName);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MakeItemTable()
        {
            try
            {
                // Create a new DataTable.
                DataTable ItemTable = new DataTable("ItemTable");
                // Declare variables for DataColumn and DataRow objects.
                DataColumn column;

                // Create new DataColumn, set DataType,
                // ColumnName and add to DataTable.
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Code";
                column.AutoIncrement = false;
                column.ReadOnly = true;
                column.Unique = true;
                // Add the Column to the DataColumnCollection.
                ItemTable.Columns.Add(column);

                // Create Name column.
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Name";
                column.AutoIncrement = false;
                column.ReadOnly = true;
                column.Unique = false;
                // Add the column to the table.
                ItemTable.Columns.Add(column);

                // Create Type column.
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Type";
                column.AutoIncrement = false;
                column.ReadOnly = true;
                column.Unique = false;
                // Add the column to the table.
                ItemTable.Columns.Add(column);

                // Create Date column.
                column = new DataColumn();
                column.DataType = Type.GetType("System.DateTime");
                column.ColumnName = "Date";
                column.AutoIncrement = false;
                column.ReadOnly = true;
                column.Unique = false;
                // Add the column to the table.
                ItemTable.Columns.Add(column);

                // Make the ID column the primary key column.
                DataColumn[] PrimaryKeyColumns = new DataColumn[1];
                PrimaryKeyColumns[0] = ItemTable.Columns["Code"];
                ItemTable.PrimaryKey = PrimaryKeyColumns;

                // Instantiate the DataSet variable.
                _ItemTable = ItemTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Item Storage Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillItemTable(List<cls_Item> ItemList)
        {
            try
            {
                if (_ItemTable != null)
                {
                    _ItemTable.Clear();
                }

                foreach (cls_Item lcItem in ItemList)
                {
                    DataRow row = _ItemTable.NewRow();
                    row["Code"] = lcItem.Code;
                    row["Name"] = lcItem.Name;
                    row["Type"] = cls_Item.ItemTypes[lcItem.Type];
                    row["Date"] = lcItem.Date;
                    _ItemTable.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Item Storage Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_GrassCutterTracker_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            List<cls_Item> lcItemList = cls_GrassCutterTracker.ItemList.Values.ToList();
            lcItemList.Sort(_Comparer[cbo_Sort.SelectedIndex]);
            FillItemTable(lcItemList);
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            cls_Item lcItem = new cls_Item();
            if (lcItem.ViewEdit())
            {
                cls_GrassCutterTracker.ItemList.Add(lcItem.Code, lcItem);
                UpdateDisplay();
            }
        }

        private cls_Item GetSelectedItem()
        {
            try
            {
                if (dgv_Items.SelectedCells.Count == 0)
                {
                    return null;
                }
                int rowIndex = dgv_Items.SelectedCells[0].RowIndex;
                string ItemCode = _ItemTable.Rows[rowIndex]["Code"].ToString();
                return cls_GrassCutterTracker.ItemList[ItemCode];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Item Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void EditItem()
        {
            cls_Item lcItem = GetSelectedItem();
            if (lcItem != null && lcItem.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void btn_EditItem_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void dgv_Items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditItem();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_GrassCutterTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            cls_GrassCutterTracker.Save(fileName);
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            cls_Item lcItem = GetSelectedItem();
            if (lcItem != null && MessageBox.Show("This Item will be deleted permanently, Continue?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    cls_GrassCutterTracker.ItemList.Remove(lcItem.Code);
                    UpdateDisplay();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_Items_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (cls_GrassCutterTracker.ItemList[dgv_Items.Rows[e.RowIndex].Cells[0].Value.ToString()].Paid)
            {
                e.CellStyle.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void cbo_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btn_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Dat File|*.dat|All Files|*.*";
            saveFileDialog1.Title = "Save Items";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                cls_GrassCutterTracker.Save(saveFileDialog1.FileName);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All Files|*.*|Dat File|*.dat";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    cls_GrassCutterTracker.Retrieve(openFileDialog.FileName);
                }
            }
            UpdateDisplay();
        }
    }

    class cls_DateComparer : IComparer<cls_Item>
    {
        public int Compare(cls_Item itemA, cls_Item itemB)
        {
            int lcResult = itemB.Date.Date.CompareTo(itemA.Date.Date);
            if (lcResult == 0)
            {
                int lcResult2 = itemA.Paid.CompareTo(itemB.Paid);
                if (lcResult2 == 0)
                {
                    return itemA.Name.CompareTo(itemB.Name);
                }
                else
                {
                    return lcResult2;
                }
            }
            else
            {
                return lcResult;
            }
        }
    }

    class cls_PaidComparer : IComparer<cls_Item>
    {
        public int Compare(cls_Item itemA, cls_Item itemB)
        {
            int lcResult = itemA.Paid.CompareTo(itemB.Paid);
            if (lcResult == 0)
            {
                int lcResult2 = itemB.Date.Date.CompareTo(itemA.Date.Date);
                if (lcResult2 == 0)
                {
                    return itemA.Name.CompareTo(itemB.Name);
                }
                else
                {
                    return lcResult2;
                }
            }
            else
            {
                return lcResult;
            }
        }
    }

    class cls_NameComparer : IComparer<cls_Item>
    {
        public int Compare(cls_Item itemA, cls_Item itemB)
        {
            int lcResult = itemA.Name.CompareTo(itemB.Name);
            if (lcResult == 0)
            {
                int lcResult2 = itemA.Paid.CompareTo(itemB.Paid);
                if (lcResult2 == 0)
                {
                    return itemB.Date.Date.CompareTo(itemA.Date.Date);
                }
                else
                {
                    return lcResult2;
                }
            }
            else
            {
                return lcResult;
            }
        }
    }
}
