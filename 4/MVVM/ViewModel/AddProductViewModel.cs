using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using _4.Abstractions;
using _4.MVVM.Model;
using _4.Utilities;

using Microsoft.Win32;

using static _4.Abstractions.ProductAbstraction;

namespace _4.MVVM.ViewModel
{
	public class AddProductViewModel : BaseViewModel
	{
		private readonly PageModel _pageModel;
		//private DataManager _dataManager;

		public ICommand SaveCommand { get; set; }
		public ICommand OpenImageFileCommand { get; set; }
		public Dictionary<PizzaCategories, string> PizzaCategoryDictionary { get; set; }
		public Dictionary<PizzaSizes, string> PizzaSizesDictionary { get; set; }
		
		public AddProductViewModel(Dictionary<PizzaCategories, string> pizzaCategoryDictionary, Dictionary<PizzaSizes, string> pizzaSizesDictionary)
		{
			_pageModel = new PageModel();
			//_dataManager = DataManager.Instance;

			_product = new ProductModel();
			Category = PizzaCategories.Pizza;

			PizzaCategoryDictionary = pizzaCategoryDictionary;
			PizzaSizesDictionary = pizzaSizesDictionary;

			SliderValue = 4;
			Size = PizzaSizes.Medium;

			SaveCommand = new RelayCommand(Save);
			OpenImageFileCommand = new RelayCommand(OpenImageFile);
		}

		private void Save(object obj)
		{
			Console.WriteLine("before create rating: " + Rating);
			var addedProduct = ProductModel.Create(Guid.NewGuid(), ShortName, FullName, Description, Price, Image, Category, Size, Rating, Count);

			if (addedProduct.IsFailure)
			{
				MessageBox.Show(addedProduct.Error);
				return;
			}

			DataManager.Instance.AddProduct(addedProduct.Value);
			//_dataManager.AddProduct(addedProduct.Value);
			//json.WriteNewProduct(addedProduct.Value);

			ResetAll();
		}

		private void ResetAll()
		{
			ShortName = "";
			FullName = "";
			Description = "";
			Image = "";
			SelectedImage = BitmapImage.Create(
				2,
				2,
				96,
				96,
				PixelFormats.Indexed1,
				new BitmapPalette(new List<Color> { Colors.Transparent }),
				new byte[] { 0, 0, 0, 0 },
				1);
			Category = PizzaCategories.Pizza;
			Size = PizzaSizes.Big;
			SliderValue = 4;
			PriceString = "";
			CountString = "";
		}

		private void OpenImageFile(object obj)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			//string currentDirectory = Directory.GetCurrentDirectory();
			//string initialDirectory = Path.Combine(currentDirectory, "..", "..", "..", "Assets", "pizza");

			//openFileDialog.InitialDirectory = Path.GetFullPath(initialDirectory);

			string initialDirectory = @"C:\my\study\wpf\labs\4\Assets\pizza";

			openFileDialog.InitialDirectory = initialDirectory;
			openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

			if (openFileDialog.ShowDialog() == true)
			{
				string selectedImagePath = openFileDialog.FileName;

				string selectedImageName = Path.GetFileName(selectedImagePath);

				BitmapImage bitmapImage = new BitmapImage(new Uri(selectedImagePath));

				SelectedImage = bitmapImage;
				Image = selectedImageName;
			}
			else
			{
				SelectedImage = null;
			}
		}

		private ProductModel _product { get; set; }
		public ProductModel Product
		{
			get { return _product; }
			set { _product = value; OnPropertyChanged(nameof(Product)); }
		}
		public string ShortName
		{
			get { return _product.ShortName; }
			set { _product.ShortName = value; OnPropertyChanged(nameof(ShortName)); }
		}
		public string FullName
		{
			get { return _product.FullName; }
			set { _product.FullName = value; OnPropertyChanged(nameof(FullName)); }
		}
		public string Description
		{
			get { return _product.Description; }
			set { _product.Description = value; OnPropertyChanged(nameof(Description)); }
		}
		public string Image
		{
			get { return _product.Image; }
			set { _product.Image = value; OnPropertyChanged(nameof(Image)); }
		}
		private ImageSource _selectedImage;
		public ImageSource SelectedImage
		{
			get { return _selectedImage; }
			set
			{
				_selectedImage = value;
				OnPropertyChanged(nameof(SelectedImage));
			}
		}
		public PizzaCategories Category
		{
			get { return _product.Category; }
			set
			{
				_product.Category = value;
				OnPropertyChanged(nameof(Category));

				if (Category == PizzaCategories.Pizza)
				{
					SizesVisibility = true;
					Console.WriteLine(_sizesVisibility);
				}
				else
				{
					SizesVisibility = false;
					Console.WriteLine(_sizesVisibility);
				}
			}
		}
		private bool _sizesVisibility { get; set; }
		public bool SizesVisibility
		{
			get { return _sizesVisibility; }
			set { _sizesVisibility = value; OnPropertyChanged(nameof(SizesVisibility)); }
		}
		public PizzaSizes Size
		{
			get { return _product.Size; }
			set
			{
				_product.Size = value;
				OnPropertyChanged(nameof(Size)); 
				Console.WriteLine("size value: " + value);
			}
		}
		private double _sliderValue { get; set; }
		public double SliderValue
		{
			get { return _sliderValue; }
			set
			{
				_sliderValue = value;
				OnPropertyChanged(nameof(SliderValue));
				Console.WriteLine("SliderValue: " + value);
				Rating convertRating = ConvertSliderValueToRating(value);
				Console.WriteLine("convertRating: " + convertRating);
				Rating = convertRating;
			}
		}
		public Rating Rating
		{
			get { return _product.Rating; }
			set { _product.Rating = value; Console.WriteLine("rating value: " + value); OnPropertyChanged(nameof(Rating)); }
		}
		private string _priceString;
		public string PriceString
		{
			get { return _priceString; }
			set
			{
				_priceString = value;
				OnPropertyChanged(nameof(PriceString));
				double convertPrice;
				if (double.TryParse(value, out convertPrice))
				{
					Price = convertPrice;
				}
			}
		}
		public double Price
		{
			get { return _product.Price; }
			set { _product.Price = value; OnPropertyChanged(nameof(Price)); }
		}
		private string _countString;
		public string CountString
		{
			get { return _countString; }
			set
			{
				_countString = value;
				OnPropertyChanged(nameof(CountString));
				int convertCount;
				if (int.TryParse(value, out convertCount))
				{
					Count = convertCount;
				}
			}
		}
		public int Count
		{
			get { return _product.Count; }
			set { _product.Count = value; OnPropertyChanged(nameof(Count)); }
		}

		private Rating ConvertSliderValueToRating(double sliderValue)
		{
			switch (sliderValue)
			{
				case 1:
					return Rating.One;
				case 2:
					return Rating.Two;
				case 3:
					return Rating.Three;
				case 4:
					return Rating.Four;
				case 5:
					return Rating.Five;
				default:
					return Rating.None;
			}
		}
	}
}