﻿/*
 * Copyright (c) 2014 Optimal Payments
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
 * associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute,
 * sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
 * NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimalPayments.Common
{
    public class OptimalException : Exception
    {
        public OptimalException()
            : base()
        {

        }

        public OptimalException(String message)
            : base(message)
        {

        }

        public OptimalException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        private Dictionary<string, object> _rawResponse = new Dictionary<string, object>();

        private int _code = -1;

        public void rawResponse(Dictionary<string, object> data)
        {
            this._rawResponse = data;
        }

        public Dictionary<string, object> rawResponse()
        {
            return this._rawResponse;
        }

        public void code(int data)
        {
            this._code = data;
        }

        public int cpde()
        {
            return this._code;
        }
    }
}