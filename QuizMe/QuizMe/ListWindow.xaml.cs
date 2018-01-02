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
using System.IO;

namespace QuizMe
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        public ListWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display edit form when edit button is clicked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.Show();
            Application.Current.MainWindow.Close();
            this.Close();
        }
        /// <summary>
        /// Load all quiz files into the listbox once the window is loaded
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string FILEPATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\QuizMe";
            if (!Directory.Exists(FILEPATH)) Directory.CreateDirectory(FILEPATH);
            string[] files = Directory.GetFiles(FILEPATH, "*.quiz", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                string filename = Path.GetFileNameWithoutExtension(file);
                listQuiz.Items.Add(filename);
            }
        }
    }
}
