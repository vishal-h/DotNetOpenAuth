﻿// <auto-generated/> // disable StyleCop on this file
//-----------------------------------------------------------------------
// <copyright file="Protocol.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2 {
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// An enumeration of the OAuth protocol versions supported by this library.
	/// </summary>
	public enum ProtocolVersion {
		/// <summary>
		/// The OAuth 2.0 specification.
		/// </summary>
		V20,
	}

	/// <summary>
	/// Protocol constants for OAuth 2.0.
	/// </summary>
	internal class Protocol {
		/// <summary>
		/// The HTTP authorization scheme "Bearer";
		/// </summary>
		internal const string BearerHttpAuthorizationScheme = "Bearer";

		/// <summary>
		/// The HTTP authorization scheme "Bearer ";
		/// </summary>
		internal const string BearerHttpAuthorizationSchemeWithTrailingSpace = BearerHttpAuthorizationScheme + " ";

		/// <summary>
		/// The format of the HTTP Authorization header value that authorizes OAuth 2.0 requests using bearer access tokens.
		/// </summary>
		internal const string BearerHttpAuthorizationHeaderFormat = BearerHttpAuthorizationSchemeWithTrailingSpace + "{0}";

		/// <summary>
		/// The name of the parameter whose value is an OAuth 2.0 bearer access token, as it is defined
		/// in a URL-encoded POST entity or URL query string.
		/// </summary>
		internal const string BearerTokenEncodedUrlParameterName = "access_token";

		/// <summary>
		/// The "type" string.
		/// </summary>
		internal const string type = "type";

		/// <summary>
		/// The "state" string.
		/// </summary>
		internal const string state = "state";

		/// <summary>
		/// The "redirect_uri_mismatch" string.
		/// </summary>
		internal const string redirect_uri_mismatch = "redirect_uri_mismatch";

		/// <summary>
		/// The "bad_verification_code" string.
		/// </summary>
		internal const string bad_verification_code = "bad_verification_code";

		/// <summary>
		/// The "incorrect_client_credentials" string.
		/// </summary>
		internal const string incorrect_client_credentials = "incorrect_client_credentials";

		/// <summary>
		/// The "unauthorized_client" string.
		/// </summary>
		internal const string unauthorized_client = "unauthorized_client";

		/// <summary>
		/// The "authorization_expired" string.
		/// </summary>
		internal const string authorization_expired = "authorization_expired";

		/// <summary>
		/// The "redirect_uri" string.
		/// </summary>
		internal const string redirect_uri = "redirect_uri";

		/// <summary>
		/// The "client_id" string.
		/// </summary>
		internal const string client_id = "client_id";

		/// <summary>
		/// The "scope" string.
		/// </summary>
		internal const string scope = "scope";

		/// <summary>
		/// The "immediate" string.
		/// </summary>
		internal const string immediate = "immediate";

		/// <summary>
		/// The "client_secret" string.
		/// </summary>
		internal const string client_secret = "client_secret";

		/// <summary>
		/// The "code" string.
		/// </summary>
		internal const string code = "code";

		/// <summary>
		/// The "user_code" string.
		/// </summary>
		internal const string user_code = "user_code";

		/// <summary>
		/// The "verification_uri" string.
		/// </summary>
		internal const string verification_uri = "verification_uri";

		/// <summary>
		/// The "interval" string.
		/// </summary>
		internal const string interval = "interval";

		/// <summary>
		/// The "error" string.
		/// </summary>
		internal const string error = "error";

		/// <summary>
		/// The "access_token" string.
		/// </summary>
		internal const string access_token = "access_token";

		/// <summary>
		/// The "access_token_secret" string.
		/// </summary>
		internal const string access_token_secret = "access_token_secret";

		/// <summary>
		/// The "token_type" string.
		/// </summary>
		internal const string token_type = "token_type";

		/// <summary>
		/// The "refresh_token" string.
		/// </summary>
		internal const string refresh_token = "refresh_token";

		/// <summary>
		/// The "expires_in" string.
		/// </summary>
		internal const string expires_in = "expires_in";

		/// <summary>
		/// The "expired_delegation_code" string.
		/// </summary>
		internal const string expired_delegation_code = "expired_delegation_code";

		/// <summary>
		/// The "username" string.
		/// </summary>
		internal const string username = "username";

		/// <summary>
		/// The "password" string.
		/// </summary>
		internal const string password = "password";

		/// <summary>
		/// The "format" string.
		/// </summary>
		internal const string format = "format";

		/// <summary>
		/// The "assertion" string.
		/// </summary>
		internal const string assertion = "assertion";

		/// <summary>
		/// The "assertion_type" string.
		/// </summary>
		internal const string assertion_type = "assertion_type";

		/// <summary>
		/// The "user_denied" string.
		/// </summary>
		internal const string user_denied = "user_denied";

		/// <summary>
		/// Gets the <see cref="Protocol"/> instance with values initialized for V1.0 of the protocol.
		/// </summary>
		internal static readonly Protocol V20 = new Protocol {
			Version = new Version(2, 0),
			ProtocolVersion = ProtocolVersion.V20,
		};

		/// <summary>
		/// A list of all supported OAuth versions, in order starting from newest version.
		/// </summary>
		internal static readonly List<Protocol> AllVersions = new List<Protocol>() { V20 };

		/// <summary>
		/// The default (or most recent) supported version of the OpenID protocol.
		/// </summary>
		internal static readonly Protocol Default = AllVersions[0];

		/// <summary>
		/// The "error_uri" string.
		/// </summary>
		public const string error_uri = "error_uri";

		/// <summary>
		/// The "error_description" string.
		/// </summary>
		internal const string error_description = "error_description";

		/// <summary>
		/// The "response_type" string.
		/// </summary>
		internal const string response_type = "response_type";

		/// <summary>
		/// The "grant_type" string.
		/// </summary>
		internal const string grant_type = "grant_type";

		/// <summary>
		/// Gets or sets the OAuth 2.0 version represented by this instance.
		/// </summary>
		/// <value>The version.</value>
		internal Version Version { get; private set; }

		/// <summary>
		/// Gets or sets the OAuth 2.0 version represented by this instance.
		/// </summary>
		/// <value>The protocol version.</value>
		internal ProtocolVersion ProtocolVersion { get; private set; }

		/// <summary>
		/// Gets the OAuth Protocol instance to use for the given version.
		/// </summary>
		/// <param name="version">The OAuth version to get.</param>
		/// <returns>A matching <see cref="Protocol"/> instance.</returns>
		public static Protocol Lookup(ProtocolVersion version) {
			switch (version) {
				case ProtocolVersion.V20: return Protocol.V20;
				default: throw new ArgumentOutOfRangeException("version");
			}
		}

		/// <summary>
		/// Values for the "response_type" parameter.
		/// </summary>
		internal static class ResponseTypes
		{
			/// <summary>
			/// The string "code".
			/// </summary>
			internal const string Code = "code";

			/// <summary>
			/// The string "token".
			/// </summary>
			internal const string Token = "token";
		}

		internal static class GrantTypes
		{
			internal const string AuthorizationCode = "authorization_code";

			internal const string Password = "password";

			internal const string Assertion = "assertion";

			internal const string RefreshToken = "refresh_token";

			internal const string ClientCredentials = "client_credentials";
		}

		/// <summary>
		/// Error codes that an authorization server can return to a client in response to a malformed or unsupported access token request.
		/// </summary>
		internal static class AccessTokenRequestErrorCodes
		{
			/// <summary>
			/// The request is missing a required parameter, includes an unknown parameter or parameter value, repeats a parameter, includes multiple credentials, utilizes more than one mechanism for authenticating the client, or is otherwise malformed.
			/// </summary>
			internal const string InvalidRequest = "invalid_request";

			/// <summary>
			/// The client is not authorized to use the access grant type provided.
			/// </summary>
			internal const string UnauthorizedClient = "unauthorized_client";

			/// <summary>
			/// The resource owner or authorization server denied the request.
			/// </summary>
			internal const string AccessDenied = "access_denied";

			/// <summary>
			/// The authorization server does not support obtaining an access token using this method.
			/// </summary>
			internal const string UnsupportedGrantType = "unsupported_response_type";

			/// <summary>
			/// The requested scope is invalid, unknown, malformed, or exceeds the previously granted scope.
			/// </summary>
			internal const string InvalidScope = "invalid_scope";
		}

		/// <summary>
		/// Error codes that an authorization server can return to a client in response to a malformed or unsupported end user authorization request.
		/// </summary>
		internal static class EndUserAuthorizationRequestErrorCodes
		{
			/// <summary>
			/// The request is missing a required parameter, includes an unknown parameter or parameter value, or is otherwise malformed.
			/// </summary>
			internal const string InvalidRequest = "invalid_request";

			/// <summary>
			/// The client is not authorized to use the requested response type.
			/// </summary>
			internal const string UnauthorizedClient = "unauthorized_client";

			/// <summary>
			/// The end-user or authorization server denied the request.
			/// </summary>
			internal const string AccessDenied = "access_denied";

			/// <summary>
			/// The requested response type is not supported by the authorization server.
			/// </summary>
			internal const string UnsupportedResponseType = "unsupported_response_type";

			/// <summary>
			/// The requested scope is invalid, unknown, or malformed.
			/// </summary>
			internal const string InvalidScope = "invalid_scope";
		}

		/// <summary>
		/// Recognized access token types.
		/// </summary>
		internal static class AccessTokenTypes {
			/// <summary>
			/// The "bearer" token type.
			/// </summary>
			internal const string Bearer = "bearer";
		}
	}
}
