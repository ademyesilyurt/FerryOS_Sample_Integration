using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.ExtraService.ExtraServiceGet
{
    public class Content
    {
        public int companyID { get; set; }
        public int extraServiceID { get; set; }
        public int id { get; set; }
        public string content { get; set; }
        public string contentCode { get; set; }
        public string title { get; set; }
    }

    public class Picture
    {
        public int companyID { get; set; }
        public bool @default { get; set; }
        public int categoryID { get; set; }
        public string pictureCategoryName { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public string tableName { get; set; }
        public int rowID { get; set; }
        public string fileName { get; set; }
        public string name { get; set; }
    }

    public class PictureCategory
    {
        public int companyID { get; set; }
        public int id { get; set; }
        public int productTypeID { get; set; }
        public string name { get; set; }
        public int sort { get; set; }
    }

    public class Price
    {
        public decimal endAge { get; set; }
        public decimal amount { get; set; }
        public decimal startAge { get; set; }
        public int extraServiceID { get; set; }
        public int id { get; set; }
        public int customerTypeID { get; set; }
        public string customerTypeName { get; set; }
        public string currencyTypeSymbol { get; set; }
        public string currencyTypeName { get; set; }
        public string currencyTypeCode { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public DateTime serviceEndDate { get; set; }
        public DateTime serviceStartDate { get; set; }
        public DateTime serviceDate { get; set; }
        public decimal kdvRate { get; set; }
        public string categoryName { get; set; }
        public int categoryID { get; set; }
        public string regions { get; set; }
        public string name { get; set; }
        public List<Tag> tags { get; set; }
        public string tag { get; set; }
        public string webDescription { get; set; }
        public int serviceDuration { get; set; }
        public int extraServiceCategoriesID { get; set; }
        public decimal amount { get; set; }
        public bool notInvoice { get; set; }
        public string currencyTypeSymbol { get; set; }
        public string currencyTypeName { get; set; }
        public string currencyTypeCode { get; set; }
        public bool requiredServiceEndDate { get; set; }
        public int extraServicePropertiesCategoriesID { get; set; }
        public string picture { get; set; }
        public string url { get; set; }
        public string webTagKeywords { get; set; }
        public string webTagDescription { get; set; }
        public int districtID { get; set; }
        public int cityID { get; set; }
        public int countryID { get; set; }
        public DateTime updateDate { get; set; }
        public List<Content> content { get; set; }
        public List<Picture> pictures { get; set; }
        public List<PictureCategory> pictureCategories { get; set; }
        public List<Price> prices { get; set; }
        public Video video { get; set; }
    }

    public class Root
    {
        public List<Valid> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }

    public class Tag
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }

    public class Video
    {
        public int companyID { get; set; }
        public int id { get; set; }
        public string fileName { get; set; }
        public string status { get; set; }
        public string tableName { get; set; }
        public int rowID { get; set; }
    }

}
