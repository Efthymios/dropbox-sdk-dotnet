// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileProperties
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The properties search continue arg object</para>
    /// </summary>
    public class PropertiesSearchContinueArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PropertiesSearchContinueArg> Encoder = new PropertiesSearchContinueArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PropertiesSearchContinueArg> Decoder = new PropertiesSearchContinueArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PropertiesSearchContinueArg" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">The cursor returned by your last call to <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.PropertiesSearchAsync"
        /// /> or <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.PropertiesSearchContinueAsync"
        /// />.</param>
        public PropertiesSearchContinueArg(string cursor)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }
            if (cursor.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("cursor", "Length should be at least 1");
            }

            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PropertiesSearchContinueArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PropertiesSearchContinueArg()
        {
        }

        /// <summary>
        /// <para>The cursor returned by your last call to <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.PropertiesSearchAsync"
        /// /> or <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.PropertiesSearchContinueAsync"
        /// />.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PropertiesSearchContinueArg" />.</para>
        /// </summary>
        private class PropertiesSearchContinueArgEncoder : enc.StructEncoder<PropertiesSearchContinueArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PropertiesSearchContinueArg value, enc.IJsonWriter writer)
            {
                WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PropertiesSearchContinueArg" />.</para>
        /// </summary>
        private class PropertiesSearchContinueArgDecoder : enc.StructDecoder<PropertiesSearchContinueArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PropertiesSearchContinueArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PropertiesSearchContinueArg Create()
            {
                return new PropertiesSearchContinueArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PropertiesSearchContinueArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}