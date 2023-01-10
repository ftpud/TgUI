﻿using TgUI.View;

namespace TgUI.Attributes;

[System.AttributeUsage(System.AttributeTargets.Method)]
public class CallbackAttribute : Attribute
{
    public String Trigger { get; set; }

}