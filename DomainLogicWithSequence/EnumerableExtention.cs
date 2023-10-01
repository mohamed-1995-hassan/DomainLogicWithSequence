using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicWithSequence
{
    public static class EnumerableExtention
    {
        public static T WithMinmum<T,TKey>(this IEnumerable<T> sequence, Func<T, TKey> criteration)
            where T : class
            where TKey : IComparable<TKey> =>
            sequence.Aggregate( (T) null ,(best,cur)=>
            best == null || criteration(cur).CompareTo(criteration(best))< 0 ? cur : best );
        
    }
}
