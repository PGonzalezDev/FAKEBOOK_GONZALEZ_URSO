using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FAKEDAO;
using FAKEMODELS;

namespace FAKECONTROLLERS
{
    public class PublicationController
    {
        PublicationDAO publicationDAO = new PublicationDAO();

        public void Post(ref Publication pub)
        {
            try
            {
                publicationDAO.Post(ref pub);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
    }
}
