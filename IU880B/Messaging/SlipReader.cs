// <copyright file="SlipReader.cs" company="Poul Erik Venø Hansen">
// Copyright (c) Poul Erik Venø Hansen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.IO;
using System.Threading.Tasks;

namespace FosterBuster.IU880B.Messaging
{
    /// <summary>
    /// Extracts SLIP-delimited bytes from a stream.
    /// </summary>
    public class SlipReader
    {
        private const int BufferSize = 1024;
        private const byte SlipEnd = 0xC0;

        private readonly Func<byte[], Task> _onSlipFrameAvailable;

        private byte[] _buffer = new byte[BufferSize];
        private int _bufferLength = 0;
        private int _pointer = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="SlipReader"/> class.
        /// </summary>
        /// <param name="onSlipFrameAvailable">Action to send the frame to.</param>
        public SlipReader(Func<byte[], Task> onSlipFrameAvailable)
        {
            _onSlipFrameAvailable = onSlipFrameAvailable ?? throw new ArgumentNullException(nameof(onSlipFrameAvailable));
        }

        /// <summary>
        /// Reads SLIP-frames from the stream.
        /// </summary>
        /// <param name="stream">the stream to read from.</param>
        /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
        public async Task Read(Stream stream)
        {
            var startIndex = -1;
            var endIndex = -1;

            var numberOfBytesRead = await stream.ReadAsync(_buffer, _pointer, BufferSize - _pointer).ConfigureAwait(false);

            _bufferLength = numberOfBytesRead + _pointer;

            for (var i = 0; i < _bufferLength; i++)
            {
                var currentByte = _buffer[i];

                if (startIndex == -1 && currentByte == SlipEnd)
                {
                    startIndex = i;
                }
                else if (endIndex == -1 && currentByte == SlipEnd)
                {
                    endIndex = i;
                }

                if (startIndex != -1 && endIndex != -1)
                {
                    var fullFrameLength = endIndex - startIndex + 1;
                    var fullFrame = new byte[fullFrameLength];

                    Buffer.BlockCopy(_buffer, startIndex, fullFrame, 0, fullFrameLength);

                    if (endIndex + 1 != _bufferLength)
                    {
                        _pointer = endIndex;
                        startIndex = -1;
                        endIndex = -1;
                    }
                    else
                    {
                        _pointer = 0;
                        _buffer = new byte[BufferSize];
                    }

                    await _onSlipFrameAvailable(fullFrame).ConfigureAwait(false);
                }
                else
                {
                    _pointer = _bufferLength;
                }
            }
        }
    }
}