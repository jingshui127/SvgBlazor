﻿using System;
using SvgBlazor.Docs.Interfaces;

namespace SvgBlazor.Docs.Examples
{
    public class TextBasicExample : IExampleCode
    {
        public void Example(SvgComponent svg)
        {
            /* #example-code-start */
            var text = new SvgText
            {
                X = 10,
                Y = 20,
                Text = "This is just awesome!",
            };
            /* #example-code-end */
            svg.Add(text);
        }
    }
}