﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VSCodeDebug
{

    public class StackFrame
    {
        public int id { get; }
        public Source source { get; }
        public int line { get; }
        public int column { get; }
        public string name { get; }

        public StackFrame(int id, string name, Source source, int line, int column)
        {
            this.id = id;
            this.name = name;
            this.source = source;
            this.line = line;
            this.column = column;
        }
    }
}
