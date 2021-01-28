using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Delete(Gamer gamer)
        {
            if (gamer.FirstName== "BERK" && gamer.BirthYear== 1993)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Validate(Gamer gamer)
        {
            if (gamer.IdendityId==12345 && gamer.FirstName == "BERK" && gamer.LastName == "ÖZMENEKŞE" && gamer.BirthYear == 1994)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
