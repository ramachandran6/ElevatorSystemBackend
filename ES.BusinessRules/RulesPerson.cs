using ES.DataAccess;
using ES.Model;

namespace ES.BusinessRules
{
    public class RulesPerson
    {
        DataPerson db = new DataPerson();
        public bool addPerson(ModelPerson mp)
        {
           
            if(db.addPerson(mp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getWeight()
        {
            return db.getSumWeight();
        }
    }
}