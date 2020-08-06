using System.Linq;

namespace LEARNING_EF_CODE_FIRST
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateBtton_Click(object sender, System.EventArgs e)
        {

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                for (int index = 1; index <= 100; index++)
                {
                    Models.User user =
                        new Models.User
                        {
                            Username = $"pn { index }",

                            FullName = $"Payman Nosraty { index }",
                        };

                    databaseContext.Users.Add(user);
                }

                databaseContext.SaveChanges();

                generateBtton.Enabled = false;

                System.Windows.Forms.MessageBox.Show($"Generated succesfully");

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox
                    .Show($"Error + { System.Environment.NewLine } { ex.Message }");
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                System.Collections.Generic.List<Models.User> users = null;


                if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
                {
                    users =
                        databaseContext.Users
                        .OrderBy(current => current.FullName)
                        .ToList()
                        ;
                }
                else
                {
                    users =
                        databaseContext.Users
                        .Where(current => current.FullName.ToLower().Contains(fullNameTextBox.Text.ToLower()))
                        .OrderBy(current => current.FullName)
                        .ToList()
                        ;
                }

                fullNamesListBox.ValueMember = nameof(Models.User.Id);
                fullNamesListBox.DisplayMember = nameof(Models.User.FullName);
                fullNamesListBox.DataSource = users;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox
                    .Show($"Error + { System.Environment.NewLine } { ex.Message }");
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                bool hasAnyUser =
                    databaseContext
                    .Users
                    .Any();

                if (hasAnyUser)
                {
                    generateBtton.Enabled = false;
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox
                    .Show($"Error + { System.Environment.NewLine } { ex.Message }");
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        private void FullNamesListBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (fullNamesListBox.SelectedItem == null)
            {
                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                if (fullNamesListBox.SelectedItem is Models.User selectedUser)
                {
                    string result =
                        $"username: { selectedUser.Username } { System.Environment.NewLine } " +
                        $"fullname: { selectedUser.FullName }";

                    System.Windows.Forms.MessageBox
                        .Show(result, "user information", System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox
                    .Show($"Error + { System.Environment.NewLine } { ex.Message }");
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }
    }
}

