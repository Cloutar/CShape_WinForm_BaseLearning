using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0902
{
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();
        }

        [Browsable(true)]     //显示不显示的注解
        [Category ("Appearance")]   //放在哪里
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Xyz { get; set; }

        public string SearchText
        {
            get
            {
                return edit.Text;
            }
            set
            {
                edit.Text = value;
            }
        }

        /// <summary>
        /// 重写现有属性
        /// </summary>
        [Browsable(true)]     //显示不显示的注解
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return edit.Text;
            }
            set
            {
                edit.Text = value;
            }
        }


        //自定义事件
        public event EventHandler SearchEvent;

        private void btn_Click(object sender, EventArgs e)
        {
            //新版才能用?
            //SearchEvent?.Invoke(this, e);

            if (SearchEvent != null)
            {
                SearchEvent.Invoke(this, e);
            }
        }

    }
}
