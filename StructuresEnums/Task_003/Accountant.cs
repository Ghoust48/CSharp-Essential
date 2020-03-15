namespace Task_003
{
    public class Accauntant
    {
        public bool AskForBonus(Positions worker, int hours)
        {
            return (int)worker < hours;
        }
    }
}