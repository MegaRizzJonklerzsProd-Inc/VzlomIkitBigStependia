using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp15
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private string _productName;
        private decimal _productPrice;

        public string ProductName
        {
            get => _productName;
            set
            {
                if (_productName != value)
                {
                    _productName = value;
                    OnPropertyChanged(nameof(ProductName));
                }
            }
        }

        public decimal ProductPrice
        {
            get => _productPrice;
            set
            {
                if (_productPrice != value)
                {
                    _productPrice = value;
                    OnPropertyChanged(nameof(ProductPrice));
                }
            }
        }

        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public ICommand AddProductCommand { get; }

        public ViewModel()
        {
            AddProductCommand = new RelayCommand(AddProduct);
        }

        private void AddProduct()
        {
            if (!string.IsNullOrWhiteSpace(ProductName) && ProductPrice > 0)
            {
                Products.Add(new Product { Name = ProductName, Price = ProductPrice });
                ProductName = string.Empty; // Очистить поле после добавления
                ProductPrice = 0; // Сбросить цену
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
