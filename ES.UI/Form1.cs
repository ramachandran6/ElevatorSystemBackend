using ES.BusinessRules;
using ES.Model;
using System.Collections;

namespace ES.UI
{
    public partial class Form1 : Form
    {
        int persons = 0;
        Stack<int> list = new Stack<int>();
        int weightLimit = 400;
        public Form1()
        {
            InitializeComponent();
        }

        private void addperson_Click(object sender, EventArgs e)
        {
            persons++;
            ModelPerson mp = new ModelPerson();
            mp.person = persons;

            noOfPersons.Text = persons.ToString();
            Random rnd = new Random();
            int weight = rnd.Next(40, 120);
            mp.weight = weight;


            //list.Push(weight);
            //personsWeights.Text += weight.ToString() + " ,";

            //int sum = 0;
            //foreach(int i in list)
            //{
            //    sum += i;
            //    if (sum > weightLimit)
            //    {
            //        list.Pop();
            //        sum -= i;
            //        MessageBox.Show("last person with weight " + i + " is removed");
            //        break;
            //    }
            //}
            //overAllWeights.Text = sum.ToString();

            RulesPerson rp = new RulesPerson();
            if (rp.addPerson(mp))
            {
                MessageBox.Show("Value added");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}