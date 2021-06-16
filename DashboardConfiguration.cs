using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AspNetCore31Dashboard {
    public class SalesDashboardConfigurator : DashboardConfigurator {
        public SalesDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data/Sales").PhysicalPath));
        }
    }

    public class MarketingDashboardConfigurator : DashboardConfigurator {
        public MarketingDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data/Marketing").PhysicalPath));
        }
    }

    public class SalesDashboardController : DashboardController {
        public SalesDashboardController(SalesDashboardConfigurator configrurator) : base(configrurator) {

        }
    }

    public class MarketingDashboardController : DashboardController {
        public MarketingDashboardController(MarketingDashboardConfigurator configrurator) : base(configrurator) {

        }
    }
}