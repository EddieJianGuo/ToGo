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

namespace ToGo
{
    /// <summary>
    /// Add_Hotel.xaml 的互動邏輯
    /// </summary>
    public partial class Add_Hotel : Window
    {
        public Add_Hotel()
        {
            InitializeComponent();

        }

        global::ToGo.ToGoEntities dbContext = new ToGo.ToGoEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource hotelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("hotelViewSource")));
            // 透過設定 CollectionViewSource.Source 屬性載入資料: 
            // hotelViewSource.Source = [泛用資料來源]
            hotelViewSource.Source = dbContext.Hotels.Local;

            var q = dbContext.Countries.Select (c =>c.CountryENName).ToList();
            for (int i = 0; i < q.Count; i++)
            {
                this.countryENComboBox.Items.Add(q[i]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //新增一筆hotel
        {
            //Owner輸入資料後, 確定加入資料庫

            if (hnENTextBox.Text is null)
            {
                MessageBox.Show("請輸入飯店英文名稱");
                return;
            }

            if (adrENTextBox.Text is null)
            {
                MessageBox.Show("請輸入飯店英文地址");
                return;
            }

            string StarRate = starTextBox.Text;
            int rate;
            if(int.TryParse(StarRate,out rate)==false && rate<1 && rate>5)
            {
                MessageBox.Show("請輸入1~5的數字");
                return;
            }

            var q = this.dbContext.Hotels.Where(x => x.Owner.Email == MainWindow.OwnerLoginEmail).Select(x => x.OwnerID);
            foreach (var item in q)
            {
                ownerIDLabel.Content = item;
            }

            this.dbContext.Hotels.Local.Add(new ToGo.Hotel
            {
                //**TODO:輸入StarRated字串不正確, 跳出提示
                OwnerID = int.Parse(ownerIDLabel.Content.ToString()),
                HotelNameCN = hnCNTextBox.Text,
                HotelNameEN = hnENTextBox.Text,
                AddressCH = adrCHTextBox.Text,
                AddressEN = adrENTextBox.Text,
                RegisterDate = DateTime.Now,
                StarRated = int.Parse(starTextBox.Text),
                TaxIDNumber = taxIDTextBox.Text,
                Description = desTextBox.Text,
                CountryID =countryno,
                CityID = cityno

            });

            this.rgDateLabel.Content = DateTime.Now;
            this.dbContext.SaveChanges();

            MessageBox.Show("成功加入一筆hotel資料");
        }

        string countryName = "";
        string cityName = "";
        int countryno = 0;
        int cityno = 0;

        private void countryENComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.cityENComboBox.Items.Clear();
            countryName = this.countryENComboBox.SelectedValue.ToString();
            var q = dbContext.Countries.Where(c => c.CountryENName == countryName).Select(co => co.CountryID);
            foreach (var item in q)
            {
                countryno = item;
            }

            var q1 = dbContext.Cities.Where(ci => ci.CountryID == countryno).Select(ci => ci.CityENName);
            foreach (var item in q1)
            {
                this.cityENComboBox.Items.Add(item);
            }
        }

        private void cityENComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cityENComboBox.SelectedValue != null)
            {
                cityName = this.cityENComboBox.SelectedValue.ToString();
            }
            var q2 = dbContext.Cities.Where(ci => ci.CityENName == cityName).Select(ci => ci.CityID);
            foreach (var item in q2)
            {
                cityno = item;
            }
        }

    }
}
