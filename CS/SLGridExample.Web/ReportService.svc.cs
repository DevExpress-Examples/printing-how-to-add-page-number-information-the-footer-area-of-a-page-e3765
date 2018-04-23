﻿// Developer Express Code Central Example:
// How to use the PrintCellStyle property to customize cell's printing appearance
// 
// This example shows how to create custom PrintCellStyle for grid columns to bring
// a custom printing appearance for PopupImageEdit, CheckBoxEdit and MemoEdit.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3227

using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.Xpf.Printing.Service;
using DevExpress.XtraReports.Service;
using DevExpress.XtraReports.UI;

namespace SLGridExample.Web {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in code, svc and config file together.
    [SilverlightFaultBehavior]
    public class ReportService : DevExpress.XtraReports.Service.ReportService {
        protected override void FillDataSources(XtraReport report, string reportName, bool isDesignActive) {
        }

        protected override void SaveReportLayout(string reportName, byte[] layoutData) {
            throw new FaultException("This method is not implemented. Implement the SaveReportLayout method on the server-side, in the report service code-behind.");
        }
    }
}
