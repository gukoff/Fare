﻿/*
 * dk.brics.automaton
 * 
 * Copyright (c) 2001-2011 Anders Moeller
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in the
 *    documentation and/or other materials provided with the distribution.
 * 3. The name of the author may not be used to endorse or promote products
 *    derived from this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 * THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 * THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;

namespace NAutomaton
{
    public static class BasicAutomata
    {
        public static Automaton MakeInterval(int min, int max, int digits)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a new (deterministic) automaton that accepts a single character of the given value.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public static Automaton MakeChar(char c)
        {
            var a = new Automaton();
            a.Singleton = c.ToString();
            a.IsDeterministic = true;
            return a;
        }

        public static Automaton MakeCharRange(char from, char to)
        {
            throw new NotImplementedException();
        }

        public static Automaton MakeAnyChar()
        {
            throw new NotImplementedException();
        }

        public static Automaton MakeEmpty()
        {
            throw new NotImplementedException();
        }

        public static Automaton MakeString(string s)
        {
            throw new NotImplementedException();
        }

        public static Automaton MakeAnyString()
        {
            throw new NotImplementedException();
        }
    }
}