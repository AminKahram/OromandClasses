using System.Collections;

namespace OOPInCSharp.PredefinedInterfaces
{
    public class TestEnumerable : IEnumerable<TestDisposable>
    {
        public IEnumerator<TestDisposable> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
