// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-23-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-23-2018
// ***********************************************************************
// <copyright file="OutputWindow.cs" company="Zeroit Dev Technologies">
//    This program contains Utilities for all C# programming activities.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Zeroit.Framework.Utilities.IO.Compression.Zip.Compression.Streams 
{

    /// <summary>
    /// Contains the output from the Inflation process.
    /// We need to have a window so that we can refer backwards into the output stream
    /// to repeat stuff.<br />
    /// Author of the original java version : John Leuner
    /// </summary>
    public class OutputWindow
	{
        /// <summary>
        /// The window size
        /// </summary>
        private static int WINDOW_SIZE = 1 << 15;
        /// <summary>
        /// The window mask
        /// </summary>
        private static int WINDOW_MASK = WINDOW_SIZE - 1;

        /// <summary>
        /// The window
        /// </summary>
        private byte[] window = new byte[WINDOW_SIZE]; //The window is 2^15 bytes
                                                       /// <summary>
                                                       /// The window end
                                                       /// </summary>
        private int windowEnd  = 0;
        /// <summary>
        /// The window filled
        /// </summary>
        private int windowFilled = 0;

        /// <summary>
        /// Write a byte to this output window
        /// </summary>
        /// <param name="abyte">value to write</param>
        /// <exception cref="InvalidOperationException">if window is full</exception>
        public void Write(int abyte)
		{
			if (windowFilled++ == WINDOW_SIZE) {
				throw new InvalidOperationException("Window full");
			}
			window[windowEnd++] = (byte) abyte;
			windowEnd &= WINDOW_MASK;
		}


        /// <summary>
        /// Slows the repeat.
        /// </summary>
        /// <param name="repStart">The rep start.</param>
        /// <param name="len">The length.</param>
        /// <param name="dist">The dist.</param>
        private void SlowRepeat(int repStart, int len, int dist)
		{
			while (len-- > 0) {
				window[windowEnd++] = window[repStart++];
				windowEnd &= WINDOW_MASK;
				repStart &= WINDOW_MASK;
			}
		}

        /// <summary>
        /// Append a byte pattern already in the window itself
        /// </summary>
        /// <param name="len">length of pattern to copy</param>
        /// <param name="dist">distance from end of window pattern occurs</param>
        /// <exception cref="InvalidOperationException">If the repeated data overflows the window</exception>
        public void Repeat(int len, int dist)
		{
			if ((windowFilled += len) > WINDOW_SIZE) {
				throw new InvalidOperationException("Window full");
			}
			
			int rep_start = (windowEnd - dist) & WINDOW_MASK;
			int border = WINDOW_SIZE - len;
			if (rep_start <= border && windowEnd < border) {
				if (len <= dist) {
					System.Array.Copy(window, rep_start, window, windowEnd, len);
					windowEnd += len;
				} else {
					/* We have to copy manually, since the repeat pattern overlaps. */
					while (len-- > 0) {
						window[windowEnd++] = window[rep_start++];
					}
				}
			} else {
				SlowRepeat(rep_start, len, dist);
			}
		}

        /// <summary>
        /// Copy from input manipulator to internal window
        /// </summary>
        /// <param name="input">source of data</param>
        /// <param name="len">length of data to copy</param>
        /// <returns>the number of bytes copied</returns>
        public int CopyStored(StreamManipulator input, int len)
		{
			len = Math.Min(Math.Min(len, WINDOW_SIZE - windowFilled), input.AvailableBytes);
			int copied;
			
			int tailLen = WINDOW_SIZE - windowEnd;
			if (len > tailLen) {
				copied = input.CopyBytes(window, windowEnd, tailLen);
				if (copied == tailLen) {
					copied += input.CopyBytes(window, 0, len - tailLen);
				}
			} else {
				copied = input.CopyBytes(window, windowEnd, len);
			}
			
			windowEnd = (windowEnd + copied) & WINDOW_MASK;
			windowFilled += copied;
			return copied;
		}

        /// <summary>
        /// Copy dictionary to window
        /// </summary>
        /// <param name="dict">source dictionary</param>
        /// <param name="offset">offset of start in source dictionary</param>
        /// <param name="len">length of dictionary</param>
        /// <exception cref="InvalidOperationException">If window isnt empty</exception>
        public void CopyDict(byte[] dict, int offset, int len)
		{
			if (windowFilled > 0) {
				throw new InvalidOperationException();
			}
			
			if (len > WINDOW_SIZE) {
				offset += len - WINDOW_SIZE;
				len = WINDOW_SIZE;
			}
			System.Array.Copy(dict, offset, window, 0, len);
			windowEnd = len & WINDOW_MASK;
		}

        /// <summary>
        /// Get remaining unfilled space in window
        /// </summary>
        /// <returns>Number of bytes left in window</returns>
        public int GetFreeSpace()
		{
			return WINDOW_SIZE - windowFilled;
		}

        /// <summary>
        /// Get bytes available for output in window
        /// </summary>
        /// <returns>Number of bytes filled</returns>
        public int GetAvailable()
		{
			return windowFilled;
		}

        /// <summary>
        /// Copy contents of window to output
        /// </summary>
        /// <param name="output">buffer to copy to</param>
        /// <param name="offset">offset to start at</param>
        /// <param name="len">number of bytes to count</param>
        /// <returns>The number of bytes copied</returns>
        /// <exception cref="InvalidOperationException">If a window underflow occurs</exception>
        public int CopyOutput(byte[] output, int offset, int len)
		{
			int copy_end = windowEnd;
			if (len > windowFilled) {
				len = windowFilled;
			} else {
				copy_end = (windowEnd - windowFilled + len) & WINDOW_MASK;
			}
			
			int copied = len;
			int tailLen = len - copy_end;
			
			if (tailLen > 0) {
				System.Array.Copy(window, WINDOW_SIZE - tailLen, output, offset, tailLen);
				offset += tailLen;
				len = copy_end;
			}
			System.Array.Copy(window, copy_end - len, output, offset, len);
			windowFilled -= copied;
			if (windowFilled < 0) {
				throw new InvalidOperationException();
			}
			return copied;
		}

        /// <summary>
        /// Reset by clearing window so <see cref="GetAvailable">GetAvailable</see> returns 0
        /// </summary>
        public void Reset()
		{
			windowFilled = windowEnd = 0;
		}
	}
}
