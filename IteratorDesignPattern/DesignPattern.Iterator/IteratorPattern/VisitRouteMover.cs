namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutes= new List<VisitRoute>();
        public void AddVisitRoute(VisitRoute visitRoute)
        {
            visitRoutes.Add(visitRoute);
        }

        public int VisitRouteCount { get=> visitRoutes.Count; } //ziyaret edilecek şehir sayısı
        public IIterator<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);//her defasında kendi içinde döndürebileceği visitrouteiterator içinde bulundauğu sınıfı
        }
    }
}
