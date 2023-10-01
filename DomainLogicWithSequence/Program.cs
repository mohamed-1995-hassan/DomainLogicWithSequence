
using DomainLogicWithSequence;

static IPainter FindCheapestPaint(double sqMeters, IEnumerable<IPainter> painters)
{
	double bestPrice = 0;
	IPainter cheapest = null;
	foreach (IPainter painter in painters)
	{
		if (painter.IsAvailable)
		{
			double price = painter.EstimateCompensation(sqMeters);
			if (cheapest == null || price < bestPrice)
			{
				cheapest = painter;
            }
        }
	}
	return cheapest;
}
static void main(string[] args)
{

}
