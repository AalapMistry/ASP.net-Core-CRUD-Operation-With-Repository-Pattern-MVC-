using Models;
using Repository.Registration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Registration
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepo _IRegistrationrepo;

        public RegistrationService(IRegistrationRepo IRegistrationre)
        {
            _IRegistrationrepo = IRegistrationre;
        }
        //To View all Registrations details    
        public async Task<IList<RegistrationModel>> GetAllRegistrations()
        {
            IList<RegistrationModel> list=new List<RegistrationModel>();
            try
            {
                list= await _IRegistrationrepo.GetAllRegistrations();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex);
            }
            return list;
        }
        //To Add new Registration record    
        public async Task AddRegistration(RegistrationModel Registration)
        {
            try
            {
                await _IRegistrationrepo.AddRegistration(Registration);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        //To Update the records of a particluar Registration  
        public async Task UpdateRegistration(RegistrationModel Registration)
        {
            try
            {
                await _IRegistrationrepo.UpdateRegistration(Registration);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //Get the details of a particular Registration  
        public async Task<RegistrationModel> GetRegistrationData(int? id)
        {
            RegistrationModel objRegistration = new RegistrationModel();
            try
            {
                objRegistration= await _IRegistrationrepo.GetRegistrationData(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return objRegistration;
        }
        //To Delete the record on a particular Registration  
        public async Task DeleteRegistration(int? id)
        {
            try
            {
                await _IRegistrationrepo.DeleteRegistration(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
