namespace Map.Common
{
    using System;
    using System.Xml;

    public class Utility
    {
        public static string ReadXMLAttribute(XmlReader r, string attr)
        {
            var result = string.Empty;
            try
            {
                result = r[attr];
            }
            catch (Exception)
            {
                // ignored
            }

            return result ?? string.Empty;
        }

        public static void WriteXMLAttribute(XmlWriter writer, string attributeName, string attributeValue)
        {
            if (string.IsNullOrEmpty(attributeValue))
            {
                return;
            }
            writer.WriteAttributeString(attributeName, attributeValue);
        }
    }
}
