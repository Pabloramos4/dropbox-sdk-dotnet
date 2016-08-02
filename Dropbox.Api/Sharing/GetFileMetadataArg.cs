// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Arguments of <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.GetFileMetadataAsync" /></para>
    /// </summary>
    public class GetFileMetadataArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetFileMetadataArg> Encoder = new GetFileMetadataArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetFileMetadataArg> Decoder = new GetFileMetadataArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetFileMetadataArg" />
        /// class.</para>
        /// </summary>
        /// <param name="file">The file to query.</param>
        /// <param name="actions">File actions to query.</param>
        public GetFileMetadataArg(string file,
                                  col.IEnumerable<FileAction> actions = null)
        {
            if (file == null)
            {
                throw new sys.ArgumentNullException("file");
            }
            if (file.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("file", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(file, @"\A(?:((/|id:).*|nspath:[^:]*:[^:]*))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("file", @"Value should match pattern '\A(?:((/|id:).*|nspath:[^:]*:[^:]*))\z'");
            }

            var actionsList = enc.Util.ToList(actions);

            this.File = file;
            this.Actions = actionsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetFileMetadataArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetFileMetadataArg()
        {
        }

        /// <summary>
        /// <para>The file to query.</para>
        /// </summary>
        public string File { get; protected set; }

        /// <summary>
        /// <para>File actions to query.</para>
        /// </summary>
        public col.IList<FileAction> Actions { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetFileMetadataArg" />.</para>
        /// </summary>
        private class GetFileMetadataArgEncoder : enc.StructEncoder<GetFileMetadataArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetFileMetadataArg value, enc.IJsonWriter writer)
            {
                WriteProperty("file", value.File, writer, enc.StringEncoder.Instance);
                if (value.Actions.Count > 0)
                {
                    WriteListProperty("actions", value.Actions, writer, Dropbox.Api.Sharing.FileAction.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetFileMetadataArg" />.</para>
        /// </summary>
        private class GetFileMetadataArgDecoder : enc.StructDecoder<GetFileMetadataArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetFileMetadataArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetFileMetadataArg Create()
            {
                return new GetFileMetadataArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetFileMetadataArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file":
                        value.File = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "actions":
                        value.Actions = ReadList<FileAction>(reader, Dropbox.Api.Sharing.FileAction.Decoder);
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