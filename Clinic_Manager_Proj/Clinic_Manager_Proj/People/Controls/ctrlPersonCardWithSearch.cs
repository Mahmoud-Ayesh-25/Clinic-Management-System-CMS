using DVLD_Project.MainSettings;
using System;
using System.Windows.Forms;

namespace Clinic_Manager_Proj.People.Controls
{
    public partial class ctrlPersonCardWithSearch : UserControl
    {
        public int PersonID { get { return ctrlPersonInfoCard1.PersonID; } }

        void LoadForDataBack(int PersonID)
        {
            ctrlPersonInfoCard1.LoadData(PersonID);
        }

        void _Find()
        {
            if (cbxFilter.SelectedIndex == 1)
            {
                if (!ctrlPersonInfoCard1.LoadData(int.Parse(tbxFilter.Content)))
                {
                    MessageBox.Show($"The person with the ID[{tbxFilter.Content}] was not found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ctrlPersonInfoCard1.LoadDefaultValues();
                }
            }

            if (cbxFilter.SelectedIndex == 2)
            {
                if (!ctrlPersonInfoCard1.LoadData(tbxFilter.Content))
                {
                    MessageBox.Show($"The person with the National No: \"{tbxFilter.Content}\" was not found.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ctrlPersonInfoCard1.LoadDefaultValues();
                }
            }
        }

        public bool LoadData(int PersonID)
        {
            if (ctrlPersonInfoCard1.LoadData(PersonID))
            {
                tbxFilter.Visible = false;
                cbxFilter.Visible = false;
                btnAddPerson.Visible = false;
                btnFind.Visible = false;
                return true;
            }

            return false;
        }

        public ctrlPersonCardWithSearch()
        {
            InitializeComponent();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0);
            btnFind.Visible = (cbxFilter.SelectedIndex != 0);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _Find();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _Find();
            }

            if (cbxFilter.SelectedIndex == 1)
            {
                if (!clsValidation.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson person = new frmAddUpdatePerson();
            person.DataBack += LoadForDataBack;
            person.ShowDialog();
        }
    }
}
