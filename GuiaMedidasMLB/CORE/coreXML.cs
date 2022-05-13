using System.Xml;

namespace GuiaMedidasMLB.CORE
{
    public class coreXML
    {
        public string Ler(string _path, string _singleNode)
        {
            string result = string.Empty;

            var doc = new XmlDocument();
            doc.Load(_path);

            XmlNode node = doc.DocumentElement.SelectSingleNode(_singleNode);

            if (node != null)
            {
                result = node.InnerText;
            }

            node = null;
            doc = null;

            return result;
        }
    }
}
