using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1501
{
    class MySexCell : DataGridViewTextBoxCell
    {
        public MySexCell()
        {
            //
        }

        //该单元格的编辑器的类型
        public override Type EditType
        {
            get
            {
                return typeof(MySexCellEditor);
            }
        }

        //该单元格的值得类型
        public override Type ValueType
        {
            get
            {
                return typeof(string);
            }
        }

        //单元格的默认值 (创建新行时的默认值)
        //TODO
    }
}
