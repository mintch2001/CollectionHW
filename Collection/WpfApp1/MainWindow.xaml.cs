using System;
using System.Collections;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
       
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //เรียงข้อมูลใน Array
            //arrayList.Sort();

            //เอาข้อมูลมาใช้
            string Data = " ";
            foreach (string dataInArray in arrayList)
            {
                Data = Data + dataInArray;                             
            }          
            MessageBox.Show("Count : " + arrayList.Count.ToString() + "\nData : " + Data);                    
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //เพิ่มข้อมูลลงไป
            
            arrayList.Add(txtData.Text);
            MessageBox.Show("Complete !");
            txtData.Text = " ";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ลบข้อมูล
            
            arrayList.Remove(txtData.Text);
            MessageBox.Show("Delete Complete");
            txtData.Text = " ";
            //arrayList.RemoveAt(index);
        }
    }
}
