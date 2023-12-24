

namespace kt_eventSystems_Filchagin
{
    public static class EventSystem
    {
        private static Dictionary<string, Action<DateTime>>? _actions = new();

        public static void CreateEvent(string eventName)
        {
            if(_actions==null)
            {
                return;
            }
            if (_actions.ContainsKey(eventName))
            {
                return;
            }
            _actions.Add(eventName, null);
        }
        public static void Subscribe(string eventName, Action<DateTime> callBack)
        {
            if (_actions == null)
            {
                return;
            }
            if (!_actions.ContainsKey(eventName))
            {
                return;
            }
            _actions[eventName] += callBack;
        }
        public static void RaiseEvent(string eventName)
        {   
            if (_actions == null)
            {
                return;
            }
            if (!_actions.ContainsKey(eventName))
            {
                return;
            }
            else if (_actions[eventName] == null)
            {
                return;
            }
            _actions[eventName]?.Invoke(DateTime.Now);
        }
        public static void Unsubscribe(string eventName, Action<DateTime> callBack)
        {
            if (_actions == null)
            {
                return;
            }
            if (!_actions.ContainsKey(eventName))
            {
                return;
            }
            _actions[eventName] -= callBack;
        }
        public static void RemoveEvent(string eventName)
        {
            if (_actions == null)
            {
                return;
            }
            if (!_actions.ContainsKey(eventName))
            {
                return;
            }
            _actions.Remove(eventName);
        }
        public static void CleareE()
        {
            if (_actions == null)
            {
                return;
            }
            _actions.Clear();
        }
    }
}
