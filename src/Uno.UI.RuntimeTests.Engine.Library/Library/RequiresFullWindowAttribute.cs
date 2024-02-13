﻿#if !IS_UNO_RUNTIMETEST_PROJECT
#pragma warning disable
#endif
#nullable enable

using System;

namespace Uno.UI.RuntimeTests;

#if !UNO_RUNTIMETESTS_DISABLE_LIBRARY && !UNO_RUNTIMETESTS_DISABLE_REQUIRESFULLWINDOWATTRIBUTE
/// <summary>
/// Marks a test which sets its test UI to be full-screen (Window.Content).
/// </summary>
public sealed class RequiresFullWindowAttribute : Attribute
{
}
#endif