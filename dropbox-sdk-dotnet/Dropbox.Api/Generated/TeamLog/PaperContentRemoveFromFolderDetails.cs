// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Removed Paper doc/folder from folder.</para>
    /// </summary>
    public class PaperContentRemoveFromFolderDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperContentRemoveFromFolderDetails> Encoder = new PaperContentRemoveFromFolderDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperContentRemoveFromFolderDetails> Decoder = new PaperContentRemoveFromFolderDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PaperContentRemoveFromFolderDetails" /> class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        /// <param name="targetAssetIndex">Target asset position in the Assets list.</param>
        /// <param name="parentAssetIndex">Parent asset position in the Assets list.</param>
        public PaperContentRemoveFromFolderDetails(string eventUuid,
                                                   ulong targetAssetIndex,
                                                   ulong parentAssetIndex)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            this.EventUuid = eventUuid;
            this.TargetAssetIndex = targetAssetIndex;
            this.ParentAssetIndex = parentAssetIndex;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PaperContentRemoveFromFolderDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperContentRemoveFromFolderDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        /// <summary>
        /// <para>Target asset position in the Assets list.</para>
        /// </summary>
        public ulong TargetAssetIndex { get; protected set; }

        /// <summary>
        /// <para>Parent asset position in the Assets list.</para>
        /// </summary>
        public ulong ParentAssetIndex { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperContentRemoveFromFolderDetails" />.</para>
        /// </summary>
        private class PaperContentRemoveFromFolderDetailsEncoder : enc.StructEncoder<PaperContentRemoveFromFolderDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperContentRemoveFromFolderDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
                WriteProperty("target_asset_index", value.TargetAssetIndex, writer, enc.UInt64Encoder.Instance);
                WriteProperty("parent_asset_index", value.ParentAssetIndex, writer, enc.UInt64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperContentRemoveFromFolderDetails" />.</para>
        /// </summary>
        private class PaperContentRemoveFromFolderDetailsDecoder : enc.StructDecoder<PaperContentRemoveFromFolderDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="PaperContentRemoveFromFolderDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperContentRemoveFromFolderDetails Create()
            {
                return new PaperContentRemoveFromFolderDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperContentRemoveFromFolderDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "target_asset_index":
                        value.TargetAssetIndex = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "parent_asset_index":
                        value.ParentAssetIndex = enc.UInt64Decoder.Instance.Decode(reader);
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
