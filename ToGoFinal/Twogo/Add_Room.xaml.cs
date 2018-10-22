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
    /// Add_Room.xaml 的互動邏輯
    /// </summary>
    public partial class Add_Room : Window
    {
        public Add_Room()
        {
            InitializeComponent();
        }

        global::ToGo.ToGoEntities dbContext = new ToGo.ToGoEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource roomInformationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("roomInformationViewSource")));
            // 透過設定 CollectionViewSource.Source 屬性載入資料: 
            // roomInformationViewSource.Source = [泛用資料來源]
            roomInformationViewSource.Source = dbContext.RoomInformations.Local;

            var q = dbContext.RoomInformations.Where(x => x.Hotel.Owner.Email == MainWindow.OwnerLoginEmail).Select(x => x.HotelID);
            foreach(var item in q)
            {
                this.hotelIDComboBox.Items.Add(item);
            }

            for(int i=2;i<7;i++)
            {
                this.roomTypeComboBox.Items.Add(i);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int chooseHotelId = int.Parse(this.hotelIDComboBox.SelectedValue.ToString());
            int chooseRoomType = int.Parse(this.roomTypeComboBox.SelectedValue.ToString());

            string StrRoomPrice = unitPriceTextBox.Text;
            int roomPrice;
            if (int.TryParse(StrRoomPrice, out roomPrice) == false)
            {
                MessageBox.Show("請輸入整數");
                return;
            }

            bool addBed;
            if (canAddBedCheckBox.IsChecked == true)
            {
                addBed = true;
            }
            else
            {
                addBed = false;
            }

            bool offerBF;
            if (offerBreakfastCheckBox.IsChecked == true)
            {
                offerBF = true;
            }
            else
            {
                offerBF = false;
            }

            bool permitSmoke;
            if(permitSmokingCheckBox.IsChecked==true)
            {
                permitSmoke = true;
            }
            else
            {
                permitSmoke = false;
            }

            this.dbContext.RoomInformations.Local.Add(new RoomInformation
            {
                //**TODO:輸入StarRated字串不正確, 跳出提示

                HotelID = chooseHotelId,
                RoomNameCN = roomNameCNTextBox.Text,
                RoomNameEN = roomNameENTextBox.Text,
                RegisterDate = DateTime.Now,
                RoomType = chooseRoomType,
                UnitPrice = roomPrice,
                CanAddBed = addBed,
                OfferBreakfast= offerBF,
                PermitSmoking= permitSmoke
            });

            this.registerDateLabel.Content = DateTime.Now;

            this.dbContext.SaveChanges();

            MessageBox.Show("成功加入一筆Room資料");
        }

        private void hotelIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
