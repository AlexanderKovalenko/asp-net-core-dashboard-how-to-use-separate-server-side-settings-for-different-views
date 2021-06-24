using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AspNetCore31Dashboard {
    public class SalesDashboardConfigurator : DashboardConfigurator {
        public SalesDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data/Sales").PhysicalPath));
            CustomParameters += SalesDashboardConfigurator_CustomParameters;
        }

        private void SalesDashboardConfigurator_CustomParameters(object sender, CustomParametersWebEventArgs e) {
            e.Parameters.Add(new Parameter("CacheParameter", typeof(string), "Sales"));
        }
    }

    public class MarketingDashboardConfigurator : DashboardConfigurator {
        public MarketingDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data/Marketing").PhysicalPath));
            CustomParameters += MarketingDashboardConfigurator_CustomParameters;
        }

        private void MarketingDashboardConfigurator_CustomParameters(object sender, CustomParametersWebEventArgs e) {
            e.Parameters.Add(new Parameter("CacheParameter", typeof(string), "Marketing"));
        }
    }
}