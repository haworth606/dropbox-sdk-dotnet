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
    /// <para>The showcase access granted type object</para>
    /// </summary>
    public class ShowcaseAccessGrantedType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShowcaseAccessGrantedType> Encoder = new ShowcaseAccessGrantedTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShowcaseAccessGrantedType> Decoder = new ShowcaseAccessGrantedTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseAccessGrantedType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public ShowcaseAccessGrantedType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseAccessGrantedType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ShowcaseAccessGrantedType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the showcase access granted type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShowcaseAccessGrantedType" />.</para>
        /// </summary>
        private class ShowcaseAccessGrantedTypeEncoder : enc.StructEncoder<ShowcaseAccessGrantedType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShowcaseAccessGrantedType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShowcaseAccessGrantedType" />.</para>
        /// </summary>
        private class ShowcaseAccessGrantedTypeDecoder : enc.StructDecoder<ShowcaseAccessGrantedType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ShowcaseAccessGrantedType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShowcaseAccessGrantedType Create()
            {
                return new ShowcaseAccessGrantedType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ShowcaseAccessGrantedType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
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
