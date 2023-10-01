
using DomainLogicWithSequence;

static IPainter FindCheapestPaint(double sqMeters, IEnumerable<IPainter> painters)
{
	return
		painters
			.Where(p => p.IsAvailable)
			.WithMinmum(p => p.EstimateCompensation(sqMeters));
}
static void main(string[] args)
{

}
