

namespace kt_eventSystems_Filchagin
{
    public class AnotherClass
    {
        public AnotherClass() 
        {
            EventSystem.Subscribe("AttackWaveStart", Defend);
            EventSystem.Subscribe("AttackWaveEnd", RetireHome);
            EventSystem.Subscribe("DateTime", Timing);
        }
        public void Defend(DateTime dateTime)
        {
            Console.WriteLine($"Сейчас {DateTime.Now}, что то произойдет ");
        }
        public void RetireHome(DateTime dateTime)
        {
            Console.WriteLine($"Домой");
            EventSystem.Unsubscribe("AttackWaveEnd", RetireHome);
        }
        public void Timing(DateTime dateTime)
        {
            Console.WriteLine($"Времячко : {DateTime.Now}");
        }
    }
}
