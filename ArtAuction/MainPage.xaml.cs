using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArtAuction
{
    public partial class MainPage : ContentPage
    {

        public List<Seller> Sellers { get; set; }
        public List<string> Categories { get; set; }
        public List<Art> Arts { get; set; }



        public MainPage()
        {
            InitializeComponent();

            this.Sellers = new List<Seller>
            {
                new Seller
                {
                    Name = "Eleanor Pena",
                    SoldValueBTC = "0.000053 BTC",
                    Rising = true,
                    Image = "https://cataas.com/cat?rand=1"
                },
                new Seller
                {
                    Name = "Leslie Alexander",
                    SoldValueBTC = "0.000050 BTC",
                    Rising = false,
                    Image = "https://cataas.com/cat?rand=2"
                },
                new Seller
                {
                    Name = "Theresa Webb",
                    SoldValueBTC = "0.000048 BTC",
                    Rising = true,
                    Image = "https://cataas.com/cat?rand=3"
                }
            };

            this.Categories = new List<string>
            {
                "Art",
                "Music",
                "Gaming",
                "Sports",
                "Movies",
                "Coding",
                "Cars",
                "Garnening"
            };

            this.Arts = new List<Art>
            {
                new Art
                {
                    Name = "Happy Time",
                    Image = "https://picsum.photos/600/400?rand=1",
                    DaysLeft = "2 Days Left"

                },
                new Art
                {
                    Name = "Should We?",
                    Image = "https://picsum.photos/600/400?rand=2",
                    DaysLeft = "4 Days Left"

                },
                new Art
                {
                    Name = "The Hill",
                    Image = "https://picsum.photos/600/400?rand=3",
                    DaysLeft = "1 Day Left"

                },
                new Art
                {
                    Name = "Its Time to Go",
                    Image = "https://picsum.photos/600/400?rand=4",
                    DaysLeft = "13 Days Left"

                },
            };



            BindableLayout.SetItemsSource(this.CategoriesCollection, this.Categories);
            this.SellersCollection.ItemsSource = this.Sellers;
            BindableLayout.SetItemsSource(this.FeaturedAuctions, this.Arts);
        }
    }

    public class Seller
    {
        public string Name { get; set; }

        public string SoldValueBTC { get; set; }

        public bool Rising { get; set; }

        public string Image { get; set; }
    }

    public class Art
    {
        public string Name { get; set; }

        public string DaysLeft { get; set; }

        public string Image { get; set; }
    }
}
