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
    /// <para>The group user management policy object</para>
    /// </summary>
    public class GroupUserManagementPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupUserManagementPolicy> Encoder = new GroupUserManagementPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupUserManagementPolicy> Decoder = new GroupUserManagementPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupUserManagementPolicy" />
        /// class.</para>
        /// </summary>
        public GroupUserManagementPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AdminsOnly</para>
        /// </summary>
        public bool IsAdminsOnly
        {
            get
            {
                return this is AdminsOnly;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AdminsOnly, or <c>null</c>.</para>
        /// </summary>
        public AdminsOnly AsAdminsOnly
        {
            get
            {
                return this as AdminsOnly;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AllUsers</para>
        /// </summary>
        public bool IsAllUsers
        {
            get
            {
                return this is AllUsers;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AllUsers, or <c>null</c>.</para>
        /// </summary>
        public AllUsers AsAllUsers
        {
            get
            {
                return this as AllUsers;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupUserManagementPolicy" />.</para>
        /// </summary>
        private class GroupUserManagementPolicyEncoder : enc.StructEncoder<GroupUserManagementPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupUserManagementPolicy value, enc.IJsonWriter writer)
            {
                if (value is AdminsOnly)
                {
                    WriteProperty(".tag", "admins_only", writer, enc.StringEncoder.Instance);
                    AdminsOnly.Encoder.EncodeFields((AdminsOnly)value, writer);
                    return;
                }
                if (value is AllUsers)
                {
                    WriteProperty(".tag", "all_users", writer, enc.StringEncoder.Instance);
                    AllUsers.Encoder.EncodeFields((AllUsers)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupUserManagementPolicy" />.</para>
        /// </summary>
        private class GroupUserManagementPolicyDecoder : enc.UnionDecoder<GroupUserManagementPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupUserManagementPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupUserManagementPolicy Create()
            {
                return new GroupUserManagementPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupUserManagementPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "admins_only":
                        return AdminsOnly.Decoder.DecodeFields(reader);
                    case "all_users":
                        return AllUsers.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The admins only object</para>
        /// </summary>
        public sealed class AdminsOnly : GroupUserManagementPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AdminsOnly> Encoder = new AdminsOnlyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AdminsOnly> Decoder = new AdminsOnlyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AdminsOnly" /> class.</para>
            /// </summary>
            private AdminsOnly()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AdminsOnly</para>
            /// </summary>
            public static readonly AdminsOnly Instance = new AdminsOnly();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AdminsOnly" />.</para>
            /// </summary>
            private class AdminsOnlyEncoder : enc.StructEncoder<AdminsOnly>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AdminsOnly value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AdminsOnly" />.</para>
            /// </summary>
            private class AdminsOnlyDecoder : enc.StructDecoder<AdminsOnly>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AdminsOnly" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AdminsOnly Create()
                {
                    return AdminsOnly.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The all users object</para>
        /// </summary>
        public sealed class AllUsers : GroupUserManagementPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AllUsers> Encoder = new AllUsersEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AllUsers> Decoder = new AllUsersDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AllUsers" /> class.</para>
            /// </summary>
            private AllUsers()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AllUsers</para>
            /// </summary>
            public static readonly AllUsers Instance = new AllUsers();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AllUsers" />.</para>
            /// </summary>
            private class AllUsersEncoder : enc.StructEncoder<AllUsers>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AllUsers value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AllUsers" />.</para>
            /// </summary>
            private class AllUsersDecoder : enc.StructDecoder<AllUsers>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AllUsers" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AllUsers Create()
                {
                    return AllUsers.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GroupUserManagementPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}