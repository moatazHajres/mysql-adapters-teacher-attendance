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
    public partial class frcourse : Form
    {
        public frcourse()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teacher_attendanceDataSet);

        }

        private void frcourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.teacher_attendanceDataSet.courses);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string name = Course_name.Text;
            this.coursesTableAdapter.Insert(name);
            this.coursesTableAdapter.Fill(this.teacher_attendanceDataSet.courses);
        }
    }
}
