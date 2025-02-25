// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The AS2 agreement mdn settings. </summary>
    public partial class AS2MdnSettings
    {
        /// <summary> Initializes a new instance of <see cref="AS2MdnSettings"/>. </summary>
        /// <param name="needMdn"> The value indicating whether to send or request a MDN. </param>
        /// <param name="signMdn"> The value indicating whether the MDN needs to be signed or not. </param>
        /// <param name="sendMdnAsynchronously"> The value indicating whether to send the asynchronous MDN. </param>
        /// <param name="signOutboundMdnIfOptional"> The value indicating whether to sign the outbound MDN if optional. </param>
        /// <param name="sendInboundMdnToMessageBox"> The value indicating whether to send inbound MDN to message box. </param>
        /// <param name="micHashingAlgorithm"> The signing or hashing algorithm. </param>
        public AS2MdnSettings(bool needMdn, bool signMdn, bool sendMdnAsynchronously, bool signOutboundMdnIfOptional, bool sendInboundMdnToMessageBox, AS2HashingAlgorithm micHashingAlgorithm)
        {
            NeedMdn = needMdn;
            SignMdn = signMdn;
            SendMdnAsynchronously = sendMdnAsynchronously;
            SignOutboundMdnIfOptional = signOutboundMdnIfOptional;
            SendInboundMdnToMessageBox = sendInboundMdnToMessageBox;
            MicHashingAlgorithm = micHashingAlgorithm;
        }

        /// <summary> Initializes a new instance of <see cref="AS2MdnSettings"/>. </summary>
        /// <param name="needMdn"> The value indicating whether to send or request a MDN. </param>
        /// <param name="signMdn"> The value indicating whether the MDN needs to be signed or not. </param>
        /// <param name="sendMdnAsynchronously"> The value indicating whether to send the asynchronous MDN. </param>
        /// <param name="receiptDeliveryUri"> The receipt delivery URL. </param>
        /// <param name="dispositionNotificationTo"> The disposition notification to header value. </param>
        /// <param name="signOutboundMdnIfOptional"> The value indicating whether to sign the outbound MDN if optional. </param>
        /// <param name="mdnText"> The MDN text. </param>
        /// <param name="sendInboundMdnToMessageBox"> The value indicating whether to send inbound MDN to message box. </param>
        /// <param name="micHashingAlgorithm"> The signing or hashing algorithm. </param>
        internal AS2MdnSettings(bool needMdn, bool signMdn, bool sendMdnAsynchronously, Uri receiptDeliveryUri, string dispositionNotificationTo, bool signOutboundMdnIfOptional, string mdnText, bool sendInboundMdnToMessageBox, AS2HashingAlgorithm micHashingAlgorithm)
        {
            NeedMdn = needMdn;
            SignMdn = signMdn;
            SendMdnAsynchronously = sendMdnAsynchronously;
            ReceiptDeliveryUri = receiptDeliveryUri;
            DispositionNotificationTo = dispositionNotificationTo;
            SignOutboundMdnIfOptional = signOutboundMdnIfOptional;
            MdnText = mdnText;
            SendInboundMdnToMessageBox = sendInboundMdnToMessageBox;
            MicHashingAlgorithm = micHashingAlgorithm;
        }

        /// <summary> The value indicating whether to send or request a MDN. </summary>
        public bool NeedMdn { get; set; }
        /// <summary> The value indicating whether the MDN needs to be signed or not. </summary>
        public bool SignMdn { get; set; }
        /// <summary> The value indicating whether to send the asynchronous MDN. </summary>
        public bool SendMdnAsynchronously { get; set; }
        /// <summary> The receipt delivery URL. </summary>
        public Uri ReceiptDeliveryUri { get; set; }
        /// <summary> The disposition notification to header value. </summary>
        public string DispositionNotificationTo { get; set; }
        /// <summary> The value indicating whether to sign the outbound MDN if optional. </summary>
        public bool SignOutboundMdnIfOptional { get; set; }
        /// <summary> The MDN text. </summary>
        public string MdnText { get; set; }
        /// <summary> The value indicating whether to send inbound MDN to message box. </summary>
        public bool SendInboundMdnToMessageBox { get; set; }
        /// <summary> The signing or hashing algorithm. </summary>
        public AS2HashingAlgorithm MicHashingAlgorithm { get; set; }
    }
}
