using System.Xml.Linq;

namespace XRechnung.UBL;

internal static class XmlExtensions
{
    extension(XElement element)
    {
        /// <summary>
        /// Creates a common aggregate component.
        /// </summary>
        public static XElement CAC(string name, params object?[] content) => new XElement(UblNamespaces.CommonAggregateComponents + name, content);

        /// <summary>
        /// Creates a common basic component.
        /// </summary>
        public static XElement CBC(string name, params object?[] content) => new XElement(UblNamespaces.CommonBasicComponents + name, content);

        public XElement? CBC(string name)
        {
            return element.Element(UblNamespaces.CommonBasicComponents + name);
        }

        public XElement? CAC(string name)
        {
            return element.Element(UblNamespaces.CommonAggregateComponents + name);
        }

        public IEnumerable<XElement> CACs(string name)
        {
            return element.Elements(UblNamespaces.CommonAggregateComponents + name);
        }
    }
}
