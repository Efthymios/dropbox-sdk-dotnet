// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Auth
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Errors occurred during authentication.</para>
    /// </summary>
    public class AuthError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AuthError> Encoder = new AuthErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AuthError> Decoder = new AuthErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AuthError" /> class.</para>
        /// </summary>
        public AuthError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidAccessToken</para>
        /// </summary>
        public bool IsInvalidAccessToken
        {
            get
            {
                return this is InvalidAccessToken;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidAccessToken, or <c>null</c>.</para>
        /// </summary>
        public InvalidAccessToken AsInvalidAccessToken
        {
            get
            {
                return this as InvalidAccessToken;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidSelectUser</para>
        /// </summary>
        public bool IsInvalidSelectUser
        {
            get
            {
                return this is InvalidSelectUser;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidSelectUser, or <c>null</c>.</para>
        /// </summary>
        public InvalidSelectUser AsInvalidSelectUser
        {
            get
            {
                return this as InvalidSelectUser;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidSelectAdmin</para>
        /// </summary>
        public bool IsInvalidSelectAdmin
        {
            get
            {
                return this is InvalidSelectAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidSelectAdmin, or <c>null</c>.</para>
        /// </summary>
        public InvalidSelectAdmin AsInvalidSelectAdmin
        {
            get
            {
                return this as InvalidSelectAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UserSuspended</para>
        /// </summary>
        public bool IsUserSuspended
        {
            get
            {
                return this is UserSuspended;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserSuspended, or <c>null</c>.</para>
        /// </summary>
        public UserSuspended AsUserSuspended
        {
            get
            {
                return this as UserSuspended;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ExpiredAccessToken</para>
        /// </summary>
        public bool IsExpiredAccessToken
        {
            get
            {
                return this is ExpiredAccessToken;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ExpiredAccessToken, or <c>null</c>.</para>
        /// </summary>
        public ExpiredAccessToken AsExpiredAccessToken
        {
            get
            {
                return this as ExpiredAccessToken;
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
        /// <para>Encoder for  <see cref="AuthError" />.</para>
        /// </summary>
        private class AuthErrorEncoder : enc.StructEncoder<AuthError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AuthError value, enc.IJsonWriter writer)
            {
                if (value is InvalidAccessToken)
                {
                    WriteProperty(".tag", "invalid_access_token", writer, enc.StringEncoder.Instance);
                    InvalidAccessToken.Encoder.EncodeFields((InvalidAccessToken)value, writer);
                    return;
                }
                if (value is InvalidSelectUser)
                {
                    WriteProperty(".tag", "invalid_select_user", writer, enc.StringEncoder.Instance);
                    InvalidSelectUser.Encoder.EncodeFields((InvalidSelectUser)value, writer);
                    return;
                }
                if (value is InvalidSelectAdmin)
                {
                    WriteProperty(".tag", "invalid_select_admin", writer, enc.StringEncoder.Instance);
                    InvalidSelectAdmin.Encoder.EncodeFields((InvalidSelectAdmin)value, writer);
                    return;
                }
                if (value is UserSuspended)
                {
                    WriteProperty(".tag", "user_suspended", writer, enc.StringEncoder.Instance);
                    UserSuspended.Encoder.EncodeFields((UserSuspended)value, writer);
                    return;
                }
                if (value is ExpiredAccessToken)
                {
                    WriteProperty(".tag", "expired_access_token", writer, enc.StringEncoder.Instance);
                    ExpiredAccessToken.Encoder.EncodeFields((ExpiredAccessToken)value, writer);
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
        /// <para>Decoder for  <see cref="AuthError" />.</para>
        /// </summary>
        private class AuthErrorDecoder : enc.UnionDecoder<AuthError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AuthError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AuthError Create()
            {
                return new AuthError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AuthError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invalid_access_token":
                        return InvalidAccessToken.Decoder.DecodeFields(reader);
                    case "invalid_select_user":
                        return InvalidSelectUser.Decoder.DecodeFields(reader);
                    case "invalid_select_admin":
                        return InvalidSelectAdmin.Decoder.DecodeFields(reader);
                    case "user_suspended":
                        return UserSuspended.Decoder.DecodeFields(reader);
                    case "expired_access_token":
                        return ExpiredAccessToken.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The access token is invalid.</para>
        /// </summary>
        public sealed class InvalidAccessToken : AuthError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidAccessToken> Encoder = new InvalidAccessTokenEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidAccessToken> Decoder = new InvalidAccessTokenDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidAccessToken" />
            /// class.</para>
            /// </summary>
            private InvalidAccessToken()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidAccessToken</para>
            /// </summary>
            public static readonly InvalidAccessToken Instance = new InvalidAccessToken();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidAccessToken" />.</para>
            /// </summary>
            private class InvalidAccessTokenEncoder : enc.StructEncoder<InvalidAccessToken>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidAccessToken value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidAccessToken" />.</para>
            /// </summary>
            private class InvalidAccessTokenDecoder : enc.StructDecoder<InvalidAccessToken>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidAccessToken"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidAccessToken Create()
                {
                    return InvalidAccessToken.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The user specified in 'Dropbox-API-Select-User' is no longer on the
        /// team.</para>
        /// </summary>
        public sealed class InvalidSelectUser : AuthError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidSelectUser> Encoder = new InvalidSelectUserEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidSelectUser> Decoder = new InvalidSelectUserDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidSelectUser" />
            /// class.</para>
            /// </summary>
            private InvalidSelectUser()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidSelectUser</para>
            /// </summary>
            public static readonly InvalidSelectUser Instance = new InvalidSelectUser();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidSelectUser" />.</para>
            /// </summary>
            private class InvalidSelectUserEncoder : enc.StructEncoder<InvalidSelectUser>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidSelectUser value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidSelectUser" />.</para>
            /// </summary>
            private class InvalidSelectUserDecoder : enc.StructDecoder<InvalidSelectUser>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidSelectUser"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidSelectUser Create()
                {
                    return InvalidSelectUser.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The user specified in 'Dropbox-API-Select-Admin' is not a Dropbox Business
        /// team admin.</para>
        /// </summary>
        public sealed class InvalidSelectAdmin : AuthError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidSelectAdmin> Encoder = new InvalidSelectAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidSelectAdmin> Decoder = new InvalidSelectAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidSelectAdmin" />
            /// class.</para>
            /// </summary>
            private InvalidSelectAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidSelectAdmin</para>
            /// </summary>
            public static readonly InvalidSelectAdmin Instance = new InvalidSelectAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidSelectAdmin" />.</para>
            /// </summary>
            private class InvalidSelectAdminEncoder : enc.StructEncoder<InvalidSelectAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidSelectAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidSelectAdmin" />.</para>
            /// </summary>
            private class InvalidSelectAdminDecoder : enc.StructDecoder<InvalidSelectAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidSelectAdmin"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidSelectAdmin Create()
                {
                    return InvalidSelectAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The user has been suspended.</para>
        /// </summary>
        public sealed class UserSuspended : AuthError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserSuspended> Encoder = new UserSuspendedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserSuspended> Decoder = new UserSuspendedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserSuspended" />
            /// class.</para>
            /// </summary>
            private UserSuspended()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UserSuspended</para>
            /// </summary>
            public static readonly UserSuspended Instance = new UserSuspended();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserSuspended" />.</para>
            /// </summary>
            private class UserSuspendedEncoder : enc.StructEncoder<UserSuspended>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserSuspended value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserSuspended" />.</para>
            /// </summary>
            private class UserSuspendedDecoder : enc.StructDecoder<UserSuspended>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserSuspended" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserSuspended Create()
                {
                    return UserSuspended.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The access token has expired.</para>
        /// </summary>
        public sealed class ExpiredAccessToken : AuthError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ExpiredAccessToken> Encoder = new ExpiredAccessTokenEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ExpiredAccessToken> Decoder = new ExpiredAccessTokenDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ExpiredAccessToken" />
            /// class.</para>
            /// </summary>
            private ExpiredAccessToken()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ExpiredAccessToken</para>
            /// </summary>
            public static readonly ExpiredAccessToken Instance = new ExpiredAccessToken();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ExpiredAccessToken" />.</para>
            /// </summary>
            private class ExpiredAccessTokenEncoder : enc.StructEncoder<ExpiredAccessToken>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ExpiredAccessToken value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ExpiredAccessToken" />.</para>
            /// </summary>
            private class ExpiredAccessTokenDecoder : enc.StructDecoder<ExpiredAccessToken>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ExpiredAccessToken"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ExpiredAccessToken Create()
                {
                    return ExpiredAccessToken.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AuthError
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
