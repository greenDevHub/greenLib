using Bibo_Verwaltung.Database;

namespace Bibo_Verwaltung
{
    class Condition
    {
        #region attributes
        int conditionId;
        /// <summary>
        /// get/set the id of the condition
        /// </summary>
        public int ConditionId { get { return conditionId; } set { conditionId = value; } }

        string conditionName;
        /// <summary>
        /// get/set the name of the condition
        /// </summary>
        public string ConditionName { get { return conditionName; } set { conditionName = value; } }
        #endregion

        #region variables
        Command c = new Command(Command.Table.condition);

        #endregion

        /// <summary>
        /// create an empty condition object
        /// </summary>
        public Condition()
        {

        }

        /// <summary>
        /// create an condition instance and load its information
        /// </summary>
        /// <param name="conditionId"></param>
        public Condition(int conditionId)
        {
            ConditionId = conditionId;
            LoadCondition();
        }

        /// <summary>
        /// loads the data of the condition object
        /// </summary>
        public void LoadCondition()
        {
            c.LoadSmallEntity(ref conditionId, ref conditionName);
        }


        /// <summary>
        /// adds a condition to database if not exists
        /// </summary>
        public void Add()
        {
            c.AddSmallEntityIfNotExists(ConditionName);
        }
    }
}
