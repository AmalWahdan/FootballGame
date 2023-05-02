namespace ObserverPattern.SubjectConcrete
{
    internal class FootBall : Ball
    {
        private Position myposition;
        private List<Observer> observers;

        public FootBall() => observers = new List<Observer>();
        public void AttachObserver(Observer observer) => observers.Add(observer);
        public void DetachObserver(Observer observer)=> observers.Remove(observer);
        public void NotifyObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.update(myposition);
            }
        }
        public Position GetBallPosition()=> myposition;
        public void SetBallPosition(Position position) => myposition = position;
    }
}
