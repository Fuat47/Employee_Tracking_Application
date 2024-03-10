using PersonelTakip.Model;
using System.Text.Json;

namespace PersonelTakip
{
    public partial class frmMainForm : Form
    {
        int idCount = 1;
        Employee heldEmployee = null;
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fill in the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                

            Employee employee;

            if (heldEmployee == null)
            {
                employee = new Employee(idCount);
            }
            else
            {
                employee = heldEmployee;
            }
            employee.Name = txtName.Text;
            employee.Surname = txtSurname.Text;
            employee.Phone = txtPhone.Text;
            employee.Address = txtAddress.Text;
            employee.DepartmentId = cbDepartment.SelectedIndex;
            employee.StartDate = dtStartDate.Value;
            employee.NumOfChildren = (int)numChildren.Value;
            employee.isMilitartServiceDone = chkMilitary.Checked;
            employee.isForeingLanguage = chkForeign.Checked;
            employee.ohsStatus = rdOHSYes.Checked;
            employee.masteryStatus = rdMasteryYes.Checked;

            if (heldEmployee == null)
            {
                lbEmployees.Items.Add(employee);
                idCount++;
            }
            else
                lbEmployees.Items[lbEmployees.SelectedIndex] = employee;
            lblEmployeeNumber.Text = $"{lbEmployees.Items.Count} Employee";
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            ShowEmployee(null);
        }

        void ShowEmployee(Employee employee)
        {
            heldEmployee = employee;

            if (employee != null)
            {
                lblRecordInfo.Text = "Edited Record";
                btnUpdate.Text = "Update";
                txtName.Text = employee.Name;
                txtSurname.Text = employee.Surname;
                txtPhone.Text = employee.Phone;
                txtAddress.Text = employee.Address;
                cbDepartment.SelectedIndex = employee.DepartmentId;
                dtStartDate.Value = employee.StartDate;
                numChildren.Value = employee.NumOfChildren;
                chkMilitary.Checked = employee.isMilitartServiceDone;
                chkForeign.Checked = employee.isForeingLanguage;
                rdOHSYes.Checked = employee.ohsStatus;
                rdOHSNo.Checked = !employee.ohsStatus;
                rdMasteryYes.Checked = employee.masteryStatus;
                rdMasteryNo.Checked = !employee.masteryStatus;
            }
            else
            {
                lblRecordInfo.Text = "New Record";
                btnUpdate.Text = "Add";
                txtName.Text = "";
                txtSurname.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                cbDepartment.SelectedIndex = -1;
                dtStartDate.Value = DateTime.Now;
                numChildren.Value = 0;
                chkMilitary.Checked = false;
                chkForeign.Checked = false;
                rdOHSYes.Checked = false;
                rdOHSNo.Checked = false;
                rdMasteryYes.Checked = false;
                rdMasteryNo.Checked = false;
            }
        }


        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbEmployees.SelectedIndex;

            if (index >= 0)
            {
                Employee employee = (Employee)lbEmployees.Items[index];
                ShowEmployee(employee);
            }
            else
                ShowEmployee(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (heldEmployee != null)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    lbEmployees.Items.Remove(heldEmployee);
                    lblEmployeeNumber.Text = $"{lbEmployees.Items.Count} Employee";
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            File.WriteAllText("Employees.json", JsonSerializer.Serialize(lbEmployees.Items));
            MessageBox.Show("Data saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Employees.json"))
            {
                try
                {
                    string employees = File.ReadAllText("Employees.json");

                    var list = JsonSerializer.Deserialize<Employee[]>(employees);

                    if (list != null && list.Length > 0)
                    {
                        Employee lastEmployee = list[list.Length - 1];
                        idCount = lastEmployee.Id + 1;
                    }

                    lbEmployees.Items.AddRange(list!);
                    lblEmployeeNumber.Text = $"{lbEmployees.Items.Count} Employee";

                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while reading the file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                epEmployeeForm.SetError(txtName, "Name cannot be empty!");
                e.Cancel = true;
            }
            else
                epEmployeeForm.SetError(txtName, "");
        }

        private void txtSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSurname.Text))
            {
                epEmployeeForm.SetError(txtSurname, "Surname cannot be empty!");
                e.Cancel = true;
            }               
            else
                epEmployeeForm.SetError(txtSurname, "");
        }
    }
}
