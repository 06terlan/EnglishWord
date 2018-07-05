using System.Xml.Linq;

namespace EnglishWords
{
    class xmlDataM
    {
        string path;
        XDocument xdoc;

        public xmlDataM(string path)
        {
            this.path = path;
            xdoc = XDocument.Load(path);
        }

        public void reDoc()
        {
            xdoc = XDocument.Load(path);
        }

        public void Add(XElement elements,string element)
        {
            xdoc.Element(element).Add(elements);
            Save();
        }

        public void Save()
        {
            xdoc.Save(path);
        }

        public XDocument Doc()
        {
            return xdoc;
        }
    }
}
