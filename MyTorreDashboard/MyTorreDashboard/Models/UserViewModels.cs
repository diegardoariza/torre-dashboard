using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TorreJsonReader.BL;
using TorreJsonReader.VO;

namespace MyTorreDashboard.Models
{
    public class UserViewModels:PersonVO
    {
        public List<PersonVO> GetUsers()
        {
            TorreSearchUserVO allUsers = (TorreSearchUserVO) RequestManager.LoadAllUsers();
            List<PersonVO> userResults = allUsers.Results;
            return userResults;
        }
    }
}