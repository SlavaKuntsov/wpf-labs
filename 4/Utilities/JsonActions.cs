using System;
using System.Collections.Generic;
using System.IO;

using _4.MVVM.Model;

using CSharpFunctionalExtensions;

using Newtonsoft.Json;

namespace _4.Utilities
{
	public class JsonActions
	{
		private const string dataPath = "../../Data/Products.json";
		public JsonActions()
		{
		}

		//public Result<ProductModel> FindProductById(Guid id)
		//{
		//	var products = GetAllProducts();

		//	if (products.IsFailure)
		//	{
		//		return Result.Failure<ProductModel>(products.Error);
		//	}

		//	ProductModel findProduct = products.Value.Find(item => item.Id == id);

		//	if (findProduct == null)
		//	{
		//		return Result.Failure<ProductModel>("Product with this id not exist");
		//	}

		//	return Result.Success(findProduct);
		//}

		public Result<List<ProductModel>> GetAllProducts()
		{
			JsonSerializerSettings options = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore
			};

			if (File.Exists(dataPath))
			{
				string jsonRead = File.ReadAllText(dataPath);
				List<ProductModel> products = JsonConvert.DeserializeObject<List<ProductModel>>(jsonRead, options);

				return Result.Success(products);
			}
			else
			{
				return Result.Failure<List<ProductModel>>("FILE NOT EXIST");
			}
		}

		public void WriteAllProducts(List<ProductModel> products)
		{
			JsonSerializerSettings options = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore
			};

			string newJson = JsonConvert.SerializeObject(products, options);

			File.WriteAllText(dataPath, newJson);
		}

		public void WriteNewProduct(ProductModel product)
		{
			JsonSerializerSettings options = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore
			};

			if (File.Exists(dataPath))
			{
				string jsonRead = File.ReadAllText(dataPath);
				List<ProductModel> products = JsonConvert.DeserializeObject<List<ProductModel>>(jsonRead, options);

				products.Add(product);

				string jsonWrite = JsonConvert.SerializeObject(products, Formatting.Indented);
				File.WriteAllText(dataPath, jsonWrite);
			}
			else
			{
				Console.WriteLine("FILE NOT EXIST");
			}
		}
	}
}
