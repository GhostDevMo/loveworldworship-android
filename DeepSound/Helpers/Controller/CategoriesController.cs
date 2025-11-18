using Android.App;
using DeepSound.Helpers.Model;
using DeepSound.Helpers.Utils;
using DeepSoundClient.Classes.Common;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DeepSound.Helpers.Controller
{
    public static class CategoriesController
    {
        public static ObservableCollection<Classes.Categories> ListCategoriesBlog = new ObservableCollection<Classes.Categories>();
        public static ObservableCollection<Classes.Categories> ListCategoriesProducts = new ObservableCollection<Classes.Categories>();

        public static string Get_Translate_Categories_Communities(string idCategory, string textCategory, string type)
        {
            try
            {
                string categoryName = textCategory;

                switch (type)
                {
                    case "Blog":
                        {
                            categoryName = ListCategoriesBlog?.Count switch
                            {
                                > 0 => ListCategoriesBlog.FirstOrDefault(a => a.CategoriesId == idCategory)?.CategoriesName ?? textCategory,
                                _ => categoryName
                            };

                            break;
                        }
                    case "Products":
                        {
                            categoryName = ListCategoriesProducts?.Count switch
                            {
                                > 0 => ListCategoriesProducts.FirstOrDefault(a => a.CategoriesId == idCategory)?.CategoriesName ?? textCategory,
                                _ => categoryName
                            };

                            break;
                        }
                    default:
                        categoryName = Application.Context.GetText(Resource.String.Lbl_Unknown);
                        break;
                }

                if (string.IsNullOrEmpty(categoryName))
                    return Application.Context.GetText(Resource.String.Lbl_Unknown);

                return categoryName;
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);

                if (string.IsNullOrEmpty(textCategory))
                    return Application.Context.GetText(Resource.String.Lbl_Unknown);

                return textCategory;
            }
        }

        public static void SetListCategories(OptionsObject result)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    //Blog Categories
                    var listBlog = result.DataOptions.BlogCategories?.Select(cat => new Classes.Categories
                    {
                        CategoriesId = cat.Key,
                        CategoriesName = Methods.FunString.DecodeString(cat.Value),
                        CategoriesColor = "#ffffff",
                    }).ToList();

                    ListCategoriesBlog.Clear();
                    if (listBlog?.Count > 0)
                        ListCategoriesBlog = new ObservableCollection<Classes.Categories>(listBlog);

                    //Products Categories
                    var listProducts = result.DataOptions.ProductsCategories?.Select(cat => new Classes.Categories
                    {
                        CategoriesId = cat.Key,
                        CategoriesName = Methods.FunString.DecodeString(cat.Value),
                        CategoriesColor = "#ffffff",
                    }).ToList();

                    ListCategoriesProducts.Clear();
                    if (listProducts?.Count > 0)
                        ListCategoriesProducts = new ObservableCollection<Classes.Categories>(listProducts);
                }
                catch (Exception e)
                {
                    Methods.DisplayReportResultTrack(e);
                }
            });
        }

        public static void ResetListCategories()
        {
            try
            {
                ListCategoriesBlog.Clear();
                ListCategoriesProducts.Clear();
            }
            catch (Exception e)
            {
                Methods.DisplayReportResultTrack(e);
            }
        }

    }
}