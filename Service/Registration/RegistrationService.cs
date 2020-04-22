using Models;
using Repository.Registration;
using System;
using System.Collections.Generic;

namespace Service.Registration
{
    public class RegistrationService : IRegistrationService
    {
        private IRegistrationRepo IRegistrationrepo;

        public RegistrationService(IRegistrationRepo IRegistrationre)
        {
            IRegistrationrepo = IRegistrationre;
        }
        //To View all Registrations details    
        public IList<RegistrationModel> GetAllRegistrations()
        {
            IList<RegistrationModel> list=new List<RegistrationModel>();
            try
            {
                list= IRegistrationrepo.GetAllRegistrations();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex);
            }
            return list;
        }
        //To Add new Registration record    
        public void AddRegistration(RegistrationModel Registration)
        {
            try
            {
                IRegistrationrepo.AddRegistration(Registration);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        //To Update the records of a particluar Registration  
        public void UpdateRegistration(RegistrationModel Registration)
        {
            try
            {
                IRegistrationrepo.UpdateRegistration(Registration);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //Get the details of a particular Registration  
        public RegistrationModel GetRegistrationData(int? id)
        {
            RegistrationModel objRegistration = new RegistrationModel();
            try
            {
                objRegistration=IRegistrationrepo.GetRegistrationData(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return objRegistration;
        }
        //To Delete the record on a particular Registration  
        public void DeleteRegistration(int? id)
        {
            try
            {
                IRegistrationrepo.DeleteRegistration(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
