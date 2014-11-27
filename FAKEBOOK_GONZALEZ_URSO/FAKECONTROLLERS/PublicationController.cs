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

        public void Add(ref Publication post)
        {
            try
            {
                publicationDAO.Add(ref post);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void Remove(int postId)
        {
            try
            {
                publicationDAO.Remove(postId);
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
