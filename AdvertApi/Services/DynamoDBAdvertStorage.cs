using AdvertApi.Models;

namespace AdvertApi.Services
{
    public class DynamoDBAdvertStorage : IAdvertStorageService
    {
        public Task<string> AddAsync(AdvertModel model)
        {
            throw new NotImplementedException();
        }

        public Task ConfirmAsync(ConfirmAdvertModel model)
        {
            throw new NotImplementedException();
        }
    }
}
