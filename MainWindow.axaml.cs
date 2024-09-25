using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using Microsoft.EntityFrameworkCore.Metadata;
using Order.Models;
using System.Collections.Generic;
using System.Linq;

namespace Order
{
    public partial class MainWindow : Window
    {
       // public Product pp;
        public MainWindow()
        {
            InitializeComponent();
         //   Right.Click += Right_Click;
            loadProds();
           
        }
        /*
        public void Right_Click (object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            //   int ind = (int)((sender as MenuItem)!).Tag!;

             
                var item = listbox.SelectedItem as Product;
               
                Helper.Zakaz.Add(item);
                

               
                

        }*/

        private void loadProds()
        {






            listbox.ItemsSource = Helper.user724Context.Products.Select(
                x => new
                {
                    x.IdProduct,
                    x.NameProduct,
                    x.IdManufacturerNavigation.NameManufacturer,
                    x.Cost,
                    x.Descriprion,
                    x.bitmap,
                    Photo = new Bitmap($"Assets" + "\\" + x.Image.ToString()),
                    Discount = Helper.user724Context.Products.Where(z => z.IdProduct == x.IdProduct).FirstOrDefault().IdDiscountNavigation.ValueDiscount,
                });


        }

        private void ListBox_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            var point = e.GetCurrentPoint(sender as ListBoxItem);
            if (point.Properties.IsRightButtonPressed)
            {
              //  Helper.CurrentProduct = listbox.SelectedItem as Product;
                // Helper.CurrentProduct = Helper.user724Context.Products.Where(x => x.IdProduct == ind).FirstOrDefault();
             //   Window3 window3 = new Window3();
             //   window3.Show();
                this.Close();


            }
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            int ind = (int)((sender as Button)!).Tag!;
          //  Helper.CurrentProduct = Helper.user724Context.Products.Where(x => x.IdProduct == ind).FirstOrDefault();
          //  Window3 window3 = new Window3();
          //  window3.Show();
            this.Close();
        }

       

        private void VKorzinu_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Window1 window2 = new Window1();
            window2.Show();
            this.Close();

        }

        private void ListBox_PointerReleased(object? sender, Avalonia.Input.PointerReleasedEventArgs e)
        {
            var point = e.GetCurrentPoint(sender as ListBoxItem);
            if (point.Properties.IsRightButtonPressed)
            {
          //      Helper.CurrentProduct = listbox.SelectedItem as Product;
                // Helper.CurrentProduct = Helper.user724Context.Products.Where(x => x.IdProduct == ind).FirstOrDefault();
                //   Window3 window3 = new Window3();
                //   window3.Show();
                this.Close();


            }
        }

        private void MenuItem_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            var product = listbox.SelectedItem;

            //Helper.Zakaz.Add(test);
        }
    }
}