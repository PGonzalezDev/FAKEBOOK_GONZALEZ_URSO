using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FAKEDAO;
using FAKEMODELS;
using FAKEMODELS.Wrappers;

namespace FAKECONTROLLERS
{
    public class PublicationController
    {
        PublicationDAO publicationDAO = new PublicationDAO();

        public void Post(ref Publication post)
        {
            try
            {
                publicationDAO.Post(ref post);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public List<PublicationWrapper> GetAllByUser(User user)
        {
            try
            {
                return publicationDAO.GetAllByUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
