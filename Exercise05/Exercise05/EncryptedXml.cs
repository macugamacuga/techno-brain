using System.Xml;

namespace Exercise05
{
    internal class EncryptedXml
    {
        private XmlDocument doc;

        public EncryptedXml()
        {
        }

        public EncryptedXml(XmlDocument doc)
        {
            this.doc = doc;
        }
    }
}