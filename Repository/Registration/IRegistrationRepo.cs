using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Registration
{
    public interface IRegistrationRepo
    {
        IList<RegistrationModel> GetAllRegistrations();

        void AddRegistration(RegistrationModel Registration);

        void UpdateRegistration(RegistrationModel Registration);

        RegistrationModel GetRegistrationData(int? id);

        void DeleteRegistration(int? id);

    }
}
