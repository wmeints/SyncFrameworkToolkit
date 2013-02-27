// Type: System.Runtime.Serialization.Json.JsonReaderWriterFactory
// Assembly: System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\System.ServiceModel.Web\3.5.0.0__31bf3856ad364e35\System.ServiceModel.Web.dll

using System.IO;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace System.Xml
{
    public delegate void OnXmlDictionaryReaderClose(XmlDictionaryReader reader);
}

namespace System.Runtime.Serialization.Json
{
    public static class JsonReaderWriterFactory
    {
        public static XmlDictionaryReader CreateJsonReader(Stream stream, XmlDictionaryReaderQuotas quotas)
        {
            return JsonReaderWriterFactory.CreateJsonReader(stream, (Encoding)null, quotas, (OnXmlDictionaryReaderClose)null);
        }

        public static XmlDictionaryReader CreateJsonReader(byte[] buffer, XmlDictionaryReaderQuotas quotas)
        {
            if (buffer == null)
                throw new ArgumentNullException("buffer");
            else
                return JsonReaderWriterFactory.CreateJsonReader(buffer, 0, buffer.Length, (Encoding)null, quotas, (OnXmlDictionaryReaderClose)null);
        }

        public static XmlDictionaryReader CreateJsonReader(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose)
        {
            XmlJsonReader xmlJsonReader = new XmlJsonReader();
            xmlJsonReader.SetInput(stream, encoding, quotas, onClose);
            return (XmlDictionaryReader)xmlJsonReader;
        }

        public static XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas)
        {
            return JsonReaderWriterFactory.CreateJsonReader(buffer, offset, count, (Encoding)null, quotas, (OnXmlDictionaryReaderClose)null);
        }

        public static XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose)
        {
            XmlJsonReader xmlJsonReader = new XmlJsonReader();
            xmlJsonReader.SetInput(buffer, offset, count, encoding, quotas, onClose);
            return (XmlDictionaryReader)xmlJsonReader;
        }

        public static XmlDictionaryWriter CreateJsonWriter(Stream stream)
        {
            return JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true);
        }

        public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding)
        {
            return JsonReaderWriterFactory.CreateJsonWriter(stream, encoding, true);
        }

        public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding, bool ownsStream)
        {
            XmlJsonWriter xmlJsonWriter = new XmlJsonWriter();
            xmlJsonWriter.SetOutput(stream, encoding, ownsStream);
            return (XmlDictionaryWriter)xmlJsonWriter;
        }
    }
}
