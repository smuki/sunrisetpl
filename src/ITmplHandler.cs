﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

using Volte.Bot.Tpl.Tokens;
namespace Volte.Bot.Tpl
{
    public interface ITmplHandler {
        void BeforeProcess(VoltEngine manager);

        void AfterProcess(VoltEngine manager);

        void BeforeProcess(VoltEngine manager, Tag tag, ref bool processInnerTokens, ref bool captureInnerContent);

        void AfterProcess(VoltEngine manager, Tag tag, string innerContent);

    }
}
