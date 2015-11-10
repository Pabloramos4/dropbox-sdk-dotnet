// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The information about a member of the shared folder.</para>
    /// </summary>
    /// <seealso cref="GroupMembershipInfo" />
    /// <seealso cref="InviteeMembershipInfo" />
    /// <seealso cref="UserMembershipInfo" />
    public class MembershipInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembershipInfo> Encoder = new MembershipInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembershipInfo> Decoder = new MembershipInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembershipInfo" /> class.</para>
        /// </summary>
        /// <param name="accessType">The access type for this member.</param>
        public MembershipInfo(AccessLevel accessType)
        {
            if (accessType == null)
            {
                throw new sys.ArgumentNullException("accessType");
            }

            this.AccessType = accessType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembershipInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public MembershipInfo()
        {
        }

        /// <summary>
        /// <para>The access type for this member.</para>
        /// </summary>
        public AccessLevel AccessType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembershipInfo" />.</para>
        /// </summary>
        private class MembershipInfoEncoder : enc.StructEncoder<MembershipInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembershipInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, AccessLevel.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembershipInfo" />.</para>
        /// </summary>
        private class MembershipInfoDecoder : enc.StructDecoder<MembershipInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembershipInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembershipInfo Create()
            {
                return new MembershipInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MembershipInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = AccessLevel.Decoder.Decode(reader);
                        break;
                    default:
                        SkipProperty(reader);
                        break;
                }
            }
        }

        #endregion
    }
}