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
    public class ContactsController : SurfaceController
    {
        private readonly DatabaseService _db;
        public ContactsController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, DatabaseService db) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                await _db.AddContactMessageToDb(contactForm);

                return LocalRedirect(contactForm.RedirectUrl ?? "/");
            }

            return CurrentUmbracoPage();

            //using var mail = new MailService("no-reply@crito.com", "smtp.crito.com", 587, "umbraco@crito.com", "BytMig123!");
            //mail.SendAsync(contactForm.Email, "Message received!", "Hello for you").ConfigureAwait(false);

            //mail.SendAsync("umbraco@crito.com", $"{contactForm.Name} sent an email", contactForm.Message).ConfigureAwait(false);


            //return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscriberForm subscriberForm)
        {
            if (ModelState.IsValid)
            {

                await _db.AddSubscriberToDb(subscriberForm);
                ModelState.Clear();
                return CurrentUmbracoPage();
            }

            return CurrentUmbracoPage();
        }
    }
}
