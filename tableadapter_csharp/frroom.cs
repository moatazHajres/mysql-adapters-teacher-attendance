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
    public partial class frroom : Form
    {
        public frroom()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teacher_attendanceDataSet);

        }

        private void frroom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.teacher_attendanceDataSet.rooms);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string name = Room_name.Text;
            this.roomsTableAdapter.Insert(name);
            this.roomsTableAdapter.Fill(this.teacher_attendanceDataSet.rooms);

        }
    }
}
