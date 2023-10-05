using Crito.Models;
using Crito.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Crito.Controllers
{
    public class SubscriberController : SurfaceController
    {
        private readonly DatabaseService _db;
        public SubscriberController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, DatabaseService db) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Index(SubscriberForm subscriberForm)
        {
            if (ModelState.IsValid)
            {
                await _db.AddSubscriberToDb(subscriberForm);
                return CurrentUmbracoPage();
            }

            return CurrentUmbracoPage();
        }
    }
}
