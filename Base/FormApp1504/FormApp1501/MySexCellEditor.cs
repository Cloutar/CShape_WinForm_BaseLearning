using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1501
{
    /**
     * 视频遮遮掩掩
     * 无法完成
     */
    class MySexCellEditor : ComboBox, IDataGridViewEditingControl
    {
        private DataGridView gridView;   //当前表格控件
        private bool valueChanged = true;   //用户是否改变了输入的值
        private int rowIndex = 0;   //所编辑的这一行的行号

        public MySexCellEditor()
        {
            this.Items.Add("男");
            this.Items.Add("女");
            this.SelectedIndex = 0;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            throw new NotImplementedException();
        }

        //当前表格控件
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return gridView;
            }
            set
            {
                gridView = value;
            }
        }

        //当前控件的值
        public object EditingControlFormattedValue
        {
            get
            {
                return this.SelectedItem;
            }
            set
            {
                if (value.Equals("男"))
                {
                    this.SelectedIndex = 0;
                }
                else
                {
                    this.SelectedIndex = 1;
                }
            }
        }

        //正在编辑的这一行的行号
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        //判断控件的值是否发生变化
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = true;
            }
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            throw new NotImplementedException();
        }

        public Cursor EditingPanelCursor
        {
            get { throw new NotImplementedException(); }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            throw new NotImplementedException();
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            throw new NotImplementedException();
        }

        public bool RepositionEditingControlOnValueChange
        {
            get { throw new NotImplementedException(); }
        }
    }
}
