namespace kt_eventSystems_Filchagin
{
    class Program
    {
        static void Main(string[] args)
        {
            EventSystem.CreateEvent("AttackWaveStart");
            EventSystem.CreateEvent("AttackWaveEnd");


            Player player = new Player();
            AnotherClass another = new AnotherClass();

            EventSystem.RaiseEvent("AttackWaveStart");
            EventSystem.RaiseEvent("AttackWaveEnd");
            EventSystem.RaiseEvent("AttackWaveStart");
            EventSystem.RaiseEvent("AttackWaveEnd");

            while (true)
            {
                EventSystem.RaiseEvent("DateTime");
                Thread.Sleep(1000);
            }
        }
    }
}
