﻿using LogicPOS.Reporting.Data.Common;
using System;

/* Report Fields
SELECT 
	stkDate, stkDocumentNumber, artCode, artDesignation, stkQuantity, aumAcronym
FROM 
	view_articlestock 
ORDER BY 
	stkDate
;
*/

namespace LogicPOS.Reporting.Reports.Data
{
    [ReportData(Entity = "view_articlestockmovement")]
    public class StockMovementViewReportData : ReportData
    {
        // ArticleFamily
        [ReportData(Field = "afaOid")]
        //Primary Oid (Required)
        override public string Oid { get; set; }                            //afaOid AS Oid,  

        [ReportData(Field = "afaOrd")]
        public uint ArticleFamilyOrd { get; set; }                          //afaOrd AS ArticleFamilyOrd,

        [ReportData(Field = "afaCode")]
        public uint ArticleFamilyCode { get; set; }                         //afaCode AS ArticleFamilyCode,

        [ReportData(Field = "afaDesignation")]
        public string ArticleFamilyDesignation { get; set; }                //afaDesignation AS ArticleFamilyDesignation,

        // ArticleSubFamily
        [ReportData(Field = "asfOid")]
        public string ArticleSubFamily { get; set; }                        //asfOid AS ArticleSubFamily,

        [ReportData(Field = "asfOrd")]
        public uint ArticleSubFamilyOrd { get; set; }                       //asfOrd AS ArticleSubFamilyOrd,

        [ReportData(Field = "asfCode")]
        public uint ArticleSubFamilyCode { get; set; }                      //asfCode AS ArticleSubFamilyCode,

        [ReportData(Field = "asfDesignation")]
        public string ArticleSubFamilyDesignation { get; set; }             //asfDesignation AS ArticleSubFamilyDesignation,

        // Article
        [ReportData(Field = "artOid")]
        public string Article { get; set; }                                 //artOid AS Article,

        [ReportData(Field = "artOrd")]
        public uint ArticleOrd { get; set; }                                //artOrd AS ArticleOrd,

        [ReportData(Field = "artCode")]
        public string ArticleCode { get; set; }                             //artCode AS ArticleCode,

        [ReportData(Field = "artCodeDealer")]
        public string ArticleCodeDealer { get; set; }                       //artCodeDealer AS ArticleCodeDealer,

        [ReportData(Field = "artDesignation")]
        public string ArticleDesignation { get; set; }                      //artDesignation AS ArticleDesignation,

        // ArticleStock
        [ReportData(Field = "stkOid")]
        public string ArticleStock { get; set; }                            //stkOid AS ArticleStock,

        [ReportData(Field = "stkDate")]
        public DateTime ArticleStockDate { get; set; }                      //stkDate AS ArticleStockDate,

        [ReportData(Field = "stkDateDay")]
        public string ArticleStockDateDay { get; set; }                     //stkDate AS ArticleStockDateDay,

        [ReportData(Field = "stkDocumentNumber")]
        public string ArticleStockDocumentNumber { get; set; }              //stkDocumentNumber AS ArticleStockDocumentNumber,

        [ReportData(Field = "stkQuantity")]
        public decimal ArticleStockQuantity { get; set; }                   //stkQuantity AS ArticleStockQuantity,

        // ConfigurationUnitMeasure
        [ReportData(Field = "aumAcronym")]
        public string ConfigurationUnitMeasureaumAcronym { get; set; }      //aumAcronym AS ConfigurationUnitMeasureaumAcronym

        [ReportData(Field = "aumDesignation")]
        public string ConfigurationUnitMeasureDesignation { get; set; }     //aumDesignation AS ConfigurationUnitMeasureDesignation,
    }
}
