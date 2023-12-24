

using System.Runtime.Serialization;

namespace kt_eventSystems_Filchagin
{
    public class Player
    {
        public Player()
        {
            EventSystem.Subscribe("AttackWaveStart", Defend);
            EventSystem.Subscribe("AttackWaveEnd", RetireHome);
            EventSystem.Subscribe("DateTime", Timing);
        }
        public void Defend(DateTime dateTime)
        {
            Console.WriteLine($"Сейчас {DateTime.Now}, я готов к отражению атаки монстров!");
        }
        public void RetireHome(DateTime dateTime)
        {
            Console.WriteLine($"Я успешно отбился от врагов и теперь могу вернуться домой");
            //EventSystem.Unsubscribe("AttackWaveEnd", RetireHome);
        }
        public void Timing(DateTime dateTime)
        {
            Console.WriteLine($"Текущее время : {DateTime.Now}");
        }
    }
}
