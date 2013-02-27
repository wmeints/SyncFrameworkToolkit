// Type: System.Runtime.Serialization.Json.XmlJsonReader
// Assembly: System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\System.ServiceModel.Web\3.5.0.0__31bf3856ad364e35\System.ServiceModel.Web.dll

using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace System.Runtime.Serialization.Json
{
    internal class XmlJsonReader : XmlBaseReader, IXmlJsonReaderInitializer
    {
        private static byte[] charType = new byte[256]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3
    };
        private XmlJsonReader.JsonComplexTextMode complexTextMode = XmlJsonReader.JsonComplexTextMode.None;
        private const int MaxTextChunk = 2048;
        private bool buffered;
        private byte[] charactersToSkipOnNextRead;
        private bool expectingFirstElementInNonPrimitiveChild;
        private int maxBytesPerRead;
        private OnXmlDictionaryReaderClose onReaderClose;
        private bool readServerTypeElement;
        private int scopeDepth;
        private JsonNodeType[] scopes;

        public override bool CanCanonicalize
        {
            get
            {
                return false;
            }
        }

        public override string Value
        {
            get
            {
                if (this.IsAttributeValue && !this.IsLocalName("type"))
                    return this.UnescapeJsonString(base.Value);
                else
                    return base.Value;
            }
        }

        private bool IsAttributeValue
        {
            get
            {
                if (this.Node.NodeType != XmlNodeType.Attribute)
                    return this.Node is XmlBaseReader.XmlAttributeTextNode;
                else
                    return true;
            }
        }

        private bool IsReadingCollection
        {
            get
            {
                if (this.scopeDepth > 0)
                    return this.scopes[this.scopeDepth] == JsonNodeType.Collection;
                else
                    return false;
            }
        }

        private bool IsReadingComplexText
        {
            get
            {
                if (!this.Node.IsAtomicValue)
                    return this.Node.NodeType == XmlNodeType.Text;
                else
                    return false;
            }
        }

        static XmlJsonReader()
        {
        }

        public override void Close()
        {
            base.Close();
            OnXmlDictionaryReaderClose dictionaryReaderClose = this.onReaderClose;
            this.onReaderClose = (OnXmlDictionaryReaderClose)null;
            this.ResetState();
            if (dictionaryReaderClose == null)
                return;
            try
            {
                dictionaryReaderClose((XmlDictionaryReader)this);
            }
            catch (Exception ex)
            {
                if (!System.ServiceModel.DiagnosticUtility.IsFatal(ex))
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperCallback(ex);
                throw;
            }
        }

        public override void EndCanonicalization()
        {
            throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new NotSupportedException());
        }

        public override string GetAttribute(int index)
        {
            return this.UnescapeJsonString(base.GetAttribute(index));
        }

        public override string GetAttribute(string localName, string namespaceUri)
        {
            if (localName != "type")
                return this.UnescapeJsonString(base.GetAttribute(localName, namespaceUri));
            else
                return base.GetAttribute(localName, namespaceUri);
        }

        public override string GetAttribute(string name)
        {
            if (name != "type")
                return this.UnescapeJsonString(base.GetAttribute(name));
            else
                return base.GetAttribute(name);
        }

        public override string GetAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri)
        {
            if (XmlDictionaryString.GetString(localName) != "type")
                return this.UnescapeJsonString(base.GetAttribute(localName, namespaceUri));
            else
                return base.GetAttribute(localName, namespaceUri);
        }

        public override bool Read()
        {
            if (this.Node.CanMoveToElement)
                this.MoveToElement();
            if (this.Node.ReadState == ReadState.Closed)
                return false;
            if (this.Node.ExitScope)
                this.ExitScope();
            if (!this.buffered)
                this.BufferReader.SetWindow(this.ElementNode.BufferOffset, this.maxBytesPerRead);
            byte ch;
            if (!this.IsReadingComplexText)
            {
                this.SkipWhitespaceInBufferReader();
                if (this.TryGetByte(out ch) && ((int)this.charactersToSkipOnNextRead[0] == (int)ch || (int)this.charactersToSkipOnNextRead[1] == (int)ch))
                {
                    this.BufferReader.SkipByte();
                    this.charactersToSkipOnNextRead[0] = (byte)0;
                    this.charactersToSkipOnNextRead[1] = (byte)0;
                }
                this.SkipWhitespaceInBufferReader();
                if (this.TryGetByte(out ch) && (int)ch == 93 && this.IsReadingCollection)
                {
                    this.BufferReader.SkipByte();
                    this.SkipWhitespaceInBufferReader();
                    int num = (int)this.ExitJsonScope();
                }
                if (this.BufferReader.EndOfFile)
                {
                    if (this.scopeDepth > 0)
                    {
                        this.MoveToEndElement();
                        return true;
                    }
                    else
                    {
                        this.MoveToEndOfFile();
                        return false;
                    }
                }
            }
            ch = this.BufferReader.GetByte();
            if (this.scopeDepth == 0)
                this.ReadNonExistentElementName(StringHandleConstStringType.Root);
            else if (this.IsReadingComplexText)
            {
                switch (this.complexTextMode)
                {
                    case XmlJsonReader.JsonComplexTextMode.QuotedText:
                        if ((int)ch == 92)
                        {
                            this.ReadEscapedCharacter(true);
                            break;
                        }
                        else
                        {
                            this.ReadQuotedText(true);
                            break;
                        }
                    case XmlJsonReader.JsonComplexTextMode.NumericalText:
                        this.ReadNumericalText();
                        break;
                    case XmlJsonReader.JsonComplexTextMode.None:
                        // ISSUE: reference to a compiler-generated method
                        XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
            {
              (object) (char) ch
            })));
                        break;
                }
            }
            else if (this.IsReadingCollection)
                this.ReadNonExistentElementName(StringHandleConstStringType.Item);
            else if ((int)ch == 93)
            {
                this.BufferReader.SkipByte();
                this.MoveToEndElement();
                int num = (int)this.ExitJsonScope();
            }
            else if ((int)ch == 123)
            {
                this.BufferReader.SkipByte();
                this.SkipWhitespaceInBufferReader();
                ch = this.BufferReader.GetByte();
                if ((int)ch == 125)
                {
                    this.BufferReader.SkipByte();
                    this.SkipWhitespaceInBufferReader();
                    if (this.TryGetByte(out ch))
                    {
                        if ((int)ch == 44)
                            this.BufferReader.SkipByte();
                    }
                    else
                        this.charactersToSkipOnNextRead[0] = (byte)44;
                    this.MoveToEndElement();
                }
                else
                {
                    this.EnterJsonScope(JsonNodeType.Object);
                    this.ParseStartElement();
                }
            }
            else if ((int)ch == 125)
            {
                this.BufferReader.SkipByte();
                if (this.expectingFirstElementInNonPrimitiveChild)
                {
                    this.SkipWhitespaceInBufferReader();
                    ch = this.BufferReader.GetByte();
                    switch (ch)
                    {
                        case (byte)44:
                        case (byte)125:
                            this.BufferReader.SkipByte();
                            break;
                        default:
                            // ISSUE: reference to a compiler-generated method
                            XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
              {
                (object) (char) ch
              })));
                            break;
                    }
                    this.expectingFirstElementInNonPrimitiveChild = false;
                }
                this.MoveToEndElement();
            }
            else if ((int)ch == 44)
            {
                this.BufferReader.SkipByte();
                this.MoveToEndElement();
            }
            else if ((int)ch == 34)
            {
                if (this.readServerTypeElement)
                {
                    this.readServerTypeElement = false;
                    this.EnterJsonScope(JsonNodeType.Object);
                    this.ParseStartElement();
                }
                else if (this.Node.NodeType == XmlNodeType.Element)
                {
                    if (this.expectingFirstElementInNonPrimitiveChild)
                    {
                        this.EnterJsonScope(JsonNodeType.Object);
                        this.ParseStartElement();
                    }
                    else
                    {
                        this.BufferReader.SkipByte();
                        this.ReadQuotedText(true);
                    }
                }
                else if (this.Node.NodeType == XmlNodeType.EndElement)
                {
                    this.EnterJsonScope(JsonNodeType.Element);
                    this.ParseStartElement();
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
          {
            (object) '"'
          })));
                }
            }
            else if ((int)ch == 102)
            {
                int offset;
                byte[] buffer = this.BufferReader.GetBuffer(5, out offset);
                if ((int)buffer[offset + 1] != 97 || (int)buffer[offset + 2] != 108 || ((int)buffer[offset + 3] != 115 || (int)buffer[offset + 4] != 101))
                    XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, "false", Encoding.UTF8.GetString(buffer, offset, 5));
                this.BufferReader.Advance(5);
                if (this.TryGetByte(out ch) && !XmlJsonReader.IsWhitespace(ch) && ((int)ch != 44 && (int)ch != 125) && (int)ch != 93)
                    XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, "false", Encoding.UTF8.GetString(buffer, offset, 4) + (object)(char)ch);
                this.MoveToAtomicText().Value.SetValue(ValueHandleType.UTF8, offset, 5);
            }
            else if ((int)ch == 116)
            {
                int offset;
                byte[] buffer = this.BufferReader.GetBuffer(4, out offset);
                if ((int)buffer[offset + 1] != 114 || (int)buffer[offset + 2] != 117 || (int)buffer[offset + 3] != 101)
                    XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, "true", Encoding.UTF8.GetString(buffer, offset, 4));
                this.BufferReader.Advance(4);
                if (this.TryGetByte(out ch) && !XmlJsonReader.IsWhitespace(ch) && ((int)ch != 44 && (int)ch != 125) && (int)ch != 93)
                    XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, "true", Encoding.UTF8.GetString(buffer, offset, 4) + (object)(char)ch);
                this.MoveToAtomicText().Value.SetValue(ValueHandleType.UTF8, offset, 4);
            }
            else if ((int)ch == 110)
            {
                int offset;
                byte[] buffer = this.BufferReader.GetBuffer(4, out offset);
                if ((int)buffer[offset + 1] != 117 || (int)buffer[offset + 2] != 108 || (int)buffer[offset + 3] != 108)
                    XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, "null", Encoding.UTF8.GetString(buffer, offset, 4));
                this.BufferReader.Advance(4);
                this.SkipWhitespaceInBufferReader();
                if (this.TryGetByte(out ch))
                {
                    if ((int)ch == 44 || (int)ch == 125)
                        this.BufferReader.SkipByte();
                    else if ((int)ch != 93)
                        XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, "null", Encoding.UTF8.GetString(buffer, offset, 4) + (object)(char)ch);
                }
                else
                {
                    this.charactersToSkipOnNextRead[0] = (byte)44;
                    this.charactersToSkipOnNextRead[1] = (byte)125;
                }
                this.MoveToEndElement();
            }
            else if ((int)ch == 45 || 48 <= (int)ch && (int)ch <= 57 || ((int)ch == 73 || (int)ch == 78))
            {
                this.ReadNumericalText();
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
        {
          (object) (char) ch
        })));
            }
            return true;
        }

        public override Decimal ReadContentAsDecimal()
        {
            string s = ((XmlReader)this).ReadContentAsString();
            try
            {
                return Decimal.Parse(s, NumberStyles.Float, (IFormatProvider)NumberFormatInfo.InvariantInfo);
            }
            catch (ArgumentException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(s, "decimal", (Exception)ex));
            }
            catch (FormatException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(s, "decimal", (Exception)ex));
            }
            catch (OverflowException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(s, "decimal", (Exception)ex));
            }
        }

        public override int ReadContentAsInt()
        {
            return XmlJsonReader.ParseInt(((XmlReader)this).ReadContentAsString(), NumberStyles.Float);
        }

        public override long ReadContentAsLong()
        {
            string s = ((XmlReader)this).ReadContentAsString();
            try
            {
                return long.Parse(s, NumberStyles.Float, (IFormatProvider)NumberFormatInfo.InvariantInfo);
            }
            catch (ArgumentException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(s, "Int64", (Exception)ex));
            }
            catch (FormatException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(s, "Int64", (Exception)ex));
            }
            catch (OverflowException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(s, "Int64", (Exception)ex));
            }
        }

        public override int ReadValueAsBase64(byte[] buffer, int offset, int count)
        {
            if (!this.IsAttributeValue)
                return base.ReadValueAsBase64(buffer, offset, count);
            if (buffer == null)
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentNullException("buffer"));
            if (offset < 0)
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("ValueMustBeNonNegative")));
            if (offset > buffer.Length)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("OffsetExceedsBufferSize", new object[1]
        {
          (object) buffer.Length
        })));
            }
            else
            {
                if (count < 0)
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", System.Runtime.Serialization.SR.GetString("ValueMustBeNonNegative")));
                if (count <= buffer.Length - offset)
                    return 0;
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", System.Runtime.Serialization.SR.GetString("SizeExceedsRemainingBufferSpace", new object[1]
        {
          (object) (buffer.Length - offset)
        })));
            }
        }

        public override int ReadValueChunk(char[] chars, int offset, int count)
        {
            if (!this.IsAttributeValue)
                return base.ReadValueChunk(chars, offset, count);
            if (chars == null)
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentNullException("chars"));
            if (offset < 0)
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("ValueMustBeNonNegative")));
            if (offset > chars.Length)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", System.Runtime.Serialization.SR.GetString("OffsetExceedsBufferSize", new object[1]
        {
          (object) chars.Length
        })));
            }
            else
            {
                if (count < 0)
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", System.Runtime.Serialization.SR.GetString("ValueMustBeNonNegative")));
                if (count > chars.Length - offset)
                {
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", System.Runtime.Serialization.SR.GetString("SizeExceedsRemainingBufferSpace", new object[1]
          {
            (object) (chars.Length - offset)
          })));
                }
                else
                {
                    string str = this.UnescapeJsonString(this.Node.ValueAsString);
                    int count1 = Math.Min(count, str.Length);
                    if (count1 > 0)
                    {
                        str.CopyTo(0, chars, offset, count1);
                        if (this.Node.QNameType == XmlBaseReader.QNameType.Xmlns)
                            this.Node.Namespace.Uri.SetValue(0, 0);
                        else
                            this.Node.Value.SetValue(ValueHandleType.UTF8, 0, 0);
                    }
                    return count1;
                }
            }
        }

        public void SetInput(byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose)
        {
            if (buffer == null)
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("buffer");
            if (offset < 0)
            {
                // ISSUE: reference to a compiler-generated method
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", SR2.GetString(SR2.ValueMustBeNonNegative, new object[0])));
            }
            if (offset > buffer.Length)
            {
                // ISSUE: reference to a compiler-generated method
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", SR2.GetString(SR2.JsonOffsetExceedsBufferSize, new object[1]
        {
          (object) buffer.Length
        })));
            }
            else
            {
                if (count < 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", SR2.GetString(SR2.ValueMustBeNonNegative, new object[0])));
                }
                if (count > buffer.Length - offset)
                {
                    // ISSUE: reference to a compiler-generated method
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", SR2.GetString(SR2.JsonSizeExceedsRemainingBufferSpace, new object[1]
          {
            (object) (buffer.Length - offset)
          })));
                }
                else
                {
                    this.MoveToInitial(quotas, onClose);
                    ArraySegment<byte> arraySegment = JsonEncodingStreamWrapper.ProcessBuffer(buffer, offset, count, encoding);
                    this.BufferReader.SetBuffer(arraySegment.Array, arraySegment.Offset, arraySegment.Count, (IXmlDictionary)null, (XmlBinaryReaderSession)null);
                    this.buffered = true;
                    this.ResetState();
                }
            }
        }

        public void SetInput(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose)
        {
            if (stream == null)
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("stream");
            this.MoveToInitial(quotas, onClose);
            stream = (Stream)new JsonEncodingStreamWrapper(stream, encoding, true);
            this.BufferReader.SetBuffer(stream, (IXmlDictionary)null, (XmlBinaryReaderSession)null);
            this.buffered = false;
            this.ResetState();
        }

        public override void StartCanonicalization(Stream stream, bool includeComments, string[] inclusivePrefixes)
        {
            throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new NotSupportedException());
        }

        internal static void CheckArray(Array array, int offset, int count)
        {
            if (array == null)
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentNullException("array"));
            if (offset < 0)
            {
                // ISSUE: reference to a compiler-generated method
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", SR2.GetString(SR2.ValueMustBeNonNegative, new object[0])));
            }
            if (offset > array.Length)
            {
                // ISSUE: reference to a compiler-generated method
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("offset", SR2.GetString(SR2.OffsetExceedsBufferSize, new object[1]
        {
          (object) array.Length
        })));
            }
            else
            {
                if (count < 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", SR2.GetString(SR2.ValueMustBeNonNegative, new object[0])));
                }
                if (count <= array.Length - offset)
                    return;
                // ISSUE: reference to a compiler-generated method
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new ArgumentOutOfRangeException("count", SR2.GetString(SR2.SizeExceedsRemainingBufferSpace, new object[1]
        {
          (object) (array.Length - offset)
        })));
            }
        }

        protected override XmlSigningNodeWriter CreateSigningNodeWriter()
        {
            // ISSUE: reference to a compiler-generated method
            throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new NotSupportedException(SR2.GetString(SR2.JsonMethodNotSupported, new object[1]
      {
        (object) "CreateSigningNodeWriter"
      })));
        }

        private static int BreakText(byte[] buffer, int offset, int length)
        {
            if (length > 0 && ((int)buffer[offset + length - 1] & 128) == 128)
            {
                int num1 = length;
                do
                {
                    --length;
                }
                while (length > 0 && ((int)buffer[offset + length] & 192) != 192);
                if (length == 0)
                    return num1;
                byte num2 = (byte)((uint)buffer[offset + length] << 2);
                int num3 = 2;
                while (((int)num2 & 128) == 128)
                {
                    num2 <<= 1;
                    ++num3;
                    if (num3 > 4)
                        return num1;
                }
                if (length + num3 == num1 || length == 0)
                    return num1;
            }
            return length;
        }

        private static int ComputeNumericalTextLength(byte[] buffer, int offset, int offsetMax)
        {
            int num = offset;
            for (; offset < offsetMax; ++offset)
            {
                byte ch = buffer[offset];
                switch (ch)
                {
                    case (byte)44:
                    case (byte)125:
                    case (byte)93:
                        goto label_5;
                    default:
                        if (!XmlJsonReader.IsWhitespace(ch))
                            continue;
                        else
                            goto label_5;
                }
            }
        label_5:
            return offset - num;
        }

        private static int ComputeQuotedTextLengthUntilEndQuote(byte[] buffer, int offset, int offsetMax, out bool escaped)
        {
            int num1 = offset;
            escaped = false;
            for (; offset < offsetMax; ++offset)
            {
                byte num2 = buffer[offset];
                if ((int)num2 < 32)
                {
                    // ISSUE: reference to a compiler-generated method
                    throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new FormatException(SR2.GetString(SR2.InvalidCharacterEncountered, new object[1]
          {
            (object) (char) num2
          })));
                }
                else if ((int)num2 == 92 || (int)num2 == 239)
                {
                    escaped = true;
                    break;
                }
                else if ((int)num2 == 34)
                    break;
            }
            return offset - num1;
        }

        private static bool IsWhitespace(byte ch)
        {
            if ((int)ch != 32 && (int)ch != 9 && (int)ch != 10)
                return (int)ch == 13;
            else
                return true;
        }

        private static char ParseChar(string value, NumberStyles style)
        {
            int num = XmlJsonReader.ParseInt(value, style);
            try
            {
                return Convert.ToChar(num);
            }
            catch (OverflowException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(value, "char", (Exception)ex));
            }
        }

        private static int ParseInt(string value, NumberStyles style)
        {
            try
            {
                return int.Parse(value, style, (IFormatProvider)NumberFormatInfo.InvariantInfo);
            }
            catch (ArgumentException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(value, "Int32", (Exception)ex));
            }
            catch (FormatException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(value, "Int32", (Exception)ex));
            }
            catch (OverflowException ex)
            {
                throw System.ServiceModel.DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)XmlExceptionHelper.CreateConversionException(value, "Int32", (Exception)ex));
            }
        }

        private void BufferElement()
        {
            int offset1 = this.BufferReader.Offset;
            bool flag = false;
            byte num1 = (byte)0;
            while (!flag)
            {
                int offset2;
                int offsetMax;
                byte[] buffer = this.BufferReader.GetBuffer(128, out offset2, out offsetMax);
                if (offset2 + 128 == offsetMax)
                {
                    for (int index = offset2; index < offsetMax && !flag; ++index)
                    {
                        byte num2 = buffer[index];
                        if ((int)num2 == 92)
                        {
                            ++index;
                            if (index >= offsetMax)
                                break;
                        }
                        else if ((int)num1 == 0)
                        {
                            if ((int)num2 == 39 || (int)num2 == 34)
                                num1 = num2;
                            if ((int)num2 == 58)
                                flag = true;
                        }
                        else if ((int)num2 == (int)num1)
                            num1 = (byte)0;
                    }
                    this.BufferReader.Advance(128);
                }
                else
                    break;
            }
            this.BufferReader.Offset = offset1;
        }

        private void EnterJsonScope(JsonNodeType currentNodeType)
        {
            ++this.scopeDepth;
            if (this.scopes == null)
                this.scopes = new JsonNodeType[4];
            else if (this.scopes.Length == this.scopeDepth)
            {
                JsonNodeType[] jsonNodeTypeArray = new JsonNodeType[this.scopeDepth * 2];
                Array.Copy((Array)this.scopes, (Array)jsonNodeTypeArray, this.scopeDepth);
                this.scopes = jsonNodeTypeArray;
            }
            this.scopes[this.scopeDepth] = currentNodeType;
        }

        private JsonNodeType ExitJsonScope()
        {
            JsonNodeType jsonNodeType = this.scopes[this.scopeDepth];
            this.scopes[this.scopeDepth] = JsonNodeType.None;
            --this.scopeDepth;
            return jsonNodeType;
        }

        private new void MoveToEndElement()
        {
            int num = (int)this.ExitJsonScope();
            base.MoveToEndElement();
        }

        private void MoveToInitial(XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose)
        {
            base.MoveToInitial(quotas);
            this.maxBytesPerRead = quotas.MaxBytesPerRead;
            this.onReaderClose = onClose;
        }

        private void ParseAndSetLocalName()
        {
            XmlBaseReader.XmlElementNode elementNode = this.EnterScope();
            elementNode.NameOffset = this.BufferReader.Offset;
            do
            {
                if ((int)this.BufferReader.GetByte() == 92)
                    this.ReadEscapedCharacter(false);
                else
                    this.ReadQuotedText(false);
            }
            while (this.complexTextMode == XmlJsonReader.JsonComplexTextMode.QuotedText);
            int num1 = this.BufferReader.Offset - 1;
            elementNode.LocalName.SetValue(elementNode.NameOffset, num1 - elementNode.NameOffset);
            elementNode.NameLength = num1 - elementNode.NameOffset;
            elementNode.Namespace.Uri.SetValue(elementNode.NameOffset, 0);
            elementNode.Prefix.SetValue(PrefixHandleType.Empty);
            elementNode.IsEmptyElement = false;
            elementNode.ExitScope = false;
            elementNode.BufferOffset = num1;
            int index1 = (int)this.BufferReader.GetByte(elementNode.NameOffset);
            if (((int)XmlJsonReader.charType[index1] & 1) == 0)
            {
                this.SetJsonNameWithMapping(elementNode);
            }
            else
            {
                int num2 = 0;
                int offset = elementNode.NameOffset;
                while (num2 < elementNode.NameLength)
                {
                    int index2 = (int)this.BufferReader.GetByte(offset);
                    if (((int)XmlJsonReader.charType[index2] & 2) == 0 || index2 >= 128)
                    {
                        this.SetJsonNameWithMapping(elementNode);
                        break;
                    }
                    else
                    {
                        ++num2;
                        ++offset;
                    }
                }
            }
        }

        private void ParseStartElement()
        {
            if (!this.buffered)
                this.BufferElement();
            this.expectingFirstElementInNonPrimitiveChild = false;
            byte @byte = this.BufferReader.GetByte();
            if ((int)@byte == 34)
            {
                this.BufferReader.SkipByte();
                this.ParseAndSetLocalName();
                this.SkipWhitespaceInBufferReader();
                this.SkipExpectedByteInBufferReader((byte)58);
                this.SkipWhitespaceInBufferReader();
                if ((int)this.BufferReader.GetByte() == 123)
                {
                    this.BufferReader.SkipByte();
                    this.expectingFirstElementInNonPrimitiveChild = true;
                }
                this.ReadAttributes();
            }
            else
                XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, "\"", (char)@byte);
        }

        private void ReadAttributes()
        {
            XmlBaseReader.XmlAttributeNode xmlAttributeNode = this.AddAttribute();
            xmlAttributeNode.LocalName.SetConstantValue(StringHandleConstStringType.Type);
            xmlAttributeNode.Namespace.Uri.SetValue(0, 0);
            xmlAttributeNode.Prefix.SetValue(PrefixHandleType.Empty);
            this.SkipWhitespaceInBufferReader();
            byte @byte = this.BufferReader.GetByte();
            byte num = @byte;
            if ((uint)num <= 102U)
            {
                if ((int)num != 34)
                {
                    if ((int)num != 91)
                    {
                        if ((int)num != 102)
                            goto label_15;
                    }
                    else
                    {
                        xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.Array);
                        this.BufferReader.SkipByte();
                        this.EnterJsonScope(JsonNodeType.Collection);
                        return;
                    }
                }
                else if (!this.expectingFirstElementInNonPrimitiveChild)
                {
                    xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.String);
                    return;
                }
                else
                {
                    xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.Object);
                    this.ReadServerTypeAttribute(true);
                    return;
                }
            }
            else
            {
                switch (num)
                {
                    case (byte)110:
                        xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.Null);
                        return;
                    case (byte)116:
                        break;
                    case (byte)123:
                        xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.Object);
                        this.ReadServerTypeAttribute(false);
                        return;
                    case (byte)125:
                        if (this.expectingFirstElementInNonPrimitiveChild)
                        {
                            xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.Object);
                            return;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated method
                            XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
              {
                (object) (char) @byte
              })));
                            return;
                        }
                    default:
                        goto label_15;
                }
            }
            xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.Boolean);
            return;
        label_15:
            if ((int)@byte == 45 || (int)@byte <= 57 && (int)@byte >= 48 || ((int)@byte == 78 || (int)@byte == 73))
            {
                xmlAttributeNode.Value.SetConstantValue(ValueHandleConstStringType.Number);
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
        {
          (object) (char) @byte
        })));
            }
        }

        private void ReadEscapedCharacter(bool moveToText)
        {
            this.BufferReader.SkipByte();
            char ch1 = (char)this.BufferReader.GetByte();
            if ((int)ch1 == 117)
            {
                this.BufferReader.SkipByte();
                int offset;
                byte[] buffer = this.BufferReader.GetBuffer(5, out offset);
                string string1 = Encoding.UTF8.GetString(buffer, offset, 4);
                this.BufferReader.Advance(4);
                int ch2 = (int)XmlJsonReader.ParseChar(string1, NumberStyles.HexNumber);
                if (char.IsHighSurrogate((char)ch2) && (int)this.BufferReader.GetByte() == 92)
                {
                    this.BufferReader.SkipByte();
                    this.SkipExpectedByteInBufferReader((byte)117);
                    buffer = this.BufferReader.GetBuffer(5, out offset);
                    string string2 = Encoding.UTF8.GetString(buffer, offset, 4);
                    this.BufferReader.Advance(4);
                    char ch3 = XmlJsonReader.ParseChar(string2, NumberStyles.HexNumber);
                    if (!char.IsLowSurrogate(ch3))
                        XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(System.Runtime.Serialization.SR.GetString("XmlInvalidLowSurrogate", new object[1]
            {
              (object) string2
            })));
                    ch2 = new SurrogateChar(ch3, (char)ch2).Char;
                }
                if ((int)buffer[offset + 4] == 34)
                {
                    this.BufferReader.SkipByte();
                    if (moveToText)
                        this.MoveToAtomicText().Value.SetCharValue(ch2);
                    this.complexTextMode = XmlJsonReader.JsonComplexTextMode.None;
                }
                else
                {
                    if (moveToText)
                        this.MoveToComplexText().Value.SetCharValue(ch2);
                    this.complexTextMode = XmlJsonReader.JsonComplexTextMode.QuotedText;
                }
            }
            else
            {
                switch (ch1)
                {
                    case 'n':
                        ch1 = '\n';
                        goto case '"';
                    case 'r':
                        ch1 = '\r';
                        goto case '"';
                    case 't':
                        ch1 = '\t';
                        goto case '"';
                    case 'b':
                        ch1 = '\b';
                        goto case '"';
                    case 'f':
                        ch1 = '\f';
                        goto case '"';
                    case '"':
                    case '/':
                    case '\\':
                        this.BufferReader.SkipByte();
                        if ((int)this.BufferReader.GetByte() == 34)
                        {
                            this.BufferReader.SkipByte();
                            if (moveToText)
                                this.MoveToAtomicText().Value.SetCharValue((int)ch1);
                            this.complexTextMode = XmlJsonReader.JsonComplexTextMode.None;
                            break;
                        }
                        else
                        {
                            if (moveToText)
                                this.MoveToComplexText().Value.SetCharValue((int)ch1);
                            this.complexTextMode = XmlJsonReader.JsonComplexTextMode.QuotedText;
                            break;
                        }
                    default:
                        // ISSUE: reference to a compiler-generated method
                        XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
            {
              (object) ch1
            })));
                        goto case '"';
                }
            }
        }

        private void ReadNonExistentElementName(StringHandleConstStringType elementName)
        {
            this.EnterJsonScope(JsonNodeType.Object);
            XmlBaseReader.XmlElementNode xmlElementNode = this.EnterScope();
            xmlElementNode.LocalName.SetConstantValue(elementName);
            xmlElementNode.Namespace.Uri.SetValue(xmlElementNode.NameOffset, 0);
            xmlElementNode.Prefix.SetValue(PrefixHandleType.Empty);
            xmlElementNode.BufferOffset = this.BufferReader.Offset;
            xmlElementNode.IsEmptyElement = false;
            xmlElementNode.ExitScope = false;
            this.ReadAttributes();
        }

        private int ReadNonFFFE()
        {
            int offset;
            byte[] buffer = this.BufferReader.GetBuffer(3, out offset);
            if ((int)buffer[offset + 1] == 191 && ((int)buffer[offset + 2] == 190 || (int)buffer[offset + 2] == 191))
            {
                // ISSUE: reference to a compiler-generated method
                XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonInvalidFFFE, new object[0])));
            }
            return 3;
        }

        private void ReadNumericalText()
        {
            int offset;
            int offsetMax;
            int num;
            if (this.buffered)
            {
                num = XmlJsonReader.ComputeNumericalTextLength(this.BufferReader.GetBuffer(out offset, out offsetMax), offset, offsetMax);
            }
            else
            {
                byte[] buffer = this.BufferReader.GetBuffer(2048, out offset, out offsetMax);
                int numericalTextLength = XmlJsonReader.ComputeNumericalTextLength(buffer, offset, offsetMax);
                num = XmlJsonReader.BreakText(buffer, offset, numericalTextLength);
            }
            this.BufferReader.Advance(num);
            if (offset <= offsetMax - num)
            {
                this.MoveToAtomicText().Value.SetValue(ValueHandleType.UTF8, offset, num);
                this.complexTextMode = XmlJsonReader.JsonComplexTextMode.None;
            }
            else
            {
                this.MoveToComplexText().Value.SetValue(ValueHandleType.UTF8, offset, num);
                this.complexTextMode = XmlJsonReader.JsonComplexTextMode.NumericalText;
            }
        }

        private void ReadQuotedText(bool moveToText)
        {
            int offset;
            int offsetMax;
            bool escaped;
            int num;
            if (this.buffered)
            {
                num = XmlJsonReader.ComputeQuotedTextLengthUntilEndQuote(this.BufferReader.GetBuffer(out offset, out offsetMax), offset, offsetMax, out escaped);
            }
            else
            {
                byte[] buffer = this.BufferReader.GetBuffer(2048, out offset, out offsetMax);
                int lengthUntilEndQuote = XmlJsonReader.ComputeQuotedTextLengthUntilEndQuote(buffer, offset, offsetMax, out escaped);
                num = XmlJsonReader.BreakText(buffer, offset, lengthUntilEndQuote);
            }
            if (escaped && (int)this.BufferReader.GetByte() == 239)
            {
                offset = this.BufferReader.Offset;
                num = this.ReadNonFFFE();
            }
            this.BufferReader.Advance(num);
            if (!escaped && offset < offsetMax - num)
            {
                if (moveToText)
                    this.MoveToAtomicText().Value.SetValue(ValueHandleType.UTF8, offset, num);
                this.SkipExpectedByteInBufferReader((byte)34);
                this.complexTextMode = XmlJsonReader.JsonComplexTextMode.None;
            }
            else if (num == 0 && escaped)
            {
                this.ReadEscapedCharacter(moveToText);
            }
            else
            {
                if (moveToText)
                    this.MoveToComplexText().Value.SetValue(ValueHandleType.UTF8, offset, num);
                this.complexTextMode = XmlJsonReader.JsonComplexTextMode.QuotedText;
            }
        }

        private void ReadServerTypeAttribute(bool consumedObjectChar)
        {
            int num = consumedObjectChar ? -1 : 0;
            int offset;
            int offsetMax;
            byte[] buffer = this.BufferReader.GetBuffer(9 + num, out offset, out offsetMax);
            if (offset + 9 + num > offsetMax || (int)buffer[offset + num + 1] != 34 || ((int)buffer[offset + num + 2] != 95 || (int)buffer[offset + num + 3] != 95) || ((int)buffer[offset + num + 4] != 116 || (int)buffer[offset + num + 5] != 121 || ((int)buffer[offset + num + 6] != 112 || (int)buffer[offset + num + 7] != 101)) || (int)buffer[offset + num + 8] != 34)
                return;
            XmlBaseReader.XmlAttributeNode xmlAttributeNode = this.AddAttribute();
            xmlAttributeNode.LocalName.SetValue(offset + 2 + num, 6);
            xmlAttributeNode.Namespace.Uri.SetValue(0, 0);
            xmlAttributeNode.Prefix.SetValue(PrefixHandleType.Empty);
            this.BufferReader.Advance(9 + num);
            if (!this.buffered)
                this.BufferElement();
            this.SkipWhitespaceInBufferReader();
            this.SkipExpectedByteInBufferReader((byte)58);
            this.SkipWhitespaceInBufferReader();
            this.SkipExpectedByteInBufferReader((byte)34);
            this.BufferReader.GetBuffer(out offset, out offsetMax);
            do
            {
                if ((int)this.BufferReader.GetByte() == 92)
                    this.ReadEscapedCharacter(false);
                else
                    this.ReadQuotedText(false);
            }
            while (this.complexTextMode == XmlJsonReader.JsonComplexTextMode.QuotedText);
            xmlAttributeNode.Value.SetValue(ValueHandleType.UTF8, offset, this.BufferReader.Offset - 1 - offset);
            this.SkipWhitespaceInBufferReader();
            if ((int)this.BufferReader.GetByte() == 44)
            {
                this.BufferReader.SkipByte();
                this.readServerTypeElement = true;
            }
            else if ((int)this.BufferReader.GetByte() == 125)
            {
                this.BufferReader.SkipByte();
                this.readServerTypeElement = false;
                this.expectingFirstElementInNonPrimitiveChild = false;
            }
            else
                this.readServerTypeElement = true;
        }

        private void ResetState()
        {
            this.complexTextMode = XmlJsonReader.JsonComplexTextMode.None;
            this.expectingFirstElementInNonPrimitiveChild = false;
            this.charactersToSkipOnNextRead = new byte[2];
            this.scopeDepth = 0;
            if (this.scopes == null || this.scopes.Length <= 25)
                return;
            this.scopes = (JsonNodeType[])null;
        }

        private void SetJsonNameWithMapping(XmlBaseReader.XmlElementNode elementNode)
        {
            XmlBaseReader.Namespace ns = this.AddNamespace();
            ns.Prefix.SetValue(PrefixHandleType.A);
            ns.Uri.SetConstantValue(StringHandleConstStringType.Item);
            this.AddXmlnsAttribute(ns);
            XmlBaseReader.XmlAttributeNode xmlAttributeNode = this.AddAttribute();
            xmlAttributeNode.LocalName.SetConstantValue(StringHandleConstStringType.Item);
            xmlAttributeNode.Namespace.Uri.SetValue(0, 0);
            xmlAttributeNode.Prefix.SetValue(PrefixHandleType.Empty);
            xmlAttributeNode.Value.SetValue(ValueHandleType.UTF8, elementNode.NameOffset, elementNode.NameLength);
            elementNode.NameLength = 0;
            elementNode.Prefix.SetValue(PrefixHandleType.A);
            elementNode.LocalName.SetConstantValue(StringHandleConstStringType.Item);
            elementNode.Namespace = ns;
        }

        private void SkipExpectedByteInBufferReader(byte characterToSkip)
        {
            if ((int)this.BufferReader.GetByte() != (int)characterToSkip)
                XmlExceptionHelper.ThrowTokenExpected((XmlDictionaryReader)this, ((char)characterToSkip).ToString(), (char)this.BufferReader.GetByte());
            this.BufferReader.SkipByte();
        }

        private void SkipWhitespaceInBufferReader()
        {
            byte ch;
            while (this.TryGetByte(out ch) && XmlJsonReader.IsWhitespace(ch))
                this.BufferReader.SkipByte();
        }

        private bool TryGetByte(out byte ch)
        {
            int offset;
            int offsetMax;
            byte[] buffer = this.BufferReader.GetBuffer(1, out offset, out offsetMax);
            if (offset < offsetMax)
            {
                ch = buffer[offset];
                return true;
            }
            else
            {
                ch = (byte)0;
                return false;
            }
        }

        private string UnescapeJsonString(string val)
        {
            if (val == null)
                return (string)null;
            StringBuilder stringBuilder = (StringBuilder)null;
            int startIndex = 0;
            int count = 0;
            for (int index = 0; index < val.Length; ++index)
            {
                if ((int)val[index] == 92)
                {
                    ++index;
                    if (stringBuilder == null)
                        stringBuilder = new StringBuilder();
                    stringBuilder.Append(val, startIndex, count);
                    if (index >= val.Length)
                    {
                        // ISSUE: reference to a compiler-generated method
                        XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
            {
              (object) val[index]
            })));
                    }
                    switch (val[index])
                    {
                        case 'n':
                            stringBuilder.Append('\n');
                            break;
                        case 'r':
                            stringBuilder.Append('\r');
                            break;
                        case 't':
                            stringBuilder.Append('\t');
                            break;
                        case 'u':
                            if (index + 3 >= val.Length)
                            {
                                // ISSUE: reference to a compiler-generated method
                                XmlExceptionHelper.ThrowXmlException((XmlDictionaryReader)this, new XmlException(SR2.GetString(SR2.JsonEncounteredUnexpectedCharacter, new object[1]
                {
                  (object) val[index]
                })));
                            }
                            stringBuilder.Append(XmlJsonReader.ParseChar(val.Substring(index + 1, 4), NumberStyles.HexNumber));
                            index += 4;
                            break;
                        case 'b':
                            stringBuilder.Append('\b');
                            break;
                        case 'f':
                            stringBuilder.Append('\f');
                            break;
                        case '/':
                        case '\\':
                        case '"':
                        case '\'':
                            stringBuilder.Append(val[index]);
                            break;
                    }
                    startIndex = index + 1;
                    count = 0;
                }
                else
                    ++count;
            }
            if (stringBuilder == null)
                return val;
            if (count > 0)
                stringBuilder.Append(val, startIndex, count);
            return ((object)stringBuilder).ToString();
        }

        private enum JsonComplexTextMode
        {
            QuotedText,
            NumericalText,
            None,
        }

        private static class CharType
        {
            public const byte FirstName = (byte)1;
            public const byte Name = (byte)2;
            public const byte None = (byte)0;
        }
    }
}
