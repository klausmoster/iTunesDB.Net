﻿using iTunesDB.Net.Writers;
using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class GetXmlTests
    {
        [TestFixture]
        public class WithFilledDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void DbToXml()
            {
                var dbToXmlWriter = new DbToXmlWriter();
                var xml = dbToXmlWriter.GetXml(Db);

                Assert.AreEqual(ExportXml, xml);
            }
        }

        [TestFixture]
        public class WithEmptyDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void DbToXml()
            {
                var dbToXmlWriter = new DbToXmlWriter();
                var xml = dbToXmlWriter.GetXml(DbEmpty);

                Assert.AreEqual(ExportXml, xml);
            }
        }
    }
}
