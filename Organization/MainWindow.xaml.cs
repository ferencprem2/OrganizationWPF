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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;

namespace Organization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        static List<OrganizationData> OrganizationDataList = new();
        public MainWindow()
        {
            InitializeComponent();
            string hundredRecord = "organizations-100000.csv";
            LoadFile(hundredRecord);

            dgDatas.ItemsSource = OrganizationDataList;

            cbCountry.ItemsSource = OrganizationDataList.Select(x => x.Country).OrderBy(x => x).Distinct().ToList();
            cbYear.ItemsSource = OrganizationDataList.Select(x => x.Founded).OrderBy(x => x).Distinct().ToList();
            labTotalEmpl.Content = OrganizationDataList.Sum(x => x.EmployeesNumber);
            //string inputPath = "organizations-100.csv";
            //string outputPath = "organizatinFormed.csv";

            //StreamReader sr = new(inputPath);
            //StreamWriter sw = new(outputPath);

            //string line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    string processedLine = ProcessFile(line);

            //    sw.WriteLine(processedLine);
            //}

            this.DataContext = this;
        }
        private void LoadData(string fileName)
        {
            foreach (var item in File.ReadAllLines(fileName).Skip(1))
            {
                OrganizationDataList.Add(new OrganizationData(item.Split(';')));
            }
        }

        static void LoadFile(string fileToLoad)
        {
            StreamReader sr = new(fileToLoad);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(';');
                OrganizationData newData = new OrganizationData(line);
                OrganizationDataList.Add(newData);
            }
            sr.Close();
        }



        static string ProcessFile(string lineToProcess)
        {
            StringBuilder sb = new();
            bool insideOfQuote = false;

            foreach (char c in lineToProcess)
            {
                if (c == '"')
                {
                    insideOfQuote = !insideOfQuote;
                }
                else if (c == ',' && !insideOfQuote)
                {
                    sb.Append(';');
                    continue;
                }

                sb.Append(c);
            }
            return sb.ToString();
        }

        private void dgDatas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgDatas.SelectedItem is OrganizationData)
            {
                OrganizationData selectedObject = dgDatas.SelectedItem as OrganizationData;
                labID.Content = selectedObject.Id.ToString();
                labWEB.Content = selectedObject.Website;
                labISM.Content = selectedObject.Description;
            }
            else
            {
                MessageBox.Show("Hiba!");
            }
        }

        private void cbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCountry = cbCountry.SelectedItem as string;
            int selectedYear = int.Parse(cbYear.SelectedItem.ToString());
            
            if (cbCountry.SelectedIndex != -1)
            {
                dgDatas.ItemsSource = OrganizationDataList.Where(x => x.Founded == selectedYear);
            } else if (cbCountry){
                dgDatas.ItemsSource = OrganizationDataList.Where(x => x.Founded == selectedYear);
            }


            dgDatas.ItemsSource = OrganizationDataList.Where(x => x.Country == selectedCountry && x.Founded == selectedYear);
        }
        

        private void DeleteSelection(object sender, RoutedEventArgs e)
        {
            dgDatas.ItemsSource = OrganizationDataList;
        }
    }
}
