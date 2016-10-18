using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace UtilsTests
{
    [TestFixture]
    public class DictionaryExtensionsTests
    {
        [Test]
        public void TransposeTest()
        {
            var dico = Enumerable.Range(0, 4)
                .ToDictionary(i => i, i => (IDictionary<char, string>) "abc".Take(i).ToDictionary(c => c, c => c.ToString()));
            var transposedDico = dico.Transpose();
            Assert.IsTrue("abc".All(c => transposedDico.ContainsKey(c)));
            Assert.AreEqual(transposedDico['c'][3], "c");
        }
    }
}
