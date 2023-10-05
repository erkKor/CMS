using Crito.Context;
using Crito.Models;
using Crito.Models.Entity;

namespace Crito.Services
{
    public class DatabaseService
    {
        private readonly DataContext _dataContext;

        public DatabaseService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddContactMessageToDb(ContactForm form)
        {
            _dataContext.ContactUsMessages.Add(new ContactUsEntity
            {
                Email = form.Email,
                Name = form.Name,
                Message = form.Message
            });

            await _dataContext.SaveChangesAsync();
        }

        public async Task AddSubscriberToDb(SubscriberForm form)
        {
            _dataContext.Subscribers.Add(new SubscriberEntity { Email = form.Email });
            await _dataContext.SaveChangesAsync();
        }
    }
}
