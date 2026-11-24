using System.Xml.Linq;

namespace XRechnung;

public static class UblNamespaces
{
    public static readonly XNamespace Invoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
    public static readonly XNamespace CommonBasicComponents = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
    public static readonly XNamespace CommonAggregateComponents = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
    public static readonly XNamespace CommonExtensionComponents = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
}
