using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Registration
{
    public interface IRegistrationService
    {
        Task<IList<RegistrationModel>> GetAllRegistrations();

        Task AddRegistration(RegistrationModel Registration);

        Task UpdateRegistration(RegistrationModel Registration);

        Task<RegistrationModel> GetRegistrationData(int? id);

        Task DeleteRegistration(int? id);
    }
}
