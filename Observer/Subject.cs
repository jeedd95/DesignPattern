namespace DesignPattern.Observer
{
    internal interface Subject
    {
        /// <summary>
        /// 옵저버 등록
        /// </summary>
        /// <param name="o"></param>
        void RegisterObserver(Observer o);
        /// <summary>
        /// 옵저버 해제
        /// </summary>
        /// <param name="o"></param>
        void UnregisterObserver(Observer o);
        /// <summary>
        /// 옵저버에게 전달
        /// </summary>
        void NotifyObserver();
    }
}
