using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsCore.Models.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsCore.Views
{
    public partial class MainForm : Form
    {
        private readonly ShopContext _context;
        private int currentPage;

        public MainForm(ShopContext context)
        {
            InitializeComponent();
            _context = context;
            var filterCustomers = _context.Customers.Where(t => t.FirstName == "Maria").ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var properties = typeof(Customer).GetProperties();
            List<String> listProperties = new List<string>();
            foreach (var property in properties)
            {
                listProperties.Add(property.Name);
            }
            columnSortByComboBox.DataSource = listProperties;


            rowPerPagecomboBox.Text = "10";
            sortComboBox.Text = "Tang";


            int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
            int rowCount = _context.Customers.Count();
            currentPage = 0;
            int offset = currentPage * rowPerPage;
            int maxPage = (rowCount / rowPerPage) + 1;

            currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

            dataGridView1.DataSource = _context.Customers.Skip(offset).Take(rowPerPage).ToList();
        }

        private void rowPerPagecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
            currentPage = 0;
            int rowCount = _context.Customers.Count();
            int offset = currentPage * rowPerPage;
            int maxPage = (rowCount / rowPerPage) + 1;

            currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

            if (currentPage + 1 >= maxPage)
            {
                nextPageBtn.Enabled = false;
            }
            else
            {
                nextPageBtn.Enabled = true;
            }

            button4.Enabled = false;


            dataGridView1.DataSource = _context.Customers.Skip(offset).Take(rowPerPage).ToList();
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
            currentPage += 1;
            int rowCount = _context.Customers.Count();
            int offset = currentPage * rowPerPage;
            int maxPage = (rowCount / rowPerPage) + 1;

            currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

            if (currentPage + 1 >= maxPage)
            {
                nextPageBtn.Enabled = false;
            }

            button4.Enabled = true;

            dataGridView1.DataSource = _context.Customers.Skip(offset).Take(rowPerPage).ToList();
        }

        // prev page btn
        private void button4_Click(object sender, EventArgs e)
        {
            currentPage -= 1;
            int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
            int rowCount = _context.Customers.Count();
            int offset = currentPage * rowPerPage;
            int maxPage = (rowCount / rowPerPage) + 1;

            currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

            if (currentPage == 0)
            {
                button4.Enabled = false;
            }

            nextPageBtn.Enabled = true;

            dataGridView1.DataSource = _context.Customers.Skip(offset).Take(rowPerPage).ToList();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNametextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string phoneNumber = phoneNumberTextBox.Text.Trim();
            string city = cityComboBox.Text.Trim();
            string country = countryTextBox.Text.Trim();

            // validation
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.");
                return;
            }

            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$")) // 10-digit phone number
            {
                MessageBox.Show("Phone number must be 10 digits.");
                return;
            }

            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("City is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Country is required.");
                return;
            }

            // save to db
            var newCustomer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phoneNumber,
                City = city,
                Country = country
            };

            try
            {
                await _context.Customers.AddAsync(newCustomer);
                await _context.SaveChangesAsync();

                firstNametextBox.Text = "";
                lastNameTextBox.Text = "";
                phoneNumberTextBox.Text = "";
                cityComboBox.SelectedIndex = -1;
                countryTextBox.Text = "";

                MessageBox.Show("Added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string firstName = dataGridView1.CurrentRow.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
            string lastName = dataGridView1.CurrentRow.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();

            // Confirm deletion
            var confirmResult = MessageBox.Show($"Bạn có muốn xoá khách hàng {firstName + " " + lastName}",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                var customer = _context.Customers.Find(customerId);

                _context.Orders.RemoveRange(customer.Orders);
                _context.SaveChanges();
                _context.Customers.Remove(customer);
                _context.SaveChanges();

                int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
                int rowCount = _context.Customers.Count();
                currentPage = 0;
                int offset = currentPage * rowPerPage;
                int maxPage = (rowCount / rowPerPage) + 1;

                currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

                dataGridView1.DataSource = _context.Customers.Skip(offset).Take(rowPerPage).ToList();

                MessageBox.Show($"Đã xoá khách hàng {firstName + " " + lastName}");


            }
        }

        private void chinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = true;

            firstNametextBox.Text = dataGridView1.CurrentRow.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
            lastNameTextBox.Text = dataGridView1.CurrentRow.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();
            phoneNumberTextBox.Text = dataGridView1.CurrentRow.Cells["phoneDataGridViewTextBoxColumn"].Value.ToString();

            string cityData = dataGridView1.CurrentRow.Cells["cityDataGridViewTextBoxColumn"].Value.ToString();
            cityComboBox.SelectedIndex = cityComboBox.FindString(cityData);

            countryTextBox.Text = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString();


        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNametextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string phoneNumber = phoneNumberTextBox.Text.Trim();
            string city = cityComboBox.Text.Trim();
            string country = countryTextBox.Text.Trim();

            // validation
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.");
                return;
            }

            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$")) // 10-digit phone number
            {
                MessageBox.Show("Phone number must be 10 digits.");
                return;
            }

            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("City is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Country is required.");
                return;
            }

            try
            {
                int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                var customer = _context.Customers.Find(customerId);

                // update
                customer.City = city;
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.Phone = phoneNumber;
                customer.Country = country;
                _context.SaveChanges();


                firstNametextBox.Text = "";
                lastNameTextBox.Text = "";
                phoneNumberTextBox.Text = "";
                cityComboBox.SelectedIndex = -1;
                countryTextBox.Text = "";


                int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
                int rowCount = _context.Customers.Count();
                currentPage = 0;
                int offset = currentPage * rowPerPage;
                int maxPage = (rowCount / rowPerPage) + 1;

                currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

                dataGridView1.DataSource = _context.Customers.Skip(offset).Take(rowPerPage).ToList();

                MessageBox.Show("Updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void columnSortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ascending = sortComboBox.Text == "Tang" ? true : false;
            string sortColumn = columnSortByComboBox.Text;

            IQueryable<Customer> query = _context.Customers;

            if (ascending)
            {
                query = query.OrderBy(e => EF.Property<object>(e, sortColumn));
            }
            else
            {
                query = query.OrderByDescending(e => EF.Property<object>(e, sortColumn));
            }

            int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
            int rowCount = _context.Customers.Count();
            currentPage = 0;
            int offset = currentPage * rowPerPage;
            int maxPage = (rowCount / rowPerPage) + 1;

            currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

            dataGridView1.DataSource = query.Skip(offset).Take(rowPerPage).ToList();

        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ascending = sortComboBox.Text == "Tang" ? true : false;
            string sortColumn = columnSortByComboBox.Text;

            IQueryable<Customer> query = _context.Customers;

            if (ascending)
            {
                query = query.OrderBy(e => EF.Property<object>(e, sortColumn));
            }
            else
            {
                query = query.OrderByDescending(e => EF.Property<object>(e, sortColumn));
            }

            int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
            int rowCount = _context.Customers.Count();
            currentPage = 0;
            int offset = currentPage * rowPerPage;
            int maxPage = (rowCount / rowPerPage) + 1;

            currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

            dataGridView1.DataSource = query.Skip(offset).Take(rowPerPage).ToList();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text?.Trim().ToLower();
            string searchColumn = columnSortByComboBox.Text;

            IQueryable<Customer> query = _context.Customers;
            query = query.Where(e => EF.Property<string>(e, searchColumn).ToLower().Contains(searchText));

            int rowPerPage = int.Parse(rowPerPagecomboBox.Text);
            int rowCount = _context.Customers.Count();
            currentPage = 0;
            int offset = currentPage * rowPerPage;
            int maxPage = (rowCount / rowPerPage) + 1;

            currentPageLabel.Text = $"Trang {currentPage + 1}/{maxPage}";

            dataGridView1.DataSource = query.Skip(offset).Take(rowPerPage).ToList();
        }
    }
}
