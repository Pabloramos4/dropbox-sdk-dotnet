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
    /// <para>Enabled or disabled Google single sign-on for the team.</para>
    /// </summary>
    public class GoogleSsoChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GoogleSsoChangePolicyDetails> Encoder = new GoogleSsoChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GoogleSsoChangePolicyDetails> Decoder = new GoogleSsoChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GoogleSsoChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New Google single sign-on policy.</param>
        /// <param name="previousValue">Previous Google single sign-on policy. Might be missing
        /// due to historical data gap.</param>
        public GoogleSsoChangePolicyDetails(GoogleSsoPolicy newValue,
                                            GoogleSsoPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GoogleSsoChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GoogleSsoChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New Google single sign-on policy.</para>
        /// </summary>
        public GoogleSsoPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous Google single sign-on policy. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public GoogleSsoPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GoogleSsoChangePolicyDetails" />.</para>
        /// </summary>
        private class GoogleSsoChangePolicyDetailsEncoder : enc.StructEncoder<GoogleSsoChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GoogleSsoChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.GoogleSsoPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.GoogleSsoPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GoogleSsoChangePolicyDetails" />.</para>
        /// </summary>
        private class GoogleSsoChangePolicyDetailsDecoder : enc.StructDecoder<GoogleSsoChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GoogleSsoChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GoogleSsoChangePolicyDetails Create()
            {
                return new GoogleSsoChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GoogleSsoChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.GoogleSsoPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.GoogleSsoPolicy.Decoder.Decode(reader);
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