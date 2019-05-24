using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsCSV.Models
{
    //public class Image
    //{
    //    public string Id { get; set; }
    //    public string Title { get; set; }
    //    public string Url { get; set; }
    //    public string AlternativeText { get; set; }
    //}

    //public class Image2
    //{
    //    public string Id { get; set; }
    //    public string Title { get; set; }
    //    public string Url { get; set; }
    //    public string AlternativeText { get; set; }
    //}

    //public class Category
    //{
    //    public string Title { get; set; }
    //    public string Id { get; set; }
    //    public string Summary { get; set; }
    //    public string SearchTitle { get; set; }
    //    public string Description { get; set; }
    //    public string Keyword { get; set; }
    //    public string UrlName { get; set; }
    //    public string PublishedDate { get; set; }
    //    public List<Image2> Image { get; set; }
    //    public int Order { get; set; }
    //    public object features { get; set; }
    //    public string ExternalLink { get; set; }
    //    public object video { get; set; }
    //    public object youtubelink { get; set; }
    //    public object youtubeid { get; set; }
    //    public int VideoType { get; set; }
    //    public object VideoImage { get; set; }
    //    public object FeatureImage { get; set; }
    //}

    //public class Image3
    //{
    //    public string Id { get; set; }
    //    public string Title { get; set; }
    //    public string Url { get; set; }
    //    public string AlternativeText { get; set; }
    //}

    //public class Image4
    //{
    //    public string Id { get; set; }
    //    public string Title { get; set; }
    //    public string Url { get; set; }
    //    public string AlternativeText { get; set; }
    //}

    //public class Category2
    //{
    //    public string Title { get; set; }
    //    public string Id { get; set; }
    //    public string Summary { get; set; }
    //    public string SearchTitle { get; set; }
    //    public string Description { get; set; }
    //    public string Keyword { get; set; }
    //    public string UrlName { get; set; }
    //    public string PublishedDate { get; set; }
    //    public List<Image4> Image { get; set; }
    //    public int Order { get; set; }
    //    public object features { get; set; }
    //    public string ExternalLink { get; set; }
    //    public object video { get; set; }
    //    public object youtubelink { get; set; }
    //    public object youtubeid { get; set; }
    //    public int VideoType { get; set; }
    //    public object VideoImage { get; set; }
    //    public object FeatureImage { get; set; }
    //}

    //public class Subcategory
    //{
    //    public string Title { get; set; }
    //    public string Id { get; set; }
    //    public string Summary { get; set; }
    //    public string SearchTitle { get; set; }
    //    public string Description { get; set; }
    //    public string Keyword { get; set; }
    //    public string UrlName { get; set; }
    //    public string Ecorebates { get; set; }
    //    public List<Image3> Image { get; set; }
    //    public Category2 Category { get; set; }
    //    public object Bazaarvoicescript { get; set; }
    //    public int Order { get; set; }
    //}

    //public class ConsumerBrochurePDF
    //{
    //    public string Id { get; set; }
    //    public string Title { get; set; }
    //    public string Url { get; set; }
    //    public string Description { get; set; }
    //}

    //public class SpecificationsPDF
    //{
    //    public string Id { get; set; }
    //    public string Title { get; set; }
    //    public string Url { get; set; }
    //    public string Description { get; set; }
    //}

    //public class WarrantyPDF
    //{
    //    public string Id { get; set; }
    //    public string Title { get; set; }
    //    public string Url { get; set; }
    //    public string Description { get; set; }
    //}

    public class Products
    {
        //public string Title { get; set; }
        public string ProductCode { get; set; }
        public string parent { get; set; }
        //public string Id { get; set; }
        //public string Summary { get; set; }
        //public string Description { get; set; }
        //public string SearchTitle { get; set; }
        //public object Rating { get; set; }
        //public string UrlName { get; set; }
        //public string PublishedDate { get; set; }
        //public List<Image> Image { get; set; }
        //public string Features { get; set; }
        //public string LimitedWarranty { get; set; }
        //public string ConsumerBrochure { get; set; }
        //public string ProductSpecifications { get; set; }
        //public string Keywords { get; set; }
        //public string ProductWarranty { get; set; }
        //public bool IntegrateBazaarVoice { get; set; }
        //public string WarrantyBadgesText { get; set; }
        //public List<object> WarrantyImages { get; set; }
        //public int Order { get; set; }
        //public bool IsFeaturedProduct { get; set; }
        
        //public bool ComfortBridgeProduct { get; set; }
        //public object NextProduct { get; set; }
        //public object PreviousProduct { get; set; }
        //public Category Category { get; set; }
        //public object SelectPage { get; set; }
        //public object SelectPageFullUrl { get; set; }
        //public Subcategory Subcategory { get; set; }
        //public string EnergyConsumptionText { get; set; }
        //public string EnergyStarText { get; set; }
        //public bool literaturelibrary { get; set; }
        //public List<object> ComfortNetBadge { get; set; }
        //public List<object> EnergyStarBadge { get; set; }
        //public string InstallationandTechManuals { get; set; }
        //public string PartsList { get; set; }
        //public string Producttitle { get; set; }
        //public List<string> IO_manual_attachments { get; set; }
        //public string BazaarvoiceDisclosure { get; set; }
        //public DateTime LastModified { get; set; }
        //public string bvProductCode { get; set; }
        //public string ConsumerBrochureId { get; set; }
        //public string ProductSpecificationsId { get; set; }
        //public string ProductWarrantyId { get; set; }
        //public object Warranty { get; set; }
        //public List<object> IO_manuals { get; set; }
        //public ConsumerBrochurePDF ConsumerBrochurePDF { get; set; }
        //public SpecificationsPDF SpecificationsPDF { get; set; }
        //public WarrantyPDF WarrantyPDF { get; set; }
        //public string skuNumbers { get; set; }
    }
}