using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tableadapter_csharp
{
    public partial class frteacher : Form
    {
        public frteacher()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teacher_attendanceDataSet);

        }

        private void frteacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.teacher_attendanceDataSet.teachers);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string name = Teacher_name.Text;
            this.teachersTableAdapter.Insert(name);
            this.teachersTableAdapter.Fill(this.teacher_attendanceDataSet.teachers);
        }
    }
}
