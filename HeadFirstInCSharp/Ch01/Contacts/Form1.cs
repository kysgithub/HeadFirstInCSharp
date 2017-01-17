using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“contactsDBDataSet.People”中。您可以根据需要移动或删除它。
            this.peopleTableAdapter.Fill(this.contactsDBDataSet.People);
            // TODO: 这行代码将数据加载到表“contactsDBDataSet.People”中。您可以根据需要移动或删除它。
            this.peopleTableAdapter.Fill(this.contactsDBDataSet.People);

        }

        private void peopleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDBDataSet);

        }
    }
}
