﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DotNetty.Transport.Channels
{
    using System;

    public interface IChannelId : IComparable<IChannelId>
    {
        string AsShortText();

        string AsLongText();
    }
}