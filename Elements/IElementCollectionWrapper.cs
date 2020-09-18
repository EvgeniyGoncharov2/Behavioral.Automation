﻿using System.Collections.Generic;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Behavioral.Automation.Elements
{
    /// <summary>
    /// Interface used for interactions with web-elements collections (For example, when multiple elements have the same locator)
    /// </summary>
    public interface IElementCollectionWrapper : IWebElementWrapper
    {
        IEnumerable<IWebElementWrapper> Elements { [NotNull, ItemNotNull] get; }

        void ClickByIndex(int index);

        string GetAttributeByIndex([NotNull] string attribute, int index);
    }
}
