using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace Framework.Utilites
{
    public class Verify
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        public void AreEqual(string s1, string s2, string message)
        {
            try
            {
                Assert.AreEqual(s1,s2);
            }
            catch (UnitTestAssertException)
            {
                logger.Error(message);
            }
        }

        public void IsTrue(bool res, string message)
        {
            try
            {
                Assert.IsTrue(res);
            }
            catch (UnitTestAssertException)
            {
                logger.Error(message);
            }
        }
    }
}
