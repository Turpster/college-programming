using Layout;

namespace Selection.Papers.Exercises_One.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("An electronics company gives its customers the following discounts:\n" +
                                "*---------+---------+---------+-----------+-------------------+\n" +
                                "| < £1000 | < £2500 | < £5000 | < £10,000 | < £10,000 or more |" +
                                "| 0       | 5%      | 10%     | 15%       | 20%               |" +
                                "*---------+---------+---------+-----------+-------------------+\n",
            "Task One: Discounts")
        {
        }

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}