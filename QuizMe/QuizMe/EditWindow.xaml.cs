using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Data;

namespace QuizMe
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Return to previous window when this window closes
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ListWindow listWindow = new ListWindow();
            listWindow.Show();
        }

        /// <summary>
        /// Create and fill the datatable when window loads
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = new DataTable("Quiz");
            DataColumn dataColumn = new DataColumn("Question");
            dataTable.Columns.Add("Question", typeof(string));
            dataTable.Columns.Add("Answer", typeof(string));
            dataTable.Columns.Add("Option 1", typeof(string));
            dataTable.Columns.Add("Option 2", typeof(string));
            dataTable.Columns.Add("Option 3", typeof(string));
            dataTable.NewRow();
            gridQuizForm.DataContext = dataTable;
        }
    }
}
