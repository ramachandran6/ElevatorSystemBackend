using ES.DataAccess;
using ES.Model;

namespace ES.BusinessRules
{
    public class RulesPerson
    {
        public bool addPerson(ModelPerson mp)
        {
            DataPerson db = new DataPerson();
            if(db.addPerson(mp))
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