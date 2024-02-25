namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private VisitRouteMover _visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }

        private int currentIndex = 0; //başlangıç indexi default olarak tanımlandı
        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if(currentIndex < _visitRouteMover.VisitRouteCount) //visitroutemoverda yer alan taşınacak değer sayısından küçükse
            {
                CurrentItem = _visitRouteMover.visitRoutes[currentIndex++]; //tur rotalarındaki index değerinin bir artmıs halini alacaksın
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
