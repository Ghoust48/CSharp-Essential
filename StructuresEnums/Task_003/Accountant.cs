namespace Task_003
{
    public class Accountant
    {
        public bool AskForBonus(Positions worker, int hours)
        {
            return (int)worker < hours;
        }
    }
}